using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Dengi_Store_Manager.Form_fragments
{
    public partial class GraphForm : Form
    {
        
        private Dictionary<string, List<double>> list = new Dictionary<string, List<double>>();
        IEnumerable<Order> result;
        bool started = false;
        public GraphForm()
        {
            InitializeComponent();

            result = from s in ListTest.read() orderby s.Week_Number select s;
            btn_add.PerformClick();
            
            var weeks = new List<string>();
            for(int i = 1; i<53; i++)
            {
                weeks.Add($"{i}");
            }

            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private async Task loadControls()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_add.Enabled = false;
            btn_add.Text = "Loading controls";

            var t1 = Task.Run(() =>
            {
                List<String> storecodes = new List<string>();
                List<String> storelocation = new List<string>();
                List<String> weekno = new List<string>();
                List<String> year = new List<string>();
                List<String> supplier_name = new List<string>();
                List<String> supplier_type = new List<string>();

                cmb_s_code.BeginUpdate(); // <- Stop painting
                cmb_s_location.BeginUpdate(); // <- Stop painting
                cmb_w_number.BeginUpdate();
                cmb_y.BeginUpdate();
                cmb_su_name.BeginUpdate(); // <- Stop painting
                cmb_su_type.BeginUpdate(); // <- Stop painting*/

                try
                {

                    foreach (var r in result)
                    {
                        if (!storecodes.Contains(r.Store_Code))
                        {
                            storecodes.Add(r.Store_Code);
                            cmb_s_code.Items.Add(r.Store_Code);
                        }
                        if (!storelocation.Contains(r.Store_Location))
                        {
                            storelocation.Add(r.Store_Location);
                            cmb_s_location.Items.Add(r.Store_Location);
                        }
                        if (!weekno.Contains(r.Week_Number.ToString()))
                        {
                            weekno.Add(r.Week_Number.ToString());
                            cmb_w_number.Items.Add(r.Week_Number.ToString());
                        }
                        if (!year.Contains(r.Year.ToString()))
                        {
                            year.Add(r.Year.ToString());
                            cmb_y.Items.Add(r.Year.ToString());
                        }
                        if (!storelocation.Contains(r.Store_Location))
                        {
                            storelocation.Add(r.Store_Location);
                            cmb_s_location.Items.Add(r.Store_Location);
                        }
                        if (!supplier_name.Contains(r.Supplier_Name))
                        {
                            supplier_name.Add(r.Supplier_Name);
                            cmb_su_name.Items.Add(r.Supplier_Name);
                        }
                        if (!supplier_type.Contains(r.Supplier_Type))
                        {
                            supplier_type.Add(r.Supplier_Type);
                            cmb_su_type.Items.Add(r.Supplier_Type);
                        }
                    }

                }
                finally
                {

                    //cmb_store_code.EndUpdate(); // <- Finally, repaint if required
                    cmb_s_code.EndUpdate(); // <- Finally, repaint if required
                    cmb_s_location.EndUpdate(); // <- Finally, repaint if require
                    cmb_w_number.EndUpdate(); // <- Finally, repaint if required
                    cmb_y.EndUpdate(); // <- Finally, repaint if require
                    cmb_su_name.EndUpdate(); // <- Finally, repaint if required
                    cmb_su_type.EndUpdate(); // <- Finally, repaint if required
                }

            });
            await t1;
            started = true;
            btn_add.Enabled = true;
            btn_add.Text = "Add";
        }

        private async Task querying()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            var tasks = new List<Task>();
            var store_code = cmb_s_code.Text;
            if(store_code == "" || store_code == "None")
            {
                MessageBox.Show("Store code can't be empty or none.");
                return;
            }

            var t = Task.Run(() =>
            {
                //result = from s in result where s.Cost.ToString() == "88.37" select s;
                if (cmb_s_code.Text != null && cmb_s_code.Text != "" && cmb_s_code.Text != "All")
                {
                    var value = cmb_s_code.Text;
                    result = from s in result where s.Store_Code == value select s;
                }


                if (cmb_s_location != null && cmb_s_location.Text != "" && cmb_s_location.Text != "All")
                {
                    var value = cmb_s_location.Text;
                    result = from s in result where s.Store_Location == value select s;
                }

                if (cmb_w_number.Text != null && cmb_w_number.Text != "" && cmb_w_number.Text != "All")
                {
                    var value = cmb_w_number.Text;
                    result = from s in result where s.Week_Number.ToString() == value select s;
                }

                if (cmb_y.Text != null && cmb_y.Text != "" && cmb_y.Text != "All")
                {
                    var value = cmb_y.Text;
                    result = from s in result where s.Year.ToString() == value select s;
                }

                if (cmb_su_name.Text != null && cmb_su_name.Text != "" && cmb_su_name.Text != "All")
                {
                    var value = cmb_su_name.Text;
                    result = from s in result where s.Supplier_Name == value select s;
                }

                if (cmb_su_type.Text != null && cmb_su_type.Text != "" && cmb_su_type.Text != "All")
                {
                    var value = cmb_su_type.Text;
                    result = from s in result where s.Supplier_Type == value select s;
                }
            });

            tasks.Add(t);
            await t;

            Task.WaitAll(tasks.ToArray());

            //MessageBox.Show("Done");
            await loadd();
        }

        private async Task loadd()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;

            btn_add.Enabled = false;
            btn_add.Text = "Loading";
            var year = cmb_y.Text;
            var store_code = cmb_s_code.Text +" "+year;
            List<double> cost = new List<double>();

            var tasks = new List<Task>();

            var t = Task.Run(() =>
            { 
                if(result.Count() < 1)
                {
                    MessageBox.Show("Query results empty");
                    return;
                }
                foreach (var r in result)
                { 
                    cost.Add(r.Cost);
                }
                try
                {
                    list.Add(store_code, cost);
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message);
                }
                
                
            });

            tasks.Add(t);
            await t;

            var t1 = Task.Run(() =>
            {

                Invoke(new Action(() =>
                {
                    pieChart1.Series.Clear();
                    //MessageBox.Show(list.Count().ToString());
                    foreach (var data in list)
                    {
                        List<double> l = new List<double>();
                        double value = 0;
                        
                        foreach(var cost in data.Value)
                        {
                            value += cost;
                        }
                        MessageBox.Show(value.ToString());
                        pieChart1.Series.Add(new PieSeries
                        {
                            Title = data.Key,
                            Values = new ChartValues<double> { value }
                        });

                    }

                }));



            });

            tasks.Add(t1);
            await t1;
            Task.WaitAll(tasks.ToArray());

            btn_add.Enabled = true;
            btn_add.Text = "Add";
        }

        private async void btn_add_Click_1(object sender, EventArgs e)
        {
            result = from s in ListTest.read() orderby s.Week_Number select s;
            if (started) await querying();
            else await loadControls();
        }
    }
}
