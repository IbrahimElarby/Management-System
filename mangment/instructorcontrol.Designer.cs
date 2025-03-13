namespace mangment
{
    partial class instructorcontrol
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
            insertbtnI = new Button();
            updatebtnI = new Button();
            deletebtnI = new Button();
            selectedinstructor = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            phone = new TextBox();
            label3 = new Label();
            lastname = new TextBox();
            studentGridView = new DataGridView();
            firstname = new TextBox();
            loadbtn = new Button();
            selecteddepartment = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // insertbtnI
            // 
            insertbtnI.BackColor = Color.SaddleBrown;
            insertbtnI.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtnI.ForeColor = Color.White;
            insertbtnI.Location = new Point(683, 379);
            insertbtnI.Name = "insertbtnI";
            insertbtnI.Size = new Size(128, 53);
            insertbtnI.TabIndex = 27;
            insertbtnI.Text = "Insert";
            insertbtnI.UseVisualStyleBackColor = false;
            insertbtnI.Click += insertbtnI_Click_1;
            // 
            // updatebtnI
            // 
            updatebtnI.BackColor = Color.SaddleBrown;
            updatebtnI.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtnI.ForeColor = Color.White;
            updatebtnI.Location = new Point(406, 379);
            updatebtnI.Name = "updatebtnI";
            updatebtnI.Size = new Size(128, 53);
            updatebtnI.TabIndex = 26;
            updatebtnI.Text = "Update";
            updatebtnI.UseVisualStyleBackColor = false;
            updatebtnI.Click += updatebtnI_Click_1;
            // 
            // deletebtnI
            // 
            deletebtnI.BackColor = Color.SaddleBrown;
            deletebtnI.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtnI.ForeColor = Color.White;
            deletebtnI.Location = new Point(136, 379);
            deletebtnI.Name = "deletebtnI";
            deletebtnI.Size = new Size(128, 53);
            deletebtnI.TabIndex = 25;
            deletebtnI.Text = "Delete";
            deletebtnI.UseVisualStyleBackColor = false;
            deletebtnI.Click += deletebtnI_Click_1;
            // 
            // selectedinstructor
            // 
            selectedinstructor.ForeColor = Color.SaddleBrown;
            selectedinstructor.FormattingEnabled = true;
            selectedinstructor.Location = new Point(869, 21);
            selectedinstructor.Name = "selectedinstructor";
            selectedinstructor.Size = new Size(257, 28);
            selectedinstructor.TabIndex = 24;
            selectedinstructor.SelectedIndexChanged += selectedinstructor_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(869, 144);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 23;
            label5.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(869, 71);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 22;
            label4.Text = "First Name";
            // 
            // phone
            // 
            phone.Location = new Point(869, 240);
            phone.Name = "phone";
            phone.Size = new Size(251, 27);
            phone.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(869, 212);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 20;
            label3.Text = "Phone ";
            // 
            // lastname
            // 
            lastname.Location = new Point(869, 182);
            lastname.Name = "lastname";
            lastname.Size = new Size(251, 27);
            lastname.TabIndex = 19;
            // 
            // studentGridView
            // 
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.GridColor = Color.SaddleBrown;
            studentGridView.Location = new Point(16, 21);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 51;
            studentGridView.Size = new Size(798, 318);
            studentGridView.TabIndex = 18;
            // 
            // firstname
            // 
            firstname.Location = new Point(869, 99);
            firstname.Name = "firstname";
            firstname.Size = new Size(251, 27);
            firstname.TabIndex = 17;
            // 
            // loadbtn
            // 
            loadbtn.BackColor = Color.SaddleBrown;
            loadbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.ForeColor = Color.White;
            loadbtn.Location = new Point(932, 379);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(128, 53);
            loadbtn.TabIndex = 16;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = false;
            loadbtn.Click += loadbtn_Click;
            // 
            // selecteddepartment
            // 
            selecteddepartment.ForeColor = Color.SaddleBrown;
            selecteddepartment.FormattingEnabled = true;
            selecteddepartment.Location = new Point(869, 303);
            selecteddepartment.Name = "selecteddepartment";
            selecteddepartment.Size = new Size(257, 28);
            selecteddepartment.TabIndex = 28;
            selecteddepartment.SelectedIndexChanged += selecteddepartment_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(869, 275);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 29;
            label1.Text = "Department";
            // 
            // instructorcontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label1);
            Controls.Add(selecteddepartment);
            Controls.Add(insertbtnI);
            Controls.Add(updatebtnI);
            Controls.Add(deletebtnI);
            Controls.Add(selectedinstructor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(lastname);
            Controls.Add(studentGridView);
            Controls.Add(firstname);
            Controls.Add(loadbtn);
            Name = "instructorcontrol";
            Size = new Size(1160, 521);
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertbtnI;
        private Button updatebtnI;
        private Button deletebtnI;
        private ComboBox selectedinstructor;
        private Label label5;
        private Label label4;
        private TextBox phone;
        private Label label3;
        private TextBox lastname;
        private DataGridView studentGridView;
        private TextBox firstname;
        private Button loadbtn;
        private ComboBox selecteddepartment;
        private Label label1;
    }
}
