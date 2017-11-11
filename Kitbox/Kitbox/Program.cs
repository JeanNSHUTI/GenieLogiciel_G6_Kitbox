using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitboxClassLibrary;
using System.Reflection;

namespace Kitbox
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Load library ClassLibrary1.dll
            Assembly classlibrary = Assembly.LoadFrom("KitboxClassLibrary.dll");
            DbManager db = new DbManager();
            db.AddClients();
            db.AddEmployees();
            db.AddSuppliers();
            db.SetDataTableFromCSVFile(@"C:\Users\Jean\Documents\Visual Studio 2015\Projects\Group6Kitbox\kitbox.csv");
            db.PopulateStockList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(db));
        }
    }
}
