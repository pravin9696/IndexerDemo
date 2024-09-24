using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo.indexer
{
    class student
    {
        string name;
        string grade;
        public string this[string str]
        {
            set {
                if (str=="name")
                {
                    name = value;
                }
                else if(str=="grade")
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Wrong string provided!!!");
                }
            }
            get {
                if (str=="name")
                {
                    return name;
                }
                else if(str=="grade")
                {
                    return grade;
                }
                else
                {
                    Console.WriteLine("Wrong string index provided!!");
                    return null;
                }
            }
        }
    }
    class states
    {
        public int []PIN=new int[4];
       public string[] stateArray = new string[5];

        public int this[int  j,int k]//multi diamentional indexer
        {
            set { PIN[j] = value; }
            get { return PIN[j]; }
        }

        //Create indexer for stateArray
        public string this[int i]//i=0
        {
            set 
            {
                stateArray[i] = value;//maharashtra
            }
            get 
            {
                return stateArray[i];
            }
        }

    }
    internal class indexerDemo240924
    {
    }
}
