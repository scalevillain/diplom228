namespace diplom228
{
    partial class Form2
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
            System.Windows.Forms.Label nazvanieLabel;
            System.Windows.Forms.Label proizvoditelLabel;
            System.Windows.Forms.Label statLabel;
            System.Windows.Forms.Label platformaLabel;
            System.Windows.Forms.Label nazvLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label id_projectLabel;
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.testerDataSet = new diplom228.testerDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new diplom228.testerDataSetTableAdapters.projectsTableAdapter();
            this.tableAdapterManager = new diplom228.testerDataSetTableAdapters.TableAdapterManager();
            this.platformiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.productsTableAdapter = new diplom228.testerDataSetTableAdapters.productsTableAdapter();
            this.platformiTableAdapter = new diplom228.testerDataSetTableAdapters.platformiTableAdapter();
            this.id_prodTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieTextBox = new System.Windows.Forms.TextBox();
            this.proizvoditelTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statTextBox = new System.Windows.Forms.TextBox();
            this.nazvTextBox = new System.Windows.Forms.TextBox();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_projectTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровниДоступаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПлатформToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nazvanieLabel = new System.Windows.Forms.Label();
            proizvoditelLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            platformaLabel = new System.Windows.Forms.Label();
            nazvLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            id_projectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazvanieLabel
            // 
            nazvanieLabel.AutoSize = true;
            nazvanieLabel.Location = new System.Drawing.Point(424, 14);
            nazvanieLabel.Name = "nazvanieLabel";
            nazvanieLabel.Size = new System.Drawing.Size(57, 13);
            nazvanieLabel.TabIndex = 2;
            nazvanieLabel.Text = "Название";
            // 
            // proizvoditelLabel
            // 
            proizvoditelLabel.AutoSize = true;
            proizvoditelLabel.Location = new System.Drawing.Point(424, 40);
            proizvoditelLabel.Name = "proizvoditelLabel";
            proizvoditelLabel.Size = new System.Drawing.Size(86, 13);
            proizvoditelLabel.TabIndex = 4;
            proizvoditelLabel.Text = "Производитель";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(12, 132);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Добавить/Удалить проект\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.testerDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.platformiTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.projectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.resultsTableAdapter = null;
            this.tableAdapterManager.test_planTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = diplom228.testerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urovni_dostupaTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // platformiBindingSource
            // 
            this.platformiBindingSource.DataMember = "platformi";
            this.platformiBindingSource.DataSource = this.testerDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.testerDataSet;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 156);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(134, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Изменить права доступа";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(12, 180);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(101, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Создать тест-план";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // platformiTableAdapter
            // 
            this.platformiTableAdapter.ClearBeforeFill = true;
            // 
            // id_prodTextBox
            // 
            this.id_prodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "id_prod", true));
            this.id_prodTextBox.Location = new System.Drawing.Point(516, 161);
            this.id_prodTextBox.Name = "id_prodTextBox";
            this.id_prodTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_prodTextBox.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(13, 11);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(405, 225);
            this.productsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_prod";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_prod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nazvanie";
            this.dataGridViewTextBoxColumn7.HeaderText = "Название";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "proizvoditel";
            this.dataGridViewTextBoxColumn8.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // nazvanieTextBox
            // 
            this.nazvanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "nazvanie", true));
            this.nazvanieTextBox.Location = new System.Drawing.Point(516, 11);
            this.nazvanieTextBox.Name = "nazvanieTextBox";
            this.nazvanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazvanieTextBox.TabIndex = 3;
            // 
            // proizvoditelTextBox
            // 
            this.proizvoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "proizvoditel", true));
            this.proizvoditelTextBox.Location = new System.Drawing.Point(516, 37);
            this.proizvoditelTextBox.Name = "proizvoditelTextBox";
            this.proizvoditelTextBox.Size = new System.Drawing.Size(100, 20);
            this.proizvoditelTextBox.TabIndex = 5;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(12, 106);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(148, 13);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Добавить/Удалить продукт";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Текущий пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.id_prodTextBox);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(nazvanieLabel);
            this.panel2.Controls.Add(this.productsDataGridView);
            this.panel2.Controls.Add(this.nazvanieTextBox);
            this.panel2.Controls.Add(proizvoditelLabel);
            this.panel2.Controls.Add(this.proizvoditelTextBox);
            this.panel2.Location = new System.Drawing.Point(175, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 282);
            this.panel2.TabIndex = 16;
            // 
            // statTextBox
            // 
            this.statTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "stat", true));
            this.statTextBox.Location = new System.Drawing.Point(528, 66);
            this.statTextBox.Name = "statTextBox";
            this.statTextBox.Size = new System.Drawing.Size(100, 20);
            this.statTextBox.TabIndex = 9;
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Location = new System.Drawing.Point(469, 69);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(27, 13);
            statLabel.TabIndex = 8;
            statLabel.Text = "stat:";
            // 
            // platformaLabel
            // 
            platformaLabel.AutoSize = true;
            platformaLabel.Location = new System.Drawing.Point(469, 95);
            platformaLabel.Name = "platformaLabel";
            platformaLabel.Size = new System.Drawing.Size(53, 13);
            platformaLabel.TabIndex = 10;
            platformaLabel.Text = "platforma:";
            // 
            // nazvTextBox
            // 
            this.nazvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "nazv", true));
            this.nazvTextBox.Location = new System.Drawing.Point(528, 40);
            this.nazvTextBox.Name = "nazvTextBox";
            this.nazvTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazvTextBox.TabIndex = 7;
            // 
            // nazvLabel
            // 
            nazvLabel.AutoSize = true;
            nazvLabel.Location = new System.Drawing.Point(469, 43);
            nazvLabel.Name = "nazvLabel";
            nazvLabel.Size = new System.Drawing.Size(33, 13);
            nazvLabel.TabIndex = 6;
            nazvLabel.Text = "nazv:";
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AutoGenerateColumns = false;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.Column2});
            this.projectsDataGridView.DataSource = this.projectsBindingSource;
            this.projectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.Size = new System.Drawing.Size(444, 219);
            this.projectsDataGridView.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product";
            this.Column2.DataSource = this.productsBindingSource;
            this.Column2.DisplayMember = "nazvanie";
            this.Column2.HeaderText = "Продукт";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ValueMember = "id_prod";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "platforma";
            this.Column1.DataSource = this.platformiBindingSource;
            this.Column1.DisplayMember = "nazvanie";
            this.Column1.HeaderText = "Платформа";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "id_platform";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product";
            this.dataGridViewTextBoxColumn5.HeaderText = "product";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "platforma";
            this.dataGridViewTextBoxColumn4.HeaderText = "platforma";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_project";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_project";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(469, 121);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(46, 13);
            productLabel.TabIndex = 12;
            productLabel.Text = "product:";
            // 
            // id_projectTextBox
            // 
            this.id_projectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "id_project", true));
            this.id_projectTextBox.Location = new System.Drawing.Point(528, 14);
            this.id_projectTextBox.Name = "id_projectTextBox";
            this.id_projectTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_projectTextBox.TabIndex = 5;
            // 
            // id_projectLabel
            // 
            id_projectLabel.AutoSize = true;
            id_projectLabel.Location = new System.Drawing.Point(469, 17);
            id_projectLabel.Name = "id_projectLabel";
            id_projectLabel.Size = new System.Drawing.Size(53, 13);
            id_projectLabel.TabIndex = 4;
            id_projectLabel.Text = "id project:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.platformiBindingSource;
            this.comboBox1.DisplayMember = "nazvanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(528, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id_platform";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productsBindingSource;
            this.comboBox2.DisplayMember = "nazvanie";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(528, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "id_prod";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(id_projectLabel);
            this.panel1.Controls.Add(this.id_projectTextBox);
            this.panel1.Controls.Add(productLabel);
            this.panel1.Controls.Add(this.projectsDataGridView);
            this.panel1.Controls.Add(nazvLabel);
            this.panel1.Controls.Add(this.nazvTextBox);
            this.panel1.Controls.Add(platformaLabel);
            this.panel1.Controls.Add(statLabel);
            this.panel1.Controls.Add(this.statTextBox);
            this.panel1.Location = new System.Drawing.Point(175, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 225);
            this.panel1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПользователейToolStripMenuItem,
            this.уровниДоступаToolStripMenuItem,
            this.списокПлатформToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            // 
            // уровниДоступаToolStripMenuItem
            // 
            this.уровниДоступаToolStripMenuItem.Name = "уровниДоступаToolStripMenuItem";
            this.уровниДоступаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.уровниДоступаToolStripMenuItem.Text = "Уровни доступа";
            // 
            // списокПлатформToolStripMenuItem
            // 
            this.списокПлатформToolStripMenuItem.Name = "списокПлатформToolStripMenuItem";
            this.списокПлатформToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.списокПлатформToolStripMenuItem.Text = "Список платформ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private testerDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private testerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private testerDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource platformiBindingSource;
        private testerDataSetTableAdapters.platformiTableAdapter platformiTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.TextBox proizvoditelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_prodTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox statTextBox;
        private System.Windows.Forms.TextBox nazvTextBox;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.TextBox id_projectTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровниДоступаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПлатформToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
    }
}