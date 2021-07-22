namespace Dengi_Store_Manager
{
    partial class HomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_settings = new FontAwesome.Sharp.IconButton();
            this.btn_graph = new FontAwesome.Sharp.IconButton();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.btn_data = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_home = new System.Windows.Forms.PictureBox();
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_run_time = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_home)).BeginInit();
            this.PanelDrag.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btn_settings);
            this.panelMenu.Controls.Add(this.btn_graph);
            this.panelMenu.Controls.Add(this.btn_search);
            this.panelMenu.Controls.Add(this.btn_data);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 572);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_settings.IconColor = System.Drawing.Color.White;
            this.btn_settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_settings.IconSize = 25;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 306);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(242, 60);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_graph
            // 
            this.btn_graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_graph.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_graph.FlatAppearance.BorderSize = 0;
            this.btn_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graph.ForeColor = System.Drawing.Color.White;
            this.btn_graph.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btn_graph.IconColor = System.Drawing.Color.White;
            this.btn_graph.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_graph.IconSize = 25;
            this.btn_graph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_graph.Location = new System.Drawing.Point(0, 246);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(242, 60);
            this.btn_graph.TabIndex = 3;
            this.btn_graph.Text = "Graph";
            this.btn_graph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_graph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_graph.UseVisualStyleBackColor = false;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.White;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 25;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(0, 186);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(242, 60);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_data.FlatAppearance.BorderSize = 0;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.ForeColor = System.Drawing.Color.White;
            this.btn_data.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btn_data.IconColor = System.Drawing.Color.White;
            this.btn_data.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_data.IconSize = 25;
            this.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.Location = new System.Drawing.Point(0, 126);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(242, 60);
            this.btn_data.TabIndex = 1;
            this.btn_data.Text = "Data";
            this.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.pbx_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.White;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(242, 126);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label3.Location = new System.Drawing.Point(115, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "CSV Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label2.Location = new System.Drawing.Point(96, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dengi Store";
            // 
            // pbx_home
            // 
            this.pbx_home.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx_home.Image = ((System.Drawing.Image)(resources.GetObject("pbx_home.Image")));
            this.pbx_home.Location = new System.Drawing.Point(12, 12);
            this.pbx_home.Name = "pbx_home";
            this.pbx_home.Size = new System.Drawing.Size(78, 79);
            this.pbx_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_home.TabIndex = 1;
            this.pbx_home.TabStop = false;
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.SystemColors.Control;
            this.PanelDrag.Controls.Add(this.panel1);
            this.PanelDrag.Controls.Add(this.lblTitleChildForm);
            this.PanelDrag.Controls.Add(this.iconCurrentChildForm);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(242, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(801, 75);
            this.PanelDrag.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lbl_run_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(654, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 75);
            this.panel1.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.progressBar1.Location = new System.Drawing.Point(6, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(129, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lbl_run_time
            // 
            this.lbl_run_time.AutoSize = true;
            this.lbl_run_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_run_time.Font = new System.Drawing.Font("Microsoft Tai Le", 8F);
            this.lbl_run_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.lbl_run_time.Location = new System.Drawing.Point(12, 38);
            this.lbl_run_time.Name = "lbl_run_time";
            this.lbl_run_time.Size = new System.Drawing.Size(25, 14);
            this.lbl_run_time.TabIndex = 8;
            this.lbl_run_time.Text = "0 %";
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 26);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 21);
            this.lblTitleChildForm.TabIndex = 6;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.BackColor = System.Drawing.Color.White;
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(242, 75);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(801, 497);
            this.panelWorkArea.TabIndex = 3;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.panelWorkArea);
            this.Controls.Add(this.PanelDrag);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeWindow_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_home)).EndInit();
            this.PanelDrag.ResumeLayout(false);
            this.PanelDrag.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelDrag;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbx_home;
        private FontAwesome.Sharp.IconButton btn_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_settings;
        private FontAwesome.Sharp.IconButton btn_graph;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbl_run_time;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWorkArea;
    }
}