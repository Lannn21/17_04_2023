namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.teamDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.DGV2Data = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV4Data = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.DGV3Data = new System.Windows.Forms.DataGridView();
            this.cmbMatch = new System.Windows.Forms.ComboBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV4Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3Data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDataToolStripMenuItem,
            this.findMatchToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // teamDataToolStripMenuItem
            // 
            this.teamDataToolStripMenuItem.Name = "teamDataToolStripMenuItem";
            this.teamDataToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.teamDataToolStripMenuItem.Text = "Team data";
            this.teamDataToolStripMenuItem.Click += new System.EventHandler(this.teamDataToolStripMenuItem_Click);
            // 
            // findMatchToolStripMenuItem
            // 
            this.findMatchToolStripMenuItem.Name = "findMatchToolStripMenuItem";
            this.findMatchToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.findMatchToolStripMenuItem.Text = "Find match";
            this.findMatchToolStripMenuItem.Click += new System.EventHandler(this.findMatchToolStripMenuItem_Click);
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(12, 15);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(121, 21);
            this.cmbTeam.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVData
            // 
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Location = new System.Drawing.Point(13, 44);
            this.DGVData.Name = "DGVData";
            this.DGVData.Size = new System.Drawing.Size(415, 127);
            this.DGVData.TabIndex = 4;
            // 
            // DGV2Data
            // 
            this.DGV2Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2Data.Location = new System.Drawing.Point(13, 224);
            this.DGV2Data.Name = "DGV2Data";
            this.DGV2Data.Size = new System.Drawing.Size(415, 153);
            this.DGV2Data.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV2Data);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DGVData);
            this.panel1.Controls.Add(this.cmbTeam);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 404);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV4Data);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.DGV3Data);
            this.panel2.Controls.Add(this.cmbMatch);
            this.panel2.Location = new System.Drawing.Point(442, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 412);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // DGV4Data
            // 
            this.DGV4Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV4Data.Location = new System.Drawing.Point(13, 224);
            this.DGV4Data.Name = "DGV4Data";
            this.DGV4Data.Size = new System.Drawing.Size(415, 153);
            this.DGV4Data.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGV3Data
            // 
            this.DGV3Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV3Data.Location = new System.Drawing.Point(13, 44);
            this.DGV3Data.Name = "DGV3Data";
            this.DGV3Data.Size = new System.Drawing.Size(415, 150);
            this.DGV3Data.TabIndex = 4;
            // 
            // cmbMatch
            // 
            this.cmbMatch.FormattingEnabled = true;
            this.cmbMatch.Location = new System.Drawing.Point(12, 15);
            this.cmbMatch.Name = "cmbMatch";
            this.cmbMatch.Size = new System.Drawing.Size(121, 21);
            this.cmbMatch.TabIndex = 2;
            this.cmbMatch.SelectedIndexChanged += new System.EventHandler(this.cmbMatch_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV4Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem teamDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.DataGridView DGV2Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV4Data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGV3Data;
        private System.Windows.Forms.ComboBox cmbMatch;
    }
}

