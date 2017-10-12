using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class Animals
    {
        public DataTable ConvertCSVtoDataTable()
        {
            FileStream filestream = new FileStream(@"C:\Users\Matthew Miranda\Documents\projects\animals.csv", FileMode.Open, FileAccess.Read);//opens the csv file
            StreamReader streamAnimalTable = new StreamReader(filestream);//Creates StreamReader which reads the filepath string
            string[] animals = streamAnimalTable.ReadLine().Split(',');//splits each string in the CSV file separated by a comma and feeds it into an arrray
            DataTable animaltable = new DataTable();//creates a datatable object which has each separated string fed into it by the foreach loop
            foreach (string animal in animals)
            {
                animaltable.Columns.Add(animal);
            }
            while (!streamAnimalTable.EndOfStream)//this while function ensures that we don't insert values into the streamAnimalTable at the end of the stream
            {
                string[] rows = Regex.Split(streamAnimalTable.ReadLine(), ",");//Splits input string into an array of substrings at the positions defined by a regular expression pattern
                DataRow dr = animaltable.NewRow();
                for (int i = 0; i < animals.Length; i++)
                {
                    dr[i] = rows[i];
                }
                animaltable.Rows.Add(dr);
            }
            return animaltable;
        }
    }
 }

