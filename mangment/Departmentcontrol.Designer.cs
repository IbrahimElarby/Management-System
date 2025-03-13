namespace mangment
{
    partial class Departmentcontrol
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
            selectedmanger = new ComboBox();
            insertbtnd = new Button();
            updatebtnd = new Button();
            deletebtnd = new Button();
            selecteddepartment = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            Location = new TextBox();
            departmentGridView = new DataGridView();
            name = new TextBox();
            loadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)departmentGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(910, 232);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 43;
            label1.Text = "Manager";
            // 
            // selectedmanger
            // 
            selectedmanger.ForeColor = Color.SaddleBrown;
            selectedmanger.FormattingEnabled = true;
            selectedmanger.Location = new Point(910, 272);
            selectedmanger.Name = "selectedmanger";
            selectedmanger.Size = new Size(257, 28);
            selectedmanger.TabIndex = 42;
            // 
            // insertbtnd
            // 
            insertbtnd.BackColor = Color.SaddleBrown;
            insertbtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtnd.ForeColor = Color.White;
            insertbtnd.Location = new Point(724, 374);
            insertbtnd.Name = "insertbtnd";
            insertbtnd.Size = new Size(128, 53);
            insertbtnd.TabIndex = 41;
            insertbtnd.Text = "Insert";
            insertbtnd.UseVisualStyleBackColor = false;
            insertbtnd.Click += insertbtnd_Click;
            // 
            // updatebtnd
            // 
            updatebtnd.BackColor = Color.SaddleBrown;
            updatebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtnd.ForeColor = Color.White;
            updatebtnd.Location = new Point(447, 374);
            updatebtnd.Name = "updatebtnd";
            updatebtnd.Size = new Size(128, 53);
            updatebtnd.TabIndex = 40;
            updatebtnd.Text = "Update";
            updatebtnd.UseVisualStyleBackColor = false;
            updatebtnd.Click += updatebtnd_Click;
            // 
            // deletebtnd
            // 
            deletebtnd.BackColor = Color.SaddleBrown;
            deletebtnd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtnd.ForeColor = Color.White;
            deletebtnd.Location = new Point(177, 374);
            deletebtnd.Name = "deletebtnd";
            deletebtnd.Size = new Size(128, 53);
            deletebtnd.TabIndex = 39;
            deletebtnd.Text = "Delete";
            deletebtnd.UseVisualStyleBackColor = false;
            deletebtnd.Click += deletebtnd_Click;
            // 
            // selecteddepartment
            // 
            selecteddepartment.ForeColor = Color.SaddleBrown;
            selecteddepartment.FormattingEnabled = true;
            selecteddepartment.Location = new Point(910, 16);
            selecteddepartment.Name = "selecteddepartment";
            selecteddepartment.Size = new Size(257, 28);
            selecteddepartment.TabIndex = 38;
            selecteddepartment.SelectedIndexChanged += selecteddepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(910, 139);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 37;
            label5.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(910, 66);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 36;
            label4.Text = "Name";
            // 
            // Location
            // 
            Location.Location = new Point(910, 177);
            Location.Name = "Location";
            Location.Size = new Size(251, 27);
            Location.TabIndex = 33;
            // 
            // departmentGridView
            // 
            departmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentGridView.GridColor = Color.SaddleBrown;
            departmentGridView.Location = new Point(57, 16);
            departmentGridView.Name = "departmentGridView";
            departmentGridView.RowHeadersWidth = 51;
            departmentGridView.Size = new Size(798, 318);
            departmentGridView.TabIndex = 32;
            // 
            // name
            // 
            name.Location = new Point(910, 94);
            name.Name = "name";
            name.Size = new Size(251, 27);
            name.TabIndex = 31;
            // 
            // loadbtn
            // 
            loadbtn.BackColor = Color.SaddleBrown;
            loadbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.ForeColor = Color.White;
            loadbtn.Location = new Point(973, 374);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(128, 53);
            loadbtn.TabIndex = 30;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = false;
            loadbtn.Click += loadbtn_Click;
            // 
            // Departmentcontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label1);
            Controls.Add(selectedmanger);
            Controls.Add(insertbtnd);
            Controls.Add(updatebtnd);
            Controls.Add(deletebtnd);
            Controls.Add(selecteddepartment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Location);
            Controls.Add(departmentGridView);
            Controls.Add(name);
            Controls.Add(loadbtn);
            Name = "Departmentcontrol";
            Size = new Size(1225, 512);
            ((System.ComponentModel.ISupportInitialize)departmentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox selectedmanger;
        private Button insertbtnd;
        private Button updatebtnd;
        private Button deletebtnd;
        private ComboBox selecteddepartment;
        private Label label5;
        private Label label4;
        private TextBox Location;
        private DataGridView departmentGridView;
        private TextBox name;
        private Button loadbtn;
    }
}
