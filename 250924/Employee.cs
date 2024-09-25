using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo._250924
{
    internal class Employee
    {
        private string ID;
        private string Name;
        string[]addrss=new string[2];
        public string this[int i]//indexer 1
        {
            set {
                addrss[i] = value;
            }
            get 
            {
                return addrss[i];
            }
        }
      virtual  public string this[string str]//indexer 2
        {
            set
            {
                switch (str)
                {
                    case "id": ID = value; break;
                    case "name": Name = value; break;

                    default:
                        break;
                }
            }
            get
            {
                switch (str)
                {
                    case "id": return ID; break;
                    case "name": return Name; break;
                    default: return null; break;

                }

                //}
            }

        }
    }
    class GTHEmployee:Employee
    {
       override  public string this[string str]
        {
            set
            {

            }
            get
            {
                return "";
            }
        }
    }
}
