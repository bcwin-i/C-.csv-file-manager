namespace Dengi_Store_Manager.Form_fragments
{
    partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit_search = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_search_type = new System.Windows.Forms.ComboBox();
            this.dgtv_search_result = new System.Windows.Forms.DataGridView();
            this.PanelDrag.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.SystemColors.Control;
            this.PanelDrag.Controls.Add(this.panel2);
            this.PanelDrag.Controls.Add(this.panel1);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(800, 67);
            this.PanelDrag.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(483, 67);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(463, 47);
            this.panel4.TabIndex = 13;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.txt_search.Location = new System.Drawing.Point(10, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(443, 27);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "store name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_submit_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_search_type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(483, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 67);
            this.panel1.TabIndex = 13;
            // 
            // btn_submit_search
            // 
            this.btn_submit_search.BackColor = System.Drawing.Color.White;
            this.btn_submit_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_submit_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_submit_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_submit_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_submit_search.IconSize = 32;
            this.btn_submit_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit_search.Location = new System.Drawing.Point(219, 17);
            this.btn_submit_search.Margin = new System.Windows.Forms.Padding(10);
            this.btn_submit_search.Name = "btn_submit_search";
            this.btn_submit_search.Size = new System.Drawing.Size(88, 40);
            this.btn_submit_search.TabIndex = 17;
            this.btn_submit_search.Text = "search";
            this.btn_submit_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit_search.UseVisualStyleBackColor = false;
            this.btn_submit_search.Click += new System.EventHandler(this.btn_submit_search_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search by:";
            // 
            // cmb_search_type
            // 
            this.cmb_search_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.cmb_search_type.FormattingEnabled = true;
            this.cmb_search_type.Location = new System.Drawing.Point(5, 36);
            this.cmb_search_type.Name = "cmb_search_type";
            this.cmb_search_type.Size = new System.Drawing.Size(201, 21);
            this.cmb_search_type.TabIndex = 14;
            // 
            // dgtv_search_result
            // 
            this.dgtv_search_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtv_search_result.BackgroundColor = System.Drawing.Color.White;
            this.dgtv_search_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtv_search_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtv_search_result.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtv_search_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtv_search_result.EnableHeadersVisualStyles = false;
            this.dgtv_search_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.dgtv_search_result.Location = new System.Drawing.Point(0, 67);
            this.dgtv_search_result.Name = "dgtv_search_result";
            this.dgtv_search_result.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtv_search_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgtv_search_result.Size = new System.Drawing.Size(800, 383);
            this.dgtv_search_result.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgtv_search_result);
            this.Controls.Add(this.PanelDrag);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.PanelDrag.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_search_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDrag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_search_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgtv_search_result;
        private FontAwesome.Sharp.IconButton btn_submit_search;
    }
}