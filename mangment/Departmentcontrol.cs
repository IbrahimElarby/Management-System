using mangment.Context;
using mangment.Models;
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

namespace mangment
{
    public partial class Departmentcontrol : UserControl
    {
        public Departmentcontrol()
        {
            InitializeComponent();
        }

        EFITIContext db = new EFITIContext();
        private void reset()
        {
            name.Text = "";
            Location.Text = "";

        }
        private void loadbtn_Click(object sender, EventArgs e)
        {

            db.Departments.Load();
            selecteddepartment.DataSource = db.Departments.Local.ToBindingList();
            departmentGridView.DataSource = db.Departments.Local.ToBindingList();
            selecteddepartment.DisplayMember = "Name";
            selecteddepartment.ValueMember = "DepartmentId";
            db.Instructors.Load();
            selectedmanger.DataSource = db.Instructors.Local.ToBindingList();
            selectedmanger.DisplayMember = "FullName";
            selectedmanger.ValueMember = "Id";
        }


        private void insertbtnd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(Location.Text) ||
                selectedmanger.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields before inserting.");
                return;
            }

            Department department = new Department
            {
                Name = name.Text,
                Location = Location.Text,
                MangerId = int.Parse(selectedmanger.SelectedValue.ToString())
            };

            db.Add(department);
            try
            {
                db.SaveChanges();
                MessageBox.Show("department inserted successfully.");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting instructor: " + ex.Message);
            }
        }

        private void selecteddepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selecteddepartment.SelectedValue != null && int.TryParse(selecteddepartment.SelectedValue.ToString(), out int departmentId))
            {
                var s = db.Departments.FirstOrDefault(s => s.DepartmentId == departmentId);
                if (s != null)
                {
                    name.Text = s.Name;
                    Location.Text = s.Location;
                    selectedmanger.SelectedValue = s.MangerId;
                }
            }
        }

        private void updatebtnd_Click(object sender, EventArgs e)
        {
            var s = db.Departments.Find((int)selecteddepartment.SelectedValue);

            if (s != null)
            {
                s.Name = name.Text;
                s.Location = Location.Text;
                s.MangerId = int.Parse(selectedmanger.SelectedValue.ToString());

                db.Update(s);

                try
                {
                    db.SaveChanges();
                    departmentGridView.Refresh();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtnd_Click(object sender, EventArgs e)
        {
            if (selecteddepartment.SelectedValue == null || !int.TryParse(selecteddepartment.SelectedValue.ToString(), out int departmentId))
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }

            var s = db.Departments.FirstOrDefault(d => d.DepartmentId  == departmentId);
            if (s == null)
            {
                MessageBox.Show("Department not found.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Department?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Departments.Remove(s);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Department deleted successfully.");
                    reset();
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show("Error: Cannot delete this department because they are referenced in another table.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}
