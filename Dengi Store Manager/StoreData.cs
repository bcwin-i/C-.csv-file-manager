using Dengi_Store_Manager.Form_fragments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dengi_Store_Manager
{

    

    class Store
    {
        public string StoreCode { get; set; }
        public string StoreLocation { get; set; }
    }

    class Date
    {
        public int Week { get; set; }
        public int Year { get; set; }
    }

    class Order
    {
        public string Store_Code { get; set; }

        public string Store_Location { get; set; }
        public int Week_Number { get; set; }
        public int Year { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Type { get; set; }
        public double Cost { get; set; }
    }

    static class details
    {
        public static List<Order> data { get; set; }
    }

    static class ListTest
    {
        static List<Order> _list;

        static ListTest()
        {
            // Allocate the list.
            _list = new List<Order>();
        }

        public static void Record(Order value)
        {
            // Record this value in the list.
            _list.Add(value);
        }

        public static void Display()
        {
            // Write out the results.
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }
        }

        public static List<Order> read()
        {
            return _list;
        }
    }


    class StoreData
    {
        public static bool done = false;
        public static List<Order> data = new List<Order>();

        public async void run(ProgressBar bar, /*DataGrid grid,*/ Label lbl, Panel panelMenu, Form on, Button clic)
        {

            Progress<int> progress = new Progress<int>(value => {
                bar.Value = value;
                lbl.Text = $"Setting up things {value} %";

                if(value == 100)
                {
                    bar.Visible = false;
                    lbl.Visible = false;
                    HomeWindow.A_ConnectedChanged(on);
                    clic.PerformClick();
                }
            });

            await RunAsync(progress, lbl, panelMenu);

        }

        public List<Task> task1 = new List<Task>();

        static string folderPath = "StoreData";
        static string storeCodesFile = "StoreCodes.csv";
        static string storeDataFolder = "StoreData";

        public Dictionary<string, Store> stores = new Dictionary<string, Store>();
        public HashSet<Date> dates = new HashSet<Date>();
        public static  List<Order> orders = new List<Order>();


        static string storeCodesFilePath = Directory.GetCurrentDirectory() + @"\" + folderPath + @"\" + storeCodesFile;
        string[] storeCodesData = File.ReadAllLines(storeCodesFilePath);
        string[] fileNames = Directory.GetFiles(folderPath + @"\" + storeDataFolder);


        public async Task RunAsync(IProgress<int> progress, Label lbl, Panel panelMenu)
        {
            var tasks = new List<Task>();

            foreach (var storeData in storeCodesData)
            {

                var t = new Task(() =>
                {
                    string[] storeDataSplit = storeData.Split(',');
                    Store store = new Store
                    {
                        StoreCode = storeDataSplit[0],
                        StoreLocation = storeDataSplit[1]
                    };
                    if (!stores.ContainsKey(store.StoreCode)) stores.Add(store.StoreCode, store);

                });

                tasks.Add(t);
                t.Start();
                await t;
            }

            Task.WaitAll(tasks.ToArray());

            progress.Report(50);

            foreach (var filePath in fileNames)
            {
                var t = new Task(() =>
                {
                    string fileNameExt = Path.GetFileName(filePath);
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string[] fileNameSplit = fileName.Split('_');
                    Store store = stores[fileNameSplit[0]];
                    Date date = new Date
                    {
                        Week = Convert.ToInt32(fileNameSplit[1]),
                        Year = Convert.ToInt32(fileNameSplit[2])
                    };
                    dates.Add(date);

                    string[] orderData = File.ReadAllLines(folderPath + @"\" + storeDataFolder + @"\" + fileNameExt);
                    foreach (var orderInfo in orderData)
                    {
                        string[] orderSplit = orderInfo.Split(',');
                        Order order = new Order
                        {
                            Store_Code = store.StoreCode,
                            Store_Location = store.StoreLocation,
                            Week_Number = Convert.ToInt32(date.Week),
                            Year = Convert.ToInt32(date.Year),
                            Supplier_Name = orderSplit[0],
                            Supplier_Type = orderSplit[1],
                            Cost = Convert.ToDouble(orderSplit[2])
                        };
                        //orders.Add(order);
                        ListTest.Record(order);
                    }

                });
                task1.Add(t);
                t.Start();
                await t;
            }


            //whenAll = WhenAllEx(tasks, _ => lbl.Text = $"Setting up {(_.Count(task => task.IsCompleted) / tasks.Count()) * 100} ");
            //whenAll.Wait();
            Task.WaitAll(task1.ToArray());
            progress.Report(100);
            

        }

        public async Task RunAsync()
        {
            var tasks = new List<Task>();

            foreach (var storeData in storeCodesData)
            {

                var t = new Task(() =>
                {
                    string[] storeDataSplit = storeData.Split(',');
                    Store store = new Store
                    {
                        StoreCode = storeDataSplit[0],
                        StoreLocation = storeDataSplit[1]
                    };
                    if (!stores.ContainsKey(store.StoreCode)) stores.Add(store.StoreCode, store);

                });

                tasks.Add(t);
                t.Start();
                await t;
            }

            Task.WaitAll(tasks.ToArray());


            foreach (var filePath in fileNames)
            {
                var t = new Task(() =>
                {
                    string fileNameExt = Path.GetFileName(filePath);
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string[] fileNameSplit = fileName.Split('_');
                    Store store = stores[fileNameSplit[0]];
                    Date date = new Date
                    {
                        Week = Convert.ToInt32(fileNameSplit[1]),
                        Year = Convert.ToInt32(fileNameSplit[2])
                    };
                    dates.Add(date);

                    string[] orderData = File.ReadAllLines(folderPath + @"\" + storeDataFolder + @"\" + fileNameExt);
                    foreach (var orderInfo in orderData)
                    {
                        string[] orderSplit = orderInfo.Split(',');
                        Order order = new Order
                        {
                            Store_Code = store.StoreCode,
                            Store_Location = store.StoreLocation,
                            Week_Number = Convert.ToInt32(date.Week),
                            Year = Convert.ToInt32(date.Year),
                            Supplier_Name = orderSplit[0],
                            Supplier_Type = orderSplit[1],
                            Cost = Convert.ToDouble(orderSplit[2])
                        };
                        //orders.Add(order);
                        ListTest.Record(order);
                    }

                });
                task1.Add(t);
                t.Start();
                await t;
            }
            Task.WaitAll(task1.ToArray());
            //MessageBox.Show("Done");
            

        }
    }

    

}
