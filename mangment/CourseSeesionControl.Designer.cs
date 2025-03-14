namespace mangment
{
    partial class CourseSeesionControl
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
            label2 = new Label();
            selectedinstructor = new ComboBox();
            label1 = new Label();
            selectedcourse = new ComboBox();
            insertbtnd = new Button();
            updatebtnd = new Button();
            deletebtnd = new Button();
            selectedcoursesession = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            date = new TextBox();
            coursesessionGridView = new DataGridView();
            title = new TextBox();
            loadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)coursesessionGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(894, 315);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 99;
            label2.Text = "instructor";
            // 
            // selectedinstructor
            // 
            selectedinstructor.ForeColor = Color.SaddleBrown;
            selectedinstructor.FormattingEnabled = true;
            selectedinstructor.Location = new Point(894, 343);
            selectedinstructor.Name = "selectedinstructor";
            selectedinstructor.Size = new Size(257, 28);
            selectedinstructor.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(894, 235);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 97;
            label1.Text = "Course";
            // 
            // selectedcourse
            // 
            selectedcourse.ForeColor = Color.SaddleBrown;
            selectedcourse.FormattingEnabled = true;
            selectedcourse.Location = new Point(894, 275);
            selectedcourse.Name = "selectedcourse";
            selectedcourse.Size = new Size(257, 28);
            selectedcourse.TabIndex = 96;
            // 
            // insertbtnd
            // 
            insertbtnd.BackColor = Color.SaddleBrown;
            insertbtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtnd.ForeColor = Color.White;
            insertbtnd.Location = new Point(708, 389);
            insertbtnd.Name = "insertbtnd";
            insertbtnd.Size = new Size(128, 53);
            insertbtnd.TabIndex = 95;
            insertbtnd.Text = "Insert";
            insertbtnd.UseVisualStyleBackColor = false;
            insertbtnd.Click += insertbtnd_Click;
            // 
            // updatebtnd
            // 
            updatebtnd.BackColor = Color.SaddleBrown;
            updatebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtnd.ForeColor = Color.White;
            updatebtnd.Location = new Point(431, 389);
            updatebtnd.Name = "updatebtnd";
            updatebtnd.Size = new Size(128, 53);
            updatebtnd.TabIndex = 94;
            updatebtnd.Text = "Update";
            updatebtnd.UseVisualStyleBackColor = false;
            updatebtnd.Click += updatebtnd_Click;
            // 
            // deletebtnd
            // 
            deletebtnd.BackColor = Color.SaddleBrown;
            deletebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtnd.ForeColor = Color.White;
            deletebtnd.Location = new Point(161, 389);
            deletebtnd.Name = "deletebtnd";
            deletebtnd.Size = new Size(128, 53);
            deletebtnd.TabIndex = 93;
            deletebtnd.Text = "Delete";
            deletebtnd.UseVisualStyleBackColor = false;
            deletebtnd.Click += deletebtnd_Click;
            // 
            // selectedcoursesession
            // 
            selectedcoursesession.ForeColor = Color.SaddleBrown;
            selectedcoursesession.FormattingEnabled = true;
            selectedcoursesession.Location = new Point(894, 31);
            selectedcoursesession.Name = "selectedcoursesession";
            selectedcoursesession.Size = new Size(257, 28);
            selectedcoursesession.TabIndex = 92;
            selectedcoursesession.SelectedIndexChanged += selectedcoursesession_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(894, 154);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 91;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(894, 81);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 90;
            label4.Text = "Title";
            // 
            // date
            // 
            date.Location = new Point(894, 192);
            date.Name = "date";
            date.Size = new Size(251, 27);
            date.TabIndex = 89;
            // 
            // coursesessionGridView
            // 
            coursesessionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesessionGridView.GridColor = Color.SaddleBrown;
            coursesessionGridView.Location = new Point(38, 31);
            coursesessionGridView.Name = "coursesessionGridView";
            coursesessionGridView.RowHeadersWidth = 51;
            coursesessionGridView.Size = new Size(798, 340);
            coursesessionGridView.TabIndex = 88;
            // 
            // title
            // 
            title.Location = new Point(894, 109);
            title.Name = "title";
            title.Size = new Size(251, 27);
            title.TabIndex = 87;
            // 
            // loadbtn
            // 
            loadbtn.BackColor = Color.SaddleBrown;
            loadbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.ForeColor = Color.White;
            loadbtn.Location = new Point(957, 389);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(128, 53);
            loadbtn.TabIndex = 86;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = false;
            loadbtn.Click += loadbtn_Click;
            // 
            // CourseSeesionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label2);
            Controls.Add(selectedinstructor);
            Controls.Add(label1);
            Controls.Add(selectedcourse);
            Controls.Add(insertbtnd);
            Controls.Add(updatebtnd);
            Controls.Add(deletebtnd);
            Controls.Add(selectedcoursesession);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(coursesessionGridView);
            Controls.Add(title);
            Controls.Add(loadbtn);
            Name = "CourseSeesionControl";
            Size = new Size(1188, 473);
            Load += CourseSeesionControl_Load;
            ((System.ComponentModel.ISupportInitialize)coursesessionGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox selectedinstructor;
        private Label label1;
        private ComboBox selectedcourse;
        private Button insertbtnd;
        private Button updatebtnd;
        private Button deletebtnd;
        private ComboBox selectedcoursesession;
        private Label label5;
        private Label label4;
        private TextBox date;
        private DataGridView coursesessionGridView;
        private TextBox title;
        private Button loadbtn;
    }
}
