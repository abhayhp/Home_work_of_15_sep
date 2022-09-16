using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_of_15_sep
{
    public class Stnt
    {
        private int rollno;
        private string name;
        private double per;

        public int Rollno { get; set; }
        public string Name { get; set; }
        public double Per { get; set; }


        public override string ToString()
        {
            return $"Rollno : {Rollno} \nName : {Name} \nPer : {Per}" ;
        }
    }
}
