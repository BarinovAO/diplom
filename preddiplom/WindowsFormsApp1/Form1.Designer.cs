namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelectPage = new System.Windows.Forms.TabPage();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdiplomDataSet1 = new WindowsFormsApp1.bdiplomDataSet1();
            this.AddPage = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdiplomDataSet = new WindowsFormsApp1.bdiplomDataSet();
            this.discBoxAdd = new System.Windows.Forms.TextBox();
            this.discAdd = new System.Windows.Forms.Label();
            this.alertAdd = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.auditBoxAdd = new System.Windows.Forms.TextBox();
            this.lessonBoxAdd = new System.Windows.Forms.TextBox();
            this.nameBoxAdd = new System.Windows.Forms.TextBox();
            this.dateAdd = new System.Windows.Forms.Label();
            this.AuditAdd = new System.Windows.Forms.Label();
            this.lessonAdd = new System.Windows.Forms.Label();
            this.nameAdd = new System.Windows.Forms.Label();
            this.ChangePage = new System.Windows.Forms.TabPage();
            this.alertChange = new System.Windows.Forms.Label();
            this.discBoxChange = new System.Windows.Forms.TextBox();
            this.discChange = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.dateTimeChange = new System.Windows.Forms.DateTimePicker();
            this.auditBoxChange = new System.Windows.Forms.TextBox();
            this.lessonBoxChange = new System.Windows.Forms.TextBox();
            this.nameBoxChange = new System.Windows.Forms.TextBox();
            this.idBoxChange = new System.Windows.Forms.TextBox();
            this.dateChange = new System.Windows.Forms.Label();
            this.auditChange = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lessonChange = new System.Windows.Forms.Label();
            this.nameChange = new System.Windows.Forms.Label();
            this.idChange = new System.Windows.Forms.Label();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.alertDelete = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idBoxDelete = new System.Windows.Forms.TextBox();
            this.idDelete = new System.Windows.Forms.Label();
            this.lessonsTableAdapter = new WindowsFormsApp1.bdiplomDataSetTableAdapters.LessonsTableAdapter();
            this.lessonsTableAdapter1 = new WindowsFormsApp1.bdiplomDataSet1TableAdapters.LessonsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bdiplomDataSet1TableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager1 = new WindowsFormsApp1.bdiplomDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SelectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdiplomDataSet1)).BeginInit();
            this.AddPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdiplomDataSet)).BeginInit();
            this.ChangePage.SuspendLayout();
            this.deletePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.saveFileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RebootToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(136, 32);
            this.SettingsToolStripMenuItem.Text = "Инструкции";
            // 
            // RebootToolStripMenuItem
            // 
            this.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem";
            this.RebootToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.RebootToolStripMenuItem.Text = "Обновить";
            this.RebootToolStripMenuItem.Click += new System.EventHandler(this.RebootToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SelectPage);
            this.tabControl1.Controls.Add(this.AddPage);
            this.tabControl1.Controls.Add(this.ChangePage);
            this.tabControl1.Controls.Add(this.deletePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.MaximumSize = new System.Drawing.Size(863, 505);
            this.tabControl1.MinimumSize = new System.Drawing.Size(863, 505);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // SelectPage
            // 
            this.SelectPage.AutoScroll = true;
            this.SelectPage.Controls.Add(this.dGV);
            this.SelectPage.Location = new System.Drawing.Point(4, 28);
            this.SelectPage.Name = "SelectPage";
            this.SelectPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectPage.Size = new System.Drawing.Size(855, 473);
            this.SelectPage.TabIndex = 0;
            this.SelectPage.Text = "ВЫБРАТЬ";
            this.SelectPage.UseVisualStyleBackColor = true;
            // 
            // dGV
            // 
            this.dGV.AutoGenerateColumns = false;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.lessonDataGridViewTextBoxColumn,
            this.auditDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.discDataGridViewTextBoxColumn});
            this.dGV.DataSource = this.lessonsBindingSource;
            this.dGV.Location = new System.Drawing.Point(-2, 0);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(854, 473);
            this.dGV.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // lessonDataGridViewTextBoxColumn
            // 
            this.lessonDataGridViewTextBoxColumn.DataPropertyName = "Пара";
            this.lessonDataGridViewTextBoxColumn.HeaderText = "Пара";
            this.lessonDataGridViewTextBoxColumn.Name = "lessonDataGridViewTextBoxColumn";
            // 
            // auditDataGridViewTextBoxColumn
            // 
            this.auditDataGridViewTextBoxColumn.DataPropertyName = "Аудитория";
            this.auditDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.auditDataGridViewTextBoxColumn.Name = "auditDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 150;
            // 
            // discDataGridViewTextBoxColumn
            // 
            this.discDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.discDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.discDataGridViewTextBoxColumn.Name = "discDataGridViewTextBoxColumn";
            this.discDataGridViewTextBoxColumn.Width = 215;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.bdiplomDataSet1;
            // 
            // bdiplomDataSet1
            // 
            this.bdiplomDataSet1.DataSetName = "bdiplomDataSet1";
            this.bdiplomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddPage
            // 
            this.AddPage.AutoScroll = true;
            this.AddPage.BackColor = System.Drawing.Color.Bisque;
            this.AddPage.Controls.Add(this.discBoxAdd);
            this.AddPage.Controls.Add(this.discAdd);
            this.AddPage.Controls.Add(this.alertAdd);
            this.AddPage.Controls.Add(this.addButton);
            this.AddPage.Controls.Add(this.dateTimeAdd);
            this.AddPage.Controls.Add(this.auditBoxAdd);
            this.AddPage.Controls.Add(this.lessonBoxAdd);
            this.AddPage.Controls.Add(this.nameBoxAdd);
            this.AddPage.Controls.Add(this.dateAdd);
            this.AddPage.Controls.Add(this.AuditAdd);
            this.AddPage.Controls.Add(this.lessonAdd);
            this.AddPage.Controls.Add(this.nameAdd);
            this.AddPage.Location = new System.Drawing.Point(4, 28);
            this.AddPage.Name = "AddPage";
            this.AddPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddPage.Size = new System.Drawing.Size(855, 473);
            this.AddPage.TabIndex = 1;
            this.AddPage.Text = "ДОБАВИТЬ";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Lessons";
            this.bindingSource1.DataSource = this.bdiplomDataSet;
            // 
            // bdiplomDataSet
            // 
            this.bdiplomDataSet.DataSetName = "bdiplomDataSet";
            this.bdiplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discBoxAdd
            // 
            this.discBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Предмет", true));
            this.discBoxAdd.Location = new System.Drawing.Point(200, 200);
            this.discBoxAdd.Name = "discBoxAdd";
            this.discBoxAdd.Size = new System.Drawing.Size(200, 26);
            this.discBoxAdd.TabIndex = 15;
            // 
            // discAdd
            // 
            this.discAdd.AutoSize = true;
            this.discAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.discAdd.Location = new System.Drawing.Point(25, 200);
            this.discAdd.Name = "discAdd";
            this.discAdd.Size = new System.Drawing.Size(79, 21);
            this.discAdd.TabIndex = 14;
            this.discAdd.Text = "Предмет";
            // 
            // alertAdd
            // 
            this.alertAdd.AutoSize = true;
            this.alertAdd.Font = new System.Drawing.Font("Times New Roman", 21F);
            this.alertAdd.ForeColor = System.Drawing.Color.Red;
            this.alertAdd.Location = new System.Drawing.Point(20, 15);
            this.alertAdd.Name = "alertAdd";
            this.alertAdd.Size = new System.Drawing.Size(71, 33);
            this.alertAdd.TabIndex = 13;
            this.alertAdd.Text = "Alert";
            this.alertAdd.Visible = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MintCream;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.Tomato;
            this.addButton.Location = new System.Drawing.Point(50, 410);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 46);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // dateTimeAdd
            // 
            this.dateTimeAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Дата", true));
            this.dateTimeAdd.Location = new System.Drawing.Point(200, 350);
            this.dateTimeAdd.Name = "dateTimeAdd";
            this.dateTimeAdd.Size = new System.Drawing.Size(200, 26);
            this.dateTimeAdd.TabIndex = 7;
            // 
            // auditBoxAdd
            // 
            this.auditBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Аудитория", true));
            this.auditBoxAdd.Location = new System.Drawing.Point(200, 275);
            this.auditBoxAdd.Name = "auditBoxAdd";
            this.auditBoxAdd.Size = new System.Drawing.Size(200, 26);
            this.auditBoxAdd.TabIndex = 6;
            // 
            // lessonBoxAdd
            // 
            this.lessonBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Пара", true));
            this.lessonBoxAdd.Location = new System.Drawing.Point(200, 50);
            this.lessonBoxAdd.Name = "lessonBoxAdd";
            this.lessonBoxAdd.Size = new System.Drawing.Size(200, 26);
            this.lessonBoxAdd.TabIndex = 5;
            // 
            // nameBoxAdd
            // 
            this.nameBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "ФИО", true));
            this.nameBoxAdd.Location = new System.Drawing.Point(200, 125);
            this.nameBoxAdd.Name = "nameBoxAdd";
            this.nameBoxAdd.Size = new System.Drawing.Size(200, 26);
            this.nameBoxAdd.TabIndex = 4;
            // 
            // dateAdd
            // 
            this.dateAdd.AutoSize = true;
            this.dateAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAdd.Location = new System.Drawing.Point(25, 350);
            this.dateAdd.Name = "dateAdd";
            this.dateAdd.Size = new System.Drawing.Size(47, 21);
            this.dateAdd.TabIndex = 3;
            this.dateAdd.Text = "Дата";
            // 
            // AuditAdd
            // 
            this.AuditAdd.AutoSize = true;
            this.AuditAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditAdd.Location = new System.Drawing.Point(25, 275);
            this.AuditAdd.Name = "AuditAdd";
            this.AuditAdd.Size = new System.Drawing.Size(97, 21);
            this.AuditAdd.TabIndex = 2;
            this.AuditAdd.Text = "Аудитория";
            // 
            // lessonAdd
            // 
            this.lessonAdd.AutoSize = true;
            this.lessonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonAdd.Location = new System.Drawing.Point(25, 50);
            this.lessonAdd.Name = "lessonAdd";
            this.lessonAdd.Size = new System.Drawing.Size(49, 21);
            this.lessonAdd.TabIndex = 1;
            this.lessonAdd.Text = "Пара";
            // 
            // nameAdd
            // 
            this.nameAdd.AutoSize = true;
            this.nameAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAdd.Location = new System.Drawing.Point(25, 125);
            this.nameAdd.Name = "nameAdd";
            this.nameAdd.Size = new System.Drawing.Size(44, 21);
            this.nameAdd.TabIndex = 0;
            this.nameAdd.Text = "Имя";
            // 
            // ChangePage
            // 
            this.ChangePage.BackColor = System.Drawing.Color.Bisque;
            this.ChangePage.Controls.Add(this.alertChange);
            this.ChangePage.Controls.Add(this.discBoxChange);
            this.ChangePage.Controls.Add(this.discChange);
            this.ChangePage.Controls.Add(this.changeButton);
            this.ChangePage.Controls.Add(this.dateTimeChange);
            this.ChangePage.Controls.Add(this.auditBoxChange);
            this.ChangePage.Controls.Add(this.lessonBoxChange);
            this.ChangePage.Controls.Add(this.nameBoxChange);
            this.ChangePage.Controls.Add(this.idBoxChange);
            this.ChangePage.Controls.Add(this.dateChange);
            this.ChangePage.Controls.Add(this.auditChange);
            this.ChangePage.Controls.Add(this.label8);
            this.ChangePage.Controls.Add(this.lessonChange);
            this.ChangePage.Controls.Add(this.nameChange);
            this.ChangePage.Controls.Add(this.idChange);
            this.ChangePage.Location = new System.Drawing.Point(4, 28);
            this.ChangePage.Name = "ChangePage";
            this.ChangePage.Size = new System.Drawing.Size(855, 473);
            this.ChangePage.TabIndex = 2;
            this.ChangePage.Text = "ИЗМЕНИТЬ";
            // 
            // alertChange
            // 
            this.alertChange.AutoSize = true;
            this.alertChange.Font = new System.Drawing.Font("Times New Roman", 21F);
            this.alertChange.ForeColor = System.Drawing.Color.Red;
            this.alertChange.Location = new System.Drawing.Point(20, 15);
            this.alertChange.Name = "alertChange";
            this.alertChange.Size = new System.Drawing.Size(71, 33);
            this.alertChange.TabIndex = 18;
            this.alertChange.Text = "Alert";
            this.alertChange.Visible = false;
            // 
            // discBoxChange
            // 
            this.discBoxChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Предмет", true));
            this.discBoxChange.Location = new System.Drawing.Point(200, 200);
            this.discBoxChange.Name = "discBoxChange";
            this.discBoxChange.Size = new System.Drawing.Size(200, 26);
            this.discBoxChange.TabIndex = 17;
            // 
            // discChange
            // 
            this.discChange.AutoSize = true;
            this.discChange.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.discChange.Location = new System.Drawing.Point(25, 200);
            this.discChange.Name = "discChange";
            this.discChange.Size = new System.Drawing.Size(79, 21);
            this.discChange.TabIndex = 16;
            this.discChange.Text = "Предмет";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.MintCream;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.Tomato;
            this.changeButton.Location = new System.Drawing.Point(50, 410);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(159, 46);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // dateTimeChange
            // 
            this.dateTimeChange.Location = new System.Drawing.Point(200, 350);
            this.dateTimeChange.Name = "dateTimeChange";
            this.dateTimeChange.Size = new System.Drawing.Size(200, 26);
            this.dateTimeChange.TabIndex = 14;
            // 
            // auditBoxChange
            // 
            this.auditBoxChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Аудитория", true));
            this.auditBoxChange.Location = new System.Drawing.Point(200, 275);
            this.auditBoxChange.Name = "auditBoxChange";
            this.auditBoxChange.Size = new System.Drawing.Size(200, 26);
            this.auditBoxChange.TabIndex = 13;
            // 
            // lessonBoxChange
            // 
            this.lessonBoxChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Пара", true));
            this.lessonBoxChange.Location = new System.Drawing.Point(200, 50);
            this.lessonBoxChange.Name = "lessonBoxChange";
            this.lessonBoxChange.Size = new System.Drawing.Size(200, 26);
            this.lessonBoxChange.TabIndex = 12;
            // 
            // nameBoxChange
            // 
            this.nameBoxChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "ФИО", true));
            this.nameBoxChange.Location = new System.Drawing.Point(200, 125);
            this.nameBoxChange.Name = "nameBoxChange";
            this.nameBoxChange.Size = new System.Drawing.Size(200, 26);
            this.nameBoxChange.TabIndex = 11;
            // 
            // idBoxChange
            // 
            this.idBoxChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Id", true));
            this.idBoxChange.Location = new System.Drawing.Point(540, 50);
            this.idBoxChange.Name = "idBoxChange";
            this.idBoxChange.Size = new System.Drawing.Size(200, 26);
            this.idBoxChange.TabIndex = 10;
            // 
            // dateChange
            // 
            this.dateChange.AutoSize = true;
            this.dateChange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateChange.Location = new System.Drawing.Point(25, 350);
            this.dateChange.Name = "dateChange";
            this.dateChange.Size = new System.Drawing.Size(47, 21);
            this.dateChange.TabIndex = 6;
            this.dateChange.Text = "Дата";
            // 
            // auditChange
            // 
            this.auditChange.AutoSize = true;
            this.auditChange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auditChange.Location = new System.Drawing.Point(25, 275);
            this.auditChange.Name = "auditChange";
            this.auditChange.Size = new System.Drawing.Size(97, 21);
            this.auditChange.TabIndex = 5;
            this.auditChange.Text = "Аудитория";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            // 
            // lessonChange
            // 
            this.lessonChange.AutoSize = true;
            this.lessonChange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonChange.Location = new System.Drawing.Point(25, 50);
            this.lessonChange.Name = "lessonChange";
            this.lessonChange.Size = new System.Drawing.Size(49, 21);
            this.lessonChange.TabIndex = 3;
            this.lessonChange.Text = "Пара";
            // 
            // nameChange
            // 
            this.nameChange.AutoSize = true;
            this.nameChange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameChange.Location = new System.Drawing.Point(25, 125);
            this.nameChange.Name = "nameChange";
            this.nameChange.Size = new System.Drawing.Size(44, 21);
            this.nameChange.TabIndex = 2;
            this.nameChange.Text = "Имя";
            // 
            // idChange
            // 
            this.idChange.AutoSize = true;
            this.idChange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idChange.Location = new System.Drawing.Point(475, 50);
            this.idChange.Name = "idChange";
            this.idChange.Size = new System.Drawing.Size(29, 21);
            this.idChange.TabIndex = 1;
            this.idChange.Text = "ID";
            // 
            // deletePage
            // 
            this.deletePage.BackColor = System.Drawing.Color.Bisque;
            this.deletePage.Controls.Add(this.alertDelete);
            this.deletePage.Controls.Add(this.deleteButton);
            this.deletePage.Controls.Add(this.idBoxDelete);
            this.deletePage.Controls.Add(this.idDelete);
            this.deletePage.Location = new System.Drawing.Point(4, 28);
            this.deletePage.Name = "deletePage";
            this.deletePage.Size = new System.Drawing.Size(855, 473);
            this.deletePage.TabIndex = 3;
            this.deletePage.Text = "УДАЛИТЬ";
            // 
            // alertDelete
            // 
            this.alertDelete.AutoSize = true;
            this.alertDelete.Font = new System.Drawing.Font("Times New Roman", 21F);
            this.alertDelete.ForeColor = System.Drawing.Color.Red;
            this.alertDelete.Location = new System.Drawing.Point(23, 191);
            this.alertDelete.Name = "alertDelete";
            this.alertDelete.Size = new System.Drawing.Size(71, 33);
            this.alertDelete.TabIndex = 19;
            this.alertDelete.Text = "Alert";
            this.alertDelete.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MintCream;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Tomato;
            this.deleteButton.Location = new System.Drawing.Point(29, 118);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(159, 46);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idBoxDelete
            // 
            this.idBoxDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Id", true));
            this.idBoxDelete.Location = new System.Drawing.Point(80, 50);
            this.idBoxDelete.Name = "idBoxDelete";
            this.idBoxDelete.Size = new System.Drawing.Size(200, 26);
            this.idBoxDelete.TabIndex = 6;
            // 
            // idDelete
            // 
            this.idDelete.AutoSize = true;
            this.idDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDelete.Location = new System.Drawing.Point(25, 50);
            this.idDelete.Name = "idDelete";
            this.idDelete.Size = new System.Drawing.Size(29, 21);
            this.idDelete.TabIndex = 1;
            this.idDelete.Text = "ID";
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // lessonsTableAdapter1
            // 
            this.lessonsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LessonsTableAdapter = this.lessonsTableAdapter1;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bdiplomDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LessonsTableAdapter = this.lessonsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.bdiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(863, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(879, 575);
            this.MinimumSize = new System.Drawing.Size(879, 575);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.SelectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdiplomDataSet1)).EndInit();
            this.AddPage.ResumeLayout(false);
            this.AddPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdiplomDataSet)).EndInit();
            this.ChangePage.ResumeLayout(false);
            this.ChangePage.PerformLayout();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelectPage;
        private System.Windows.Forms.TabPage AddPage;
        private System.Windows.Forms.TabPage ChangePage;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label dateAdd;
        private System.Windows.Forms.Label AuditAdd;
        private System.Windows.Forms.Label lessonAdd;
        private System.Windows.Forms.Label nameAdd;
        private System.Windows.Forms.Label auditChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lessonChange;
        private System.Windows.Forms.Label nameChange;
        private System.Windows.Forms.Label idChange;
        private System.Windows.Forms.Label idDelete;
        private System.Windows.Forms.Label dateChange;
        private System.Windows.Forms.TextBox auditBoxChange;
        private System.Windows.Forms.TextBox lessonBoxChange;
        private System.Windows.Forms.TextBox nameBoxChange;
        private System.Windows.Forms.TextBox idBoxChange;
        private System.Windows.Forms.TextBox idBoxDelete;
        private System.Windows.Forms.DateTimePicker dateTimeAdd;
        private System.Windows.Forms.TextBox auditBoxAdd;
        private System.Windows.Forms.TextBox lessonBoxAdd;
        private System.Windows.Forms.TextBox nameBoxAdd;
        private System.Windows.Forms.DateTimePicker dateTimeChange;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label alertAdd;
        private bdiplomDataSet bdiplomDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdiplomDataSetTableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox discBoxAdd;
        private System.Windows.Forms.Label discAdd;
        private System.Windows.Forms.TextBox discBoxChange;
        private System.Windows.Forms.Label discChange;
        private System.Windows.Forms.Label alertChange;
        private System.Windows.Forms.Label alertDelete;
        private bdiplomDataSet1 bdiplomDataSet1;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private bdiplomDataSet1TableAdapters.LessonsTableAdapter lessonsTableAdapter1;
        private bdiplomDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDataGridViewTextBoxColumn;
        private bdiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

