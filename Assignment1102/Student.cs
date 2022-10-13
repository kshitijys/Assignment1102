using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1102
{
    public class Student
    {
        
        private int rollno,phy,chem,maths,total,percentage;
        private string name;
        public static int count;

        public Student(string name, int phy, int chem, int maths)
        {
            count++;
            this.rollno= count;
            this.name = name;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
            
        }  
        public void calculation()
        {
            total = phy + chem + maths;
            percentage = total *100 / 300;
        }

        public override string ToString()
        {
            return $"rollno={rollno} name={name} percentage={percentage}";     
        }

    }
}
//Create class student
//Auto generate the rollno
//Accept name & 3 subject marks from constructor

//Use calculate method to calculate total & percentage

//Display details using ToString()
