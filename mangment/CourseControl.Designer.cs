namespace mangment
{
    partial class CourseControl
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
            label1 = new Label();
            selecteddepartment = new ComboBox();
            insertbtnd = new Button();
            updatebtnd = new Button();
            deletebtnd = new Button();
            selectedcourse = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            duration = new TextBox();
            courseGridView = new DataGridView();
            name = new TextBox();
            loadbtn = new Button();
            label2 = new Label();
            selectedinstructor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)courseGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(869, 217);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 55;
            label1.Text = "Department";
            // 
            // selecteddepartment
            // 
            selecteddepartment.ForeColor = Color.SaddleBrown;
            selecteddepartment.FormattingEnabled = true;
            selecteddepartment.Location = new Point(869, 257);
            selecteddepartment.Name = "selecteddepartment";
            selecteddepartment.Size = new Size(257, 28);
            selecteddepartment.TabIndex = 54;
            // 
            // insertbtnd
            // 
            insertbtnd.BackColor = Color.SaddleBrown;
            insertbtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtnd.ForeColor = Color.White;
            insertbtnd.Location = new Point(683, 371);
            insertbtnd.Name = "insertbtnd";
            insertbtnd.Size = new Size(128, 53);
            insertbtnd.TabIndex = 53;
            insertbtnd.Text = "Insert";
            insertbtnd.UseVisualStyleBackColor = false;
            insertbtnd.Click += insertbtnd_Click;
            // 
            // updatebtnd
            // 
            updatebtnd.BackColor = Color.SaddleBrown;
            updatebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtnd.ForeColor = Color.White;
            updatebtnd.Location = new Point(406, 371);
            updatebtnd.Name = "updatebtnd";
            updatebtnd.Size = new Size(128, 53);
            updatebtnd.TabIndex = 52;
            updatebtnd.Text = "Update";
            updatebtnd.UseVisualStyleBackColor = false;
            updatebtnd.Click += updatebtnd_Click;
            // 
            // deletebtnd
            // 
            deletebtnd.BackColor = Color.SaddleBrown;
            deletebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtnd.ForeColor = Color.White;
            deletebtnd.Location = new Point(136, 371);
            deletebtnd.Name = "deletebtnd";
            deletebtnd.Size = new Size(128, 53);
            deletebtnd.TabIndex = 51;
            deletebtnd.Text = "Delete";
            deletebtnd.UseVisualStyleBackColor = false;
            deletebtnd.Click += deletebtnd_Click;
            // 
            // selectedcourse
            // 
            selectedcourse.ForeColor = Color.SaddleBrown;
            selectedcourse.FormattingEnabled = true;
            selectedcourse.Location = new Point(869, 13);
            selectedcourse.Name = "selectedcourse";
            selectedcourse.Size = new Size(257, 28);
            selectedcourse.TabIndex = 50;
            selectedcourse.SelectedIndexChanged += selectedcourse_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(869, 136);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 49;
            label5.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(869, 63);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 48;
            label4.Text = "Name";
            // 
            // duration
            // 
            duration.Location = new Point(869, 174);
            duration.Name = "duration";
            duration.Size = new Size(251, 27);
            duration.TabIndex = 47;
            // 
            // courseGridView
            // 
            courseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseGridView.GridColor = Color.SaddleBrown;
            courseGridView.Location = new Point(13, 13);
            courseGridView.Name = "courseGridView";
            courseGridView.RowHeadersWidth = 51;
            courseGridView.Size = new Size(798, 340);
            courseGridView.TabIndex = 46;
            // 
            // name
            // 
            name.Location = new Point(869, 91);
            name.Name = "name";
            name.Size = new Size(251, 27);
            name.TabIndex = 45;
            // 
            // loadbtn
            // 
            loadbtn.BackColor = Color.SaddleBrown;
            loadbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.ForeColor = Color.White;
            loadbtn.Location = new Point(932, 371);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(128, 53);
            loadbtn.TabIndex = 44;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = false;
            loadbtn.Click += loadbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(869, 297);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 57;
            label2.Text = "instructor";
            // 
            // selectedinstructor
            // 
            selectedinstructor.ForeColor = Color.SaddleBrown;
            selectedinstructor.FormattingEnabled = true;
            selectedinstructor.Location = new Point(869, 325);
            selectedinstructor.Name = "selectedinstructor";
            selectedinstructor.Size = new Size(257, 28);
            selectedinstructor.TabIndex = 56;
            // 
            // CourseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label2);
            Controls.Add(selectedinstructor);
            Controls.Add(label1);
            Controls.Add(selecteddepartment);
            Controls.Add(insertbtnd);
            Controls.Add(updatebtnd);
            Controls.Add(deletebtnd);
            Controls.Add(selectedcourse);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(duration);
            Controls.Add(courseGridView);
            Controls.Add(name);
            Controls.Add(loadbtn);
            Name = "CourseControl";
            Size = new Size(1161, 511);
            ((System.ComponentModel.ISupportInitialize)courseGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox selecteddepartment;
        private Button insertbtnd;
        private Button updatebtnd;
        private Button deletebtnd;
        private ComboBox selectedcourse;
        private Label label5;
        private Label label4;
        private TextBox duration;
        private DataGridView courseGridView;
        private TextBox name;
        private Button loadbtn;
        private Label label2;
        private ComboBox selectedinstructor;
    }
}
