namespace WindowsFormsApp2
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
            this.dgvteam = new System.Windows.Forms.DataGridView();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Buttonenter = new System.Windows.Forms.Button();
            this.dgvmanager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvteam
            // 
            this.dgvteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteam.Location = new System.Drawing.Point(12, 56);
            this.dgvteam.Name = "dgvteam";
            this.dgvteam.Size = new System.Drawing.Size(775, 166);
            this.dgvteam.TabIndex = 0;
            this.dgvteam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplayer_CellContentClick);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(12, 27);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam.TabIndex = 1;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxnationality_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDataToolStripMenuItem,
            this.findMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamDataToolStripMenuItem
            // 
            this.teamDataToolStripMenuItem.Name = "teamDataToolStripMenuItem";
            this.teamDataToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.teamDataToolStripMenuItem.Text = "Team Data";
            this.teamDataToolStripMenuItem.Click += new System.EventHandler(this.teamDataToolStripMenuItem_Click);
            // 
            // findMatchToolStripMenuItem
            // 
            this.findMatchToolStripMenuItem.Name = "findMatchToolStripMenuItem";
            this.findMatchToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.findMatchToolStripMenuItem.Text = "Find match";
            this.findMatchToolStripMenuItem.Click += new System.EventHandler(this.findMatchToolStripMenuItem_Click);
            // 
            // Buttonenter
            // 
            this.Buttonenter.Location = new System.Drawing.Point(140, 27);
            this.Buttonenter.Name = "Buttonenter";
            this.Buttonenter.Size = new System.Drawing.Size(75, 23);
            this.Buttonenter.TabIndex = 3;
            this.Buttonenter.Text = "ENTER";
            this.Buttonenter.UseVisualStyleBackColor = true;
            this.Buttonenter.Click += new System.EventHandler(this.Buttonenter_Click);
            // 
            // dgvmanager
            // 
            this.dgvmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanager.Location = new System.Drawing.Point(11, 250);
            this.dgvmanager.Name = "dgvmanager";
            this.dgvmanager.Size = new System.Drawing.Size(776, 179);
            this.dgvmanager.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvmanager);
            this.Controls.Add(this.Buttonenter);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.dgvteam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvteam;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchToolStripMenuItem;
        private System.Windows.Forms.Button Buttonenter;
        private System.Windows.Forms.DataGridView dgvmanager;
    }
}

