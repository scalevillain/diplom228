namespace diplom228
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label ur_dostupaLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.urovni_dostupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new diplom228.testerDataSet();
            this.urovni_dostupaTableAdapter = new diplom228.testerDataSetTableAdapters.urovni_dostupaTableAdapter();
            this.tableAdapterManager = new diplom228.testerDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new diplom228.testerDataSetTableAdapters.usersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new diplom228.testerDataSetTableAdapters.testTableAdapter();
            usernameLabel = new System.Windows.Forms.Label();
            ur_dostupaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urovni_dostupaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(99, 58);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(38, 13);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Логин\r\n";
            // 
            // ur_dostupaLabel
            // 
            ur_dostupaLabel.AutoSize = true;
            ur_dostupaLabel.Location = new System.Drawing.Point(43, 110);
            ur_dostupaLabel.Name = "ur_dostupaLabel";
            ur_dostupaLabel.Size = new System.Drawing.Size(94, 13);
            ur_dostupaLabel.TabIndex = 10;
            ur_dostupaLabel.Text = "Уровень доступа\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // urovni_dostupaBindingSource
            // 
            this.urovni_dostupaBindingSource.DataMember = "urovni_dostupa";
            this.urovni_dostupaBindingSource.DataSource = this.testerDataSet;
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urovni_dostupaTableAdapter
            // 
            this.urovni_dostupaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.platformiTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.projectsTableAdapter = null;
            this.tableAdapterManager.resultsTableAdapter = null;
            this.tableAdapterManager.test_planTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = diplom228.testerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urovni_dostupaTableAdapter = this.urovni_dostupaTableAdapter;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.testerDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "id_user";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.testBindingSource;
            this.comboBox2.DisplayMember = "uroven_dostupa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "uroven_dostupa";
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.testerDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 232);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(ur_dostupaLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.urovni_dostupaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource urovni_dostupaBindingSource;
        private testerDataSetTableAdapters.urovni_dostupaTableAdapter urovni_dostupaTableAdapter;
        private testerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private testerDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.BindingSource testBindingSource;
        private testerDataSetTableAdapters.testTableAdapter testTableAdapter;
    }
}

