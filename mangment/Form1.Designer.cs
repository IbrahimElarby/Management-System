namespace mangment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            studentviewbtn = new Button();
            instructorbtn = new Button();
            departmentviewbtn = new Button();
            courseviewbtn = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1267, 444);
            panel1.TabIndex = 0;
            // 
            // studentviewbtn
            // 
            studentviewbtn.BackColor = Color.Peru;
            studentviewbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentviewbtn.ForeColor = Color.White;
            studentviewbtn.Location = new Point(34, 451);
            studentviewbtn.Name = "studentviewbtn";
            studentviewbtn.Size = new Size(216, 60);
            studentviewbtn.TabIndex = 1;
            studentviewbtn.Text = "Students";
            studentviewbtn.UseVisualStyleBackColor = false;
            studentviewbtn.Click += studentviewbtn_Click;
            // 
            // instructorbtn
            // 
            instructorbtn.BackColor = Color.Peru;
            instructorbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructorbtn.ForeColor = Color.White;
            instructorbtn.Location = new Point(308, 451);
            instructorbtn.Name = "instructorbtn";
            instructorbtn.Size = new Size(216, 60);
            instructorbtn.TabIndex = 2;
            instructorbtn.Text = "Instructors";
            instructorbtn.UseVisualStyleBackColor = false;
            instructorbtn.Click += instructorbtn_Click;
            // 
            // departmentviewbtn
            // 
            departmentviewbtn.BackColor = Color.Peru;
            departmentviewbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentviewbtn.ForeColor = Color.White;
            departmentviewbtn.Location = new Point(567, 451);
            departmentviewbtn.Name = "departmentviewbtn";
            departmentviewbtn.Size = new Size(216, 60);
            departmentviewbtn.TabIndex = 3;
            departmentviewbtn.Text = "Department";
            departmentviewbtn.UseVisualStyleBackColor = false;
            departmentviewbtn.Click += departmentviewbtn_Click;
            // 
            // courseviewbtn
            // 
            courseviewbtn.BackColor = Color.Peru;
            courseviewbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseviewbtn.ForeColor = Color.White;
            courseviewbtn.Location = new Point(817, 451);
            courseviewbtn.Name = "courseviewbtn";
            courseviewbtn.Size = new Size(216, 60);
            courseviewbtn.TabIndex = 4;
            courseviewbtn.Text = "Course";
            courseviewbtn.UseVisualStyleBackColor = false;
            courseviewbtn.Click += courseviewbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 523);
            Controls.Add(courseviewbtn);
            Controls.Add(departmentviewbtn);
            Controls.Add(instructorbtn);
            Controls.Add(studentviewbtn);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button studentviewbtn;
        private Button instructorbtn;
        private Button departmentviewbtn;
        private Button courseviewbtn;
    }
}
