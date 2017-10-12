using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class Database
    {
        private System.Data.DataSet dataSet;
        
        public void CreateTableForAdopters()
        {
            System.Data.DataTable table = new DataTable();

            table.Columns.Add("Person ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Home Address", typeof(string));
            table.Columns.Add("Type of Home", typeof(string));
            table.Columns.Add("Owns Other Pets?", typeof(string));
            table.Columns.Add("Primary Veteranarian", typeof(string));
            table.Columns.Add("Has Children?", typeof(string));
            table.Columns.Add("Lifestyle and Activity Level", typeof(string));
            table.Columns.Add("Previous Experience With Pets?", typeof(string));

            table.Rows.Add();

        }
        DataClasses1DataContext dataclasses1 = new DataClasses1DataContext();

        public void AddValuestoAdopters()
        {

        }
    }
}
