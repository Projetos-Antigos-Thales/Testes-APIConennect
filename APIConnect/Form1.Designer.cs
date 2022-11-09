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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mStripOpcoes.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 522);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(12, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 522);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(12, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 522);
            this.panel3.TabIndex = 5;
            // 
            // APIConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mStripOpcoes);
            this.MainMenuStrip = this.mStripOpcoes;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "APIConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APIConnect";
            this.Load += new System.EventHandler(this.APIConnect_Load);
            this.mStripOpcoes.ResumeLayout(false);
            this.mStripOpcoes.PerformLayout();
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
    }
}