using Dengi_Store_Manager.Form_fragments;
using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dengi_Store_Manager
{
    public partial class HomeWindow : Form
    {
        
        public static DataForm dataform;
        public static SearchForm searchform;
        public static GraphForm graphForm;

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private Form CallingForm = null;

        private static bool completed = false;

       

        public static void A_ConnectedChanged(Form mainform)
        {
            //MessageBox.Show("Yep");
            dataform = new DataForm();
            searchform = new SearchForm();
            //mainform.//OpenChildForm(dataform);
            graphForm = new GraphForm();

            completed = true;
        }

        public HomeWindow(Form callingForm) : this()
        {
            this.CallingForm = callingForm;
        }


        public HomeWindow()
        {
            InitializeComponent();

            //Creating left boder on panels
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
               
            StoreData load = new StoreData();
            //using(frmWaitForm )
            load.run(progressBar1, lbl_run_time, panelMenu, this, btn_data);
            
        }


        //Methods
        private void AcceptButton(object senderBtn, Color color)
        {
            if (!completed) return;
            if (senderBtn != null)
            {
                //Disabling the previous button
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(227, 227, 227);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Home icon and title
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Setting button defaults except selected
                currentBtn.BackColor = Color.FromArgb(48, 115, 40);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (!completed) return;
            foreach (var child in panelWorkArea.Controls)
            {
                if(child == childForm)
                {
                    currentChildForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    //panelWorkArea.Controls.Add(childForm);
                    panelWorkArea.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    return;
                }
            }
           
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelWorkArea.Controls.Add(childForm);
            panelWorkArea.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, Color.FromArgb(48, 115, 40));
            OpenChildForm(dataform);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, Color.FromArgb(48, 115, 40));
            OpenChildForm(searchform);
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, Color.FromArgb(48, 115, 40));
            OpenChildForm(graphForm);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, Color.FromArgb(48, 115, 40));
        }

        private void HomeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CallingForm != null) this.CallingForm.Show();
        }
    }
}
