namespace mangment
{
    partial class Studentcontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadbtn = new Button();
            firstname = new TextBox();
            studentGridView = new DataGridView();
            lastname = new TextBox();
            phone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            selectedstudent = new ComboBox();
            deletebtn = new Button();
            updatebtn = new Button();
            insertbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // loadbtn
            // 
            loadbtn.BackColor = Color.SaddleBrown;
            loadbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.ForeColor = Color.White;
            loadbtn.Location = new Point(957, 369);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(128, 53);
            loadbtn.TabIndex = 1;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = false;
            loadbtn.Click += loadbtn_Click;
            // 
            // firstname
            // 
            firstname.Location = new Point(878, 146);
            firstname.Name = "firstname";
            firstname.Size = new Size(251, 27);
            firstname.TabIndex = 2;
            firstname.TextChanged += firstname_TextChanged;
            // 
            // studentGridView
            // 
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.GridColor = Color.SaddleBrown;
            studentGridView.Location = new Point(97, 20);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 51;
            studentGridView.Size = new Size(746, 318);
            studentGridView.TabIndex = 4;
            // 
            // lastname
            // 
            lastname.Location = new Point(878, 225);
            lastname.Name = "lastname";
            lastname.Size = new Size(251, 27);
            lastname.TabIndex = 6;
            // 
            // phone
            // 
            phone.Location = new Point(878, 291);
            phone.Name = "phone";
            phone.Size = new Size(251, 27);
            phone.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(878, 263);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 7;
            label3.Text = "Phone ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(878, 103);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(878, 197);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 11;
            label5.Text = "Last Name";
            // 
            // selectedstudent
            // 
            selectedstudent.ForeColor = Color.SaddleBrown;
            selectedstudent.FormattingEnabled = true;
            selectedstudent.Location = new Point(884, 50);
            selectedstudent.Name = "selectedstudent";
            selectedstudent.Size = new Size(257, 28);
            selectedstudent.TabIndex = 12;
            selectedstudent.SelectedIndexChanged += selectedstudent_SelectedIndexChanged;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.SaddleBrown;
            deletebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(140, 369);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(128, 53);
            deletebtn.TabIndex = 13;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.SaddleBrown;
            updatebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = Color.White;
            updatebtn.Location = new Point(406, 369);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(128, 53);
            updatebtn.TabIndex = 14;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.SaddleBrown;
            insertbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.ForeColor = Color.White;
            insertbtn.Location = new Point(683, 369);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(128, 53);
            insertbtn.TabIndex = 15;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // Studentcontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(insertbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(selectedstudent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(lastname);
            Controls.Add(studentGridView);
            Controls.Add(firstname);
            Controls.Add(loadbtn);
            Name = "Studentcontrol";
            Size = new Size(1182, 448);
            Load += Studentcontrol_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loadbtn;
        private TextBox firstname;
        private DataGridView studentGridView;
        private TextBox lastname;
        private TextBox phone;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox selectedstudent;
        private Button deletebtn;
        private Button updatebtn;
        private Button insertbtn;
    }
}
