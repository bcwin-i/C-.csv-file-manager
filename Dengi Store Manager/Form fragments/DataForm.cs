using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dengi_Store_Manager.Form_fragments
{
    public partial class DataForm : Form
    {
        bool started = false;
        bool completed = false;
        public DataForm()
        {
            InitializeComponent();
        }

        IEnumerable<Order> result;
        List<bool> selected = new List<bool> { false, false, false, false, false, false };


        private async Task loadControls()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            cmb_store_code.Items.Clear();
            cmb_store_location.Items.Clear();
            cmb_week_number.Items.Clear();
            cmb_year.Items.Clear();
            cmb_supplier_name.Items.Clear();
            cmb_supplier_type.Items.Clear();

            

            var t1 = Task.Run(() =>
            {
                List<String> storecodes = new List<string>();
                List<String> storelocation = new List<string>();
                List<String> weekno = new List<string>();
                List<String> year = new List<string>();
                List<String> supplier_name = new List<string>();
                List<String> supplier_type = new List<string>();

                cmb_store_code.Items.Add("All");
                cmb_store_location.Items.Add("All");
                cmb_week_number.Items.Add("All");
                cmb_year.Items.Add("All");
                cmb_supplier_name.Items.Add("All");
                cmb_supplier_type.Items.Add("All");

                cmb_store_code.BeginUpdate(); // <- Stop painting
                cmb_store_location.BeginUpdate(); // <- Stop painting
                cmb_week_number.BeginUpdate(); // <- Stop painting
                cmb_year.BeginUpdate(); // <- Stop painting
                cmb_supplier_name.BeginUpdate(); // <- Stop painting
                cmb_supplier_type.BeginUpdate(); // <- Stop painting*/

                try
                {

                    foreach (var r in result)
                    {
                        if (!storecodes.Contains(r.Store_Code))
                        {
                            storecodes.Add(r.Store_Code);
                            cmb_store_code.Items.Add(r.Store_Code);
                        }
                        if (!storelocation.Contains(r.Store_Location))
                        {
                            storelocation.Add(r.Store_Location);
                            cmb_store_location.Items.Add(r.Store_Location);
                        }
                        if (!weekno.Contains(r.Week_Number.ToString()))
                        {
                            weekno.Add(r.Week_Number.ToString());
                            cmb_week_number.Items.Add(r.Week_Number.ToString());
                        }
                        if (!year.Contains(r.Year.ToString()))
                        {
                            year.Add(r.Year.ToString());
                            cmb_year.Items.Add(r.Year.ToString());
                        }
                        if (!supplier_name.Contains(r.Supplier_Name))
                        {
                            supplier_name.Add(r.Supplier_Name);
                            cmb_supplier_name.Items.Add(r.Supplier_Name);
                        }
                        if (!supplier_type.Contains(r.Supplier_Type))
                        {
                            supplier_type.Add(r.Supplier_Type);
                            cmb_supplier_type.Items.Add(r.Supplier_Type);
                        }
                    }

                }
                finally
                {

                    //cmb_store_code.EndUpdate(); // <- Finally, repaint if required
                    cmb_store_code.EndUpdate(); // <- Finally, repaint if required
                    cmb_store_location.EndUpdate(); // <- Finally, repaint if required
                    cmb_week_number.EndUpdate(); // <- Finally, repaint if required
                    cmb_year.EndUpdate(); // <- Finally, repaint if required
                    cmb_supplier_name.EndUpdate(); // <- Finally, repaint if required
                    cmb_supplier_type.EndUpdate(); // <- Finally, repaint if required
                }

            });
            await t1;

        }

        private async Task loadd()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            btn_load.Enabled = false;
            btn_load.Text = "Loading";

            var tasks = new List<Task>();

            var t = Task.Run(() =>
            {
                if (started)
                {
                    Invoke(new Action(() =>
                    {
                        dgvData.DataSource = null;
                    }));
                    
                }

                double total = 0;
                // Adding new items into the cmbMovieListingBox 
                foreach (var r in result)
                {
                    total += r.Cost;
                }
                total = Math.Round(total, 2);


                var value = total.ToString("c");
                Invoke(new Action(() =>
                {
                    lbl_total_cost.Text = value;
                }));
            });

            tasks.Add(t);
            await t;

            var t1 = Task.Run(() =>
            {

                if (result.Count() != 0)
                {
                    Invoke(new Action(() =>
                    {
                        dgvData.DataSource = result.ToList();
                    }));
                    
                }

            });

            tasks.Add(t1);
            await t1;

            Task.WaitAll(tasks.ToArray());
            started = true;
            btn_load.Enabled = true;
            btn_load.Text = "Load";
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            result = from s in ListTest.read() select s;
            if (!started)
            {
                //result = from s in result where s.Cost.ToString() == "88.37" select s;
                await loadd();
                await loadControls();
            }
            else
            {
                await querying();
                //MessageBox.Show(cmb_store_code.SelectedItem.ToString());
            }
        }

        private async Task querying()
        {

            var tasks = new List<Task>();

            var t = Task.Run(() =>
            {
                //result = from s in result where s.Cost.ToString() == "88.37" select s;
                if (cmb_store_code.Text != null && cmb_store_code.Text != "" && cmb_store_code.Text != "All")
                {
                    var value = cmb_store_code.Text;
                    result = from s in result where s.Store_Code == value select s;
                }


                if (cmb_store_location != null && cmb_store_location.Text != "" && cmb_store_location.Text != "All")
                {
                    var value = cmb_store_location.Text;
                    result = from s in result where s.Store_Location == value select s;
                }

                if (cmb_week_number.Text != null && cmb_week_number.Text != "" && cmb_week_number.Text != "All")
                {
                    var value = cmb_week_number.Text;
                    result = from s in result where s.Week_Number.ToString() == value select s;
                }

                if (cmb_year.Text != null && cmb_year.Text != "" && cmb_year.Text != "All")
                {
                    var value = cmb_year.Text;
                    result = from s in result where s.Year.ToString() == value select s;
                }

                if (cmb_supplier_name.Text != null && cmb_supplier_name.Text != "" && cmb_supplier_name.Text != "All")
                {
                    var value = cmb_supplier_name.Text;
                    result = from s in result where s.Supplier_Name == value select s;
                }

                if (cmb_supplier_type.Text != null && cmb_supplier_type.Text != "" && cmb_supplier_type.Text != "All")
                {
                    var value = cmb_supplier_type.Text;
                    result = from s in result where s.Supplier_Type == value select s;
                }
            });

            tasks.Add(t);
            await t;

            Task.WaitAll(tasks.ToArray());

            //MessageBox.Show("Done");
            await loadd();
        }


    }
}
