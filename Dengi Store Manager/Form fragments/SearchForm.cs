using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dengi_Store_Manager.Form_fragments
{
    public partial class SearchForm : Form
    {
        IEnumerable<Order> result;
        public SearchForm()
        {
            InitializeComponent();

            cmb_search_type.BeginUpdate(); // <- Stop painting*/
            cmb_search_type.Items.Add("Store code");
            cmb_search_type.Items.Add("Store location");
            cmb_search_type.Items.Add("Week number");
            cmb_search_type.Items.Add("Year");
            cmb_search_type.Items.Add("Supplier name");
            cmb_search_type.Items.Add("Supplier type");
            cmb_search_type.Items.Add("Cost");
            cmb_search_type.EndUpdate(); // <- Finally, repaint if required
        }


        private async Task querySearch()
        {
            var value = cmb_search_type.Text;
            var search = txt_search.Text;
            //for

            if(search == "")
            {
                MessageBox.Show("Search text box can't be empty");
                return;
            }
            if (value == "")
            {
                MessageBox.Show("Search text box can't be empty");
                return;
            }

            var task = Task.Run(() =>
            {
                if (value == "Store code") result = result.AsQueryable().Where(x => x.Store_Code.ToLower().Contains(search.ToLower()));
                if (value == "Store location") result = result.AsQueryable().Where(x => x.Store_Location.ToLower().Contains(search.ToLower()));
                if (value == "Week number") result = result.AsQueryable().Where(x => x.Week_Number.ToString().Contains(search));
                if (value == "Year") result = result.AsQueryable().Where(x => x.Year.ToString().Contains(search));
                if (value == "Supplier name") result = result.AsQueryable().Where(x => x.Supplier_Name.ToLower().Contains(search.ToLower()));
                if (value == "Supplier type") result = result.AsQueryable().Where(x => x.Supplier_Type.ToLower().Contains(search.ToLower()));
                if (value == "Cost") result = result.AsQueryable().Where(x => x.Cost.ToString().Contains(search));
            });
            //from c in result where SqlFunctions.PatIndex(search.ToLower(), c.Supplier_Type) > 0 select c;
            //result = from s in result where SqlMethods.Like(s.Supplier_Type, "%" + search + "%, " + s.Supplier_Type) select s;

            await task;
            await loadResult();
        }

        private async Task loadResult()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            btn_submit_search.Enabled = false;


            var t1 = Task.Run(() =>
            {

                if (result.Count() != 0)
                {
                    Invoke(new Action(() =>
                    {
                        dgtv_search_result.DataSource = result.ToList();
                    }));

                }

            });

            await t1;

            
            btn_submit_search.Enabled = true;
            
        }

        private async void btn_submit_search_Click_1(object sender, EventArgs e)
        {
            result = from s in ListTest.read() select s;
            await querySearch();
        }
    }
}
