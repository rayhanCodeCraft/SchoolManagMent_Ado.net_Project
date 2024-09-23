using SchoolManagMent.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagMent
{
    public partial class Form1 : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int intSchoolId = 0;
        string strPreviousImage = "";
        bool defaultImage = true;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LoaddgvSchoolList();
            LoadSchoolTypeCmb();
        }

        private void LoadSchoolTypeCmb()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM schoolType", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow topRow = dt.NewRow();
                topRow[0] = 0;
                topRow[1] = "--Select--";
                dt.Rows.InsertAt(topRow, 0);
                cmbSchoolType.ValueMember = "TypeId";
                cmbSchoolType.DisplayMember = "TypeTitle";
                cmbSchoolType.DataSource = dt;
                cmbSchoolType.SelectedIndex = 0;
            }
        }

        private void LoaddgvSchoolList()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllSchoolInformation", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "ImgFile", dr["ImagePath"].ToString());
                    if (File.Exists(imagePath))
                    {
                        dr["Image"] = File.ReadAllBytes(imagePath);
                    }
                    else
                    {
                        // Optionally, you can provide a default image or handle the case where the image file is missing.
                        // For example, you can set the "Image" column to null or provide a placeholder image.
                        // Here, I'm setting it to null.
                        dr["Image"] = DBNull.Value;
                    }
                }
                //foreach (DataRow dr in dt.Rows)
                //{
                //    dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\ImgFile\\" + dr["ImagePath"].ToString());
                //}
                dgvSchoolList.RowTemplate.Height = 80;
                dgvSchoolList.DataSource = dt;

                ((DataGridViewImageColumn)dgvSchoolList.Columns[dgvSchoolList.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvSchoolList.AllowUserToAddRows = false;
                sda.Dispose();
            }
        }

        private void Clear()
        {
            studentCodeTextBox.Text = "";
            studentNameTextBox.Text = "";
            //cmbSchoolType.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            rbtnBangla.Checked = true;
            chkStatus.Checked = true;
            intSchoolId = 0;
            deleteBtn.Enabled = false;
            btnSave_Click.Text = "Save";
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\ImgFile\\clientimg.png");
            defaultImage = true;
            if (dgvResult.DataSource == null)
            {
                dgvResult.Rows.Clear();
            }
            else
            {
                dgvResult.DataSource = (dgvResult.DataSource as DataTable).Clone();
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {




                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter("ViewSchoolInfoBySchoolId", con))
                        {
                            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sda.SelectCommand.Parameters.AddWithValue("@SchoolId", intSchoolId);
                            DataSet ds = new DataSet();
                            sda.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow dr = ds.Tables[0].Rows[0];
                                if (dr["ImagePath"] != DBNull.Value)
                                {
                                    string image = dr["ImagePath"].ToString();
                                    string filename = Path.Combine(Application.StartupPath, "ImgFile", image);
                                    if (File.Exists(filename))
                                    {
                                        File.Delete(filename);
                                    }
                                }
                            }
                        }

                        using (SqlCommand cmd = new SqlCommand("SchoolInfoAndResultDelete", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@SchoolId", intSchoolId);
                            cmd.ExecuteNonQuery();
                        }

                        LoaddgvSchoolList();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        

       
        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\ImgFile\\clientimg.png");
            defaultImage = true;
            strPreviousImage = "";


        }
        bool ValidateMasterDetailForm()
        {
            bool isValid = true;
            if (studentNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("School name is required");
                isValid = false;
            }
            return isValid;

        }
        string SaveImage(string imgPath)
        {
            string fileName = Path.GetFileNameWithoutExtension(imgPath);
            string ext = Path.GetExtension(imgPath);
            fileName = fileName.Length <= 15 ? fileName : fileName.Substring(0, 15);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + ext;
            pictureBox1.Image.Save(Application.StartupPath + "\\ImgFile\\" + fileName);
            return fileName;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }



        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png,.png)|*.png;*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                if (intSchoolId == 0)
                {
                    defaultImage = false;
                    strPreviousImage = "";
                }

            }

        }




        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int intSchoolId = 0;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SchoolInformationAddOrEdit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SchoolId", intSchoolId);
                    cmd.Parameters.AddWithValue("@SchoolCode", studentCodeTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@SchoolName", studentNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@TypeId", Convert.ToInt16(cmbSchoolType.SelectedValue));
                    cmd.Parameters.AddWithValue("@EstablishedDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@IsGovernment", chkStatus.Checked ? "True" : "False");
                    cmd.Parameters.AddWithValue("@Madium", rbtnBangla.Checked ? "Bangla" : "English");
                    if (defaultImage)
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }

                    else if (intSchoolId > 0 && strPreviousImage != "")
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                        //if (ofd.FileName != strPreviousImage)
                        //{
                        //    var filename = Application.StartupPath + "\\ImgFile\\" + strPreviousImage;
                        //    //if (pictureBox1.Image != null)
                        //    //{
                        //    //    pictureBox1.Image.Dispose();
                        //    //    pictureBox1.Image = null;
                        //    //    System.IO.File.Delete(filename);
                        //    //}
                        //}

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                    }
                    intSchoolId = Convert.ToInt16(cmd.ExecuteScalar());
                }
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    foreach (DataGridViewRow item in dgvResult.Rows)
                    {
                        if (item.IsNewRow) break;
                        else
                        {
                            SqlCommand cmd = new SqlCommand("SchoolResultAddAndEdit", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ResultId", Convert.ToInt32(item.Cells["dgvResultId"].Value == DBNull.Value ? "0" : item.Cells["dgvResultId"].Value));
                            cmd.Parameters.AddWithValue("@SchoolId", intSchoolId);
                            cmd.Parameters.AddWithValue("@ExamType", item.Cells["dgvExamType"].Value);
                            cmd.Parameters.AddWithValue("@TotalMarks", item.Cells["dgvTotalMarks"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }




                }
                LoaddgvSchoolList();
                Clear();
                MessageBox.Show("Submitted Successfully");
            }
        }

      

        private void dgvSchoolList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvResult.CurrentRow;
            if (dgvRow.Cells["dgvResultId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SchoolResultDelete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ResultId", dgvRow.Cells["dgvResultId"].Value);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllSchoolInformation", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                List<SchoolViewModel> list = new List<SchoolViewModel>();
                SchoolViewModel schoolVm; // Corrected variable name to follow conventional naming

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        schoolVm = new SchoolViewModel();

                        schoolVm.SchoolId = row["SchoolId"] != DBNull.Value ? Convert.ToInt32(row["SchoolId"]) : 0;
                        schoolVm.SchoolCode = row["SchoolCode"].ToString();
                        schoolVm.SchoolName = row["SchoolName"].ToString();

                        // Handling DBNull for LaunchDate
                        if (DateTime.TryParse(row["EstablishedDate"].ToString(), out DateTime EstablishedDate))
                            schoolVm.EstablishedDate = EstablishedDate;

                        schoolVm.Madium = row["Madium"].ToString();

                        // Handling DBNull for IsAvailable
                        if (bool.TryParse(row["IsGovernment"].ToString(), out bool IsGovernment))
                            schoolVm.IsGovernment = IsGovernment;

                        // Handling DBNull for TotalModelWithPrice
                        schoolVm.TotalMarks = row["TotalMark"] != DBNull.Value ? Convert.ToInt32(row["TotalMark"]) : 0;

                        schoolVm.TypeTitle = row["TypeTitle"].ToString();
                        schoolVm.ImagePath = Application.StartupPath + "\\images\\" + row["ImagePath"].ToString();

                        list.Add(schoolVm);
                    }

                    using (SchoolReport report = new SchoolReport(list))
                    {
                        report.ShowDialog();
                    }
                }
                else
                {
                    // Handle case when no data is retrieved from the database
                    MessageBox.Show("No data available to generate report.");
                }


            }

        }

        private void dgvSchoolList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSchoolList.CurrentRow != null && dgvSchoolList.CurrentRow.Index != -1)
            {
                int intSchoolId;
                if (int.TryParse(dgvSchoolList.CurrentRow.Cells[0].Value?.ToString(), out intSchoolId))
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        try
                        {
                            con.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter("ViewSchoolInfoBySchoolId", con))
                            {
                                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                                sda.SelectCommand.Parameters.AddWithValue("@SchoolId", intSchoolId);
                                DataSet ds = new DataSet();
                                sda.Fill(ds);

                                if (ds.Tables.Count >= 2 && ds.Tables[0].Rows.Count > 0)
                                {
                                    DataRow dr = ds.Tables[0].Rows[0];
                                    studentCodeTextBox.Text = dr["SchoolCode"].ToString();
                                    studentNameTextBox.Text = dr["SchoolName"].ToString();
                                    cmbSchoolType.SelectedValue = Convert.ToInt32(dr["TypeId"]);
                                    dateTimePicker1.Value = Convert.ToDateTime(dr["EstablishedDate"]);
                                    chkStatus.Checked = Convert.ToBoolean(dr["IsGovernment"]);
                                    rbtnBangla.Checked = dr["Madium"].ToString().Trim() == "Bangla";
                                    EnglishRbtn.Checked = !rbtnBangla.Checked;
                                    strPreviousImage = dr["ImagePath"].ToString();

                                    if (dr["ImagePath"] == DBNull.Value)
                                    {
                                        pictureBox1.Image = new Bitmap(Application.StartupPath + "\\ImgFile\\clientimg.png");
                                    }
                                    else
                                    {
                                        string imagePath = Path.Combine(Application.StartupPath, "ImgFile", strPreviousImage);
                                        if (File.Exists(imagePath))
                                        {
                                            pictureBox1.Image = new Bitmap(imagePath);
                                            defaultImage = false;
                                        }
                                    }
                                }

                                dgvResult.AutoGenerateColumns = false;
                                dgvResult.DataSource = ds.Tables.Count >= 2 ? ds.Tables[1] : null;
                                deleteBtn.Enabled = true;
                                btnSave_Click.Text = "Update";
                                tabControl1.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }











            //if (dgvSchoolList.CurrentRow.Index != -1)
            //{
            //    DataGridViewRow dgvRow = dgvSchoolList.CurrentRow;
            //    intSchoolId = Convert.ToInt32(dgvRow.Cells[0].Value);
            //    using (SqlConnection con = new SqlConnection(conStr))
            //    {
            //        con.Open();
            //        SqlDataAdapter sda = new SqlDataAdapter("ViewSchoolInfoBySchoolId", con);
            //        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //        sda.SelectCommand.Parameters.AddWithValue("@SchoolId", intSchoolId);
            //        DataSet ds = new DataSet();
            //        sda.Fill(ds);
            //        //--Master---
            //        DataRow dr = ds.Tables[0].Rows[0];
            //        studentCodeTextBox.Text = dr["SchoolCode"].ToString();
            //        studentNameTextBox.Text = dr["SchoolName"].ToString();
            //        cmbSchoolType.SelectedValue = Convert.ToInt32(dr["TypeId"].ToString());
            //        dateTimePicker1.Value = Convert.ToDateTime(dr["EstablishedDate"].ToString());
            //        if (Convert.ToBoolean(dr["IsGovernment"].ToString()))
            //        {
            //            chkStatus.Checked = true;
            //        }
            //        else
            //        {
            //            chkStatus.Checked = false;
            //        }
            //        if ((dr["Madium"].ToString().Trim()) == "Bangla")
            //        {
            //            rbtnBangla.Checked = true;
            //        }
            //        else
            //        {
            //            rbtnBangla.Checked = false;
            //        }
            //        if ((dr["Madium"].ToString().Trim()) == "English")
            //        {
            //            EnglishRbtn.Checked = true;
            //        }
            //        else
            //        {
            //            EnglishRbtn.Checked = false;
            //        }
            //        if (dr["ImagePath"] == DBNull.Value)
            //        {
            //            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\ImgFile\\clientimg.png");
            //        }
            //        else
            //        {
            //            string image = dr["ImagePath"].ToString();
            //            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\ImgFile\\" + dr["ImagePath"].ToString());
            //            strPreviousImage = dr["ImagePath"].ToString();
            //            defaultImage = false;
            //        }
            //        //--Details---
            //        dgvResult.AutoGenerateColumns = false;
            //        dgvResult.DataSource = ds.Tables[1];
            //        deleteBtn.Enabled = true;
            //        btnSave_Click.Text = "Update";
            //        tabControl1.SelectedIndex = 0;
            //    }
            //}

        }
    }
    
}
