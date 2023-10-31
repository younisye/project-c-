using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_sharp
{
    
    
        internal class Middle : Cars
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public string Color { get; set; }
            public double Price { get; set; }

            public void Add_data()
            {
                File.AppendAllText("m.txt", this.Id + " " + this.Name + " " + this.Color + " " + this.Price + "*");
            }

        public string[] Show_result()
        {
            String d = File.ReadAllText("m.txt");
            return d.Split('*');
        }
    }
    
}
