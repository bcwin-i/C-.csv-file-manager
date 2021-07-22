namespace Dengi_Store_Manager.Form_fragments
{
    partial class GraphForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_s_code = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_s_location = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_su_name = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_su_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_graph_list = new System.Windows.Forms.ComboBox();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_w_number = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_y = new System.Windows.Forms.ComboBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmb_su_type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_su_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_y);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_w_number);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_s_location);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_s_code);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 112);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_remove);
            this.panel2.Controls.Add(this.cmb_graph_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(731, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 112);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pieChart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 355);
            this.panel3.TabIndex = 1;
            // 
            // cmb_s_code
            // 
            this.cmb_s_code.BackColor = System.Drawing.Color.White;
            this.cmb_s_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_s_code.FormattingEnabled = true;
            this.cmb_s_code.Location = new System.Drawing.Point(7, 36);
            this.cmb_s_code.Name = "cmb_s_code";
            this.cmb_s_code.Size = new System.Drawing.Size(181, 21);
            this.cmb_s_code.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Store code";
            // 
            // cmb_s_location
            // 
            this.cmb_s_location.BackColor = System.Drawing.Color.White;
            this.cmb_s_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_s_location.FormattingEnabled = true;
            this.cmb_s_location.Location = new System.Drawing.Point(7, 83);
            this.cmb_s_location.Name = "cmb_s_location";
            this.cmb_s_location.Size = new System.Drawing.Size(181, 21);
            this.cmb_s_location.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Store location";
            // 
            // cmb_su_name
            // 
            this.cmb_su_name.BackColor = System.Drawing.Color.White;
            this.cmb_su_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_su_name.FormattingEnabled = true;
            this.cmb_su_name.Location = new System.Drawing.Point(381, 36);
            this.cmb_su_name.Name = "cmb_su_name";
            this.cmb_su_name.Size = new System.Drawing.Size(181, 21);
            this.cmb_su_name.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Supplier name";
            // 
            // cmb_su_type
            // 
            this.cmb_su_type.BackColor = System.Drawing.Color.White;
            this.cmb_su_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_su_type.FormattingEnabled = true;
            this.cmb_su_type.Location = new System.Drawing.Point(381, 83);
            this.cmb_su_type.Name = "cmb_su_type";
            this.cmb_su_type.Size = new System.Drawing.Size(181, 21);
            this.cmb_su_type.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Supplier type";
            // 
            // cmb_graph_list
            // 
            this.cmb_graph_list.BackColor = System.Drawing.Color.White;
            this.cmb_graph_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_graph_list.FormattingEnabled = true;
            this.cmb_graph_list.Location = new System.Drawing.Point(7, 6);
            this.cmb_graph_list.Name = "cmb_graph_list";
            this.cmb_graph_list.Size = new System.Drawing.Size(181, 21);
            this.cmb_graph_list.TabIndex = 26;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btn_remove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.IconSize = 28;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(7, 36);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(10);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(181, 30);
            this.btn_remove.TabIndex = 27;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(115)))), ((int)(((byte)(40)))));
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 26;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(7, 74);
            this.btn_add.Margin = new System.Windows.Forms.Padding(10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 30);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "Load controls";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Week number";
            // 
            // cmb_w_number
            // 
            this.cmb_w_number.BackColor = System.Drawing.Color.White;
            this.cmb_w_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_w_number.FormattingEnabled = true;
            this.cmb_w_number.Location = new System.Drawing.Point(194, 36);
            this.cmb_w_number.Name = "cmb_w_number";
            this.cmb_w_number.Size = new System.Drawing.Size(181, 21);
            this.cmb_w_number.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Year";
            // 
            // cmb_y
            // 
            this.cmb_y.BackColor = System.Drawing.Color.White;
            this.cmb_y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_y.FormattingEnabled = true;
            this.cmb_y.Location = new System.Drawing.Point(194, 83);
            this.cmb_y.Name = "cmb_y";
            this.cmb_y.Size = new System.Drawing.Size(181, 21);
            this.cmb_y.TabIndex = 23;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(931, 355);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_s_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_s_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_su_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_su_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_graph_list;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_remove;
        private System.Windows.Forms.ComboBox cmb_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_w_number;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}