namespace SOLID
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.DataGridView_GPA = new System.Windows.Forms.DataGridView();
            this.University = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_EditRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.OutputBy = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GPA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_GPA
            // 
            this.DataGridView_GPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_GPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_GPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.University,
            this.Faculty,
            this.StudentFullName,
            this.Subject,
            this.GPA});
            this.DataGridView_GPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_GPA.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_GPA.MultiSelect = false;
            this.DataGridView_GPA.Name = "DataGridView_GPA";
            this.DataGridView_GPA.ReadOnly = true;
            this.DataGridView_GPA.RowHeadersWidth = 51;
            this.DataGridView_GPA.RowTemplate.Height = 24;
            this.DataGridView_GPA.Size = new System.Drawing.Size(1119, 525);
            this.DataGridView_GPA.TabIndex = 0;
            // 
            // University
            // 
            this.University.HeaderText = "Вуз";
            this.University.MinimumWidth = 6;
            this.University.Name = "University";
            this.University.ReadOnly = true;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // StudentFullName
            // 
            this.StudentFullName.HeaderText = "ФИО студента";
            this.StudentFullName.MinimumWidth = 6;
            this.StudentFullName.Name = "StudentFullName";
            this.StudentFullName.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // GPA
            // 
            this.GPA.HeaderText = "Средняя оценка";
            this.GPA.MinimumWidth = 6;
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(122, 3);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(110, 30);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "Следующая";
            this.button_Next.UseVisualStyleBackColor = true;
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(0, 4);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(110, 30);
            this.button_Previous.TabIndex = 3;
            this.button_Previous.Text = "Предыдущая";
            this.button_Previous.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.DataGridView_GPA);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 525);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button_Previous);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Location = new System.Drawing.Point(899, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 37);
            this.panel2.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddRecord,
            this.toolStripButton_EditRecord,
            this.toolStripButton_DeleteRecord,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.OutputBy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1143, 28);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_AddRecord
            // 
            this.toolStripButton_AddRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AddRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddRecord.Image")));
            this.toolStripButton_AddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddRecord.Name = "toolStripButton_AddRecord";
            this.toolStripButton_AddRecord.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_AddRecord.Text = "Добавить запись";
            // 
            // toolStripButton_EditRecord
            // 
            this.toolStripButton_EditRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_EditRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_EditRecord.Image")));
            this.toolStripButton_EditRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_EditRecord.Name = "toolStripButton_EditRecord";
            this.toolStripButton_EditRecord.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_EditRecord.Text = "Редактировать запись";
            // 
            // toolStripButton_DeleteRecord
            // 
            this.toolStripButton_DeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DeleteRecord.Image")));
            this.toolStripButton_DeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeleteRecord.Name = "toolStripButton_DeleteRecord";
            this.toolStripButton_DeleteRecord.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_DeleteRecord.Text = "Удалить запись";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 25);
            this.toolStripLabel1.Text = "Выводить по:";
            // 
            // OutputBy
            // 
            this.OutputBy.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "30"});
            this.OutputBy.AutoSize = false;
            this.OutputBy.Name = "OutputBy";
            this.OutputBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputBy.Size = new System.Drawing.Size(50, 28);
            this.OutputBy.SelectedIndexChanged += new System.EventHandler(this.OutputBy_SelectedIndexChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 630);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Вузы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GPA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn University;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_DeleteRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_EditRecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox OutputBy;
    }
}

