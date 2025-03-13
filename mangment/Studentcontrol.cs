using mangment.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mangment.Models;

namespace mangment
{
    public partial class Studentcontrol : UserControl
    {
        EFITIContext db = new EFITIContext();
        public Studentcontrol()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {

            db.Students.Load();
            studentGridView.DataSource = db.Students.Local.ToBindingList();
            selectedstudent.DataSource = db.Students.Local.ToBindingList();
            selectedstudent.DisplayMember = "FullName";
            selectedstudent.ValueMember = "Id";
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }



        private void selectedstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedstudent.SelectedValue != null && int.TryParse(selectedstudent.SelectedValue.ToString(), out int studentId))
            {
                var s = db.Students.FirstOrDefault(st => st.Id == studentId);
                if (s != null)
                {
                    firstname.Text = s.FName;
                    lastname.Text = s.LName;
                    phone.Text = s.Phone;
                }
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {

            Student student = new Student { FName = firstname.Text, LName = lastname.Text, Phone = phone.Text };
            if (student != null)
            {
                db.Add(student);
                try
                {

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var s = db.Students.Find(selectedstudent.SelectedValue);
            if (s != null)
            {
                s.FName = firstname.Text;
                s.LName = lastname.Text;
                s.Phone = phone.Text;
                db.Update(s);

                try
                {
                    db.SaveChanges();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedstudent.SelectedValue != null && int.TryParse(selectedstudent.SelectedValue.ToString(), out int studentId))
            {
                var s = db.Students.FirstOrDefault(st => st.Id == studentId);
                if (s != null)
                {
                    db.Students.Remove(s);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Student deleted successfully.");
                        reset(); // Ensure reset() properly refreshes the UI
                    }
                    catch (DbUpdateException dbEx)
                    {
                        MessageBox.Show("Error: Cannot delete this student because they are referenced in another table.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid student.");
            }
        }

        private void reset()
        {
            firstname.Text = "";
            lastname.Text = "";
            phone.Text = "";
        }

        private void Studentcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
