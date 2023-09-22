using Aspose.Cells;
using ProjectStructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreDB
{
    public class CitiesParser
    {
        public static List<City> Parse()
        {
            Workbook wb = new("d:\\Repos\\Cottage.xlsm");
            WorksheetCollection worksheets = wb.Worksheets;
            Worksheet cities = worksheets.Where(w => w.Name == "Города").FirstOrDefault();
            int rows = worksheets[1].Cells.MaxDataRow;
            List<City> cityList = new();
            //var a = cities.Cells[1,1].Value.ToString();
            for (int i = 1; i <= 1118; i++)
            {
                City city = new()
                {
                    Name = cities.Cells[i, 0].Value.ToString(),
                    Region = cities.Cells[i, 1].Value.ToString(),
                    BigRegion = cities.Cells[i, 2].Value.ToString(),
                    FreezingDepth = (double)cities.Cells[i, 3].Value
                };
                cityList.Add(city);
            }
            Debug.Write("Распаршено {0} городов", cityList.Count.ToString());

            return cityList;
        }
    }
}
