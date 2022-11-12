namespace APIConnect
{
    partial class APIConnect
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
            this.mStripOpcoes = new System.Windows.Forms.MenuStrip();
            this.nET60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nET31ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nET22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnSearchFile1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchFile2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStripOpcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mStripOpcoes
            // 
            this.mStripOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nET60ToolStripMenuItem,
            this.nET31ToolStripMenuItem,
            this.nET22ToolStripMenuItem});
            this.mStripOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mStripOpcoes.Name = "mStripOpcoes";
            this.mStripOpcoes.Size = new System.Drawing.Size(784, 24);
            this.mStripOpcoes.TabIndex = 2;
            this.mStripOpcoes.Text = "Opções";
            // 
            // nET60ToolStripMenuItem
            // 
            this.nET60ToolStripMenuItem.Name = "nET60ToolStripMenuItem";
            this.nET60ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.nET60ToolStripMenuItem.Text = ".NET 6.0";
            this.nET60ToolStripMenuItem.Click += new System.EventHandler(this.nET60ToolStripMenuItem_Click);
            // 
            // nET31ToolStripMenuItem
            // 
            this.nET31ToolStripMenuItem.Name = "nET31ToolStripMenuItem";
            this.nET31ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.nET31ToolStripMenuItem.Text = ".NET 3.1";
            this.nET31ToolStripMenuItem.Click += new System.EventHandler(this.nET31ToolStripMenuItem_Click);
            // 
            // nET22ToolStripMenuItem
            // 
            this.nET22ToolStripMenuItem.Name = "nET22ToolStripMenuItem";
            this.nET22ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.nET22ToolStripMenuItem.Text = ".NET 2.2";
            this.nET22ToolStripMenuItem.Click += new System.EventHandler(this.nET22ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCreateClass);
            this.panel1.Controls.Add(this.btnSearchFile1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSearchFile2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 522);
            this.panel1.TabIndex = 3;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(470, 132);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PlaceholderText = "Nome da Nova Classe";
            this.txtClassName.Size = new System.Drawing.Size(278, 23);
            this.txtClassName.TabIndex = 6;
            this.txtClassName.Text = "NovaClasse";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(470, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 41);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar Grid";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(615, 161);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(133, 41);
            this.btnCreateClass.TabIndex = 4;
            this.btnCreateClass.Text = "Gerar Classe da API";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // btnSearchFile1
            // 
            this.btnSearchFile1.Location = new System.Drawing.Point(615, 9);
            this.btnSearchFile1.Name = "btnSearchFile1";
            this.btnSearchFile1.Size = new System.Drawing.Size(133, 41);
            this.btnSearchFile1.TabIndex = 3;
            this.btnSearchFile1.Text = "Buscar Postman Collection v2";
            this.btnSearchFile1.UseVisualStyleBackColor = true;
            this.btnSearchFile1.Click += new System.EventHandler(this.btnSearchFile1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request,
            this.Method,
            this.URL,
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4,
            this.Header5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(736, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSearchFile2
            // 
            this.btnSearchFile2.Location = new System.Drawing.Point(615, 59);
            this.btnSearchFile2.Name = "btnSearchFile2";
            this.btnSearchFile2.Size = new System.Drawing.Size(133, 41);
            this.btnSearchFile2.TabIndex = 0;
            this.btnSearchFile2.Text = "Buscar Postman Collection v2.1";
            this.btnSearchFile2.UseVisualStyleBackColor = true;
            this.btnSearchFile2.Click += new System.EventHandler(this.btnSearchFile2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(772, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 522);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(772, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 522);
            this.panel3.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Request
            // 
            this.Request.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            this.Request.Width = 74;
            // 
            // Method
            // 
            this.Method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Method.HeaderText = "Método";
            this.Method.Name = "Method";
            this.Method.Width = 74;
            // 
            // URL
            // 
            this.URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Width = 53;
            // 
            // Header1
            // 
            this.Header1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Header1.HeaderText = "Header 1";
            this.Header1.Name = "Header1";
            this.Header1.Width = 79;
            // 
            // Header2
            // 
            this.Header2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Header2.HeaderText = "Header 2";
            this.Header2.Name = "Header2";
            this.Header2.Width = 79;
            // 
            // Header3
            // 
            this.Header3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Header3.HeaderText = "Header 3";
            this.Header3.Name = "Header3";
            this.Header3.Width = 79;
            // 
            // Header4
            // 
            this.Header4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Header4.HeaderText = "Header 4";
            this.Header4.Name = "Header4";
            this.Header4.Width = 79;
            // 
            // Header5
            // 
            this.Header5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Header5.HeaderText = "Header 5";
            this.Header5.Name = "Header5";
            this.Header5.Width = 79;
            // 
            // APIConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mStripOpcoes);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.mStripOpcoes;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "APIConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APIConnect";
            this.Load += new System.EventHandler(this.APIConnect_Load);
            this.mStripOpcoes.ResumeLayout(false);
            this.mStripOpcoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip mStripOpcoes;
        private ToolStripMenuItem nET60ToolStripMenuItem;
        private ToolStripMenuItem nET31ToolStripMenuItem;
        private ToolStripMenuItem nET22ToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSearchFile1;
        private Button btnSearchFile2;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Button btnClear;
        private Button btnCreateClass;
        private TextBox txtClassName;
        private DataGridViewTextBoxColumn Request;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn URL;
        private DataGridViewTextBoxColumn Header1;
        private DataGridViewTextBoxColumn Header2;
        private DataGridViewTextBoxColumn Header3;
        private DataGridViewTextBoxColumn Header4;
        private DataGridViewTextBoxColumn Header5;
    }
}