using IndexerDemo.indexer;

namespace IndexerDemo
{
    class cities
    {
        string[] city = new string[5];
        int x;
        String ss;
        public cities()
        {
            
        }
        public void showCities()
        {

        }
        public string this[int index]
        {
            get { return city[index]; }
            set { city[index] = value; }
        }
    }

    class studentRecord
    {
        string name;
        string age;
        string grade;
        int[] sub = new int[5];
        public int this[int index]
        {
            set 
            {
                sub[index] = value;
            }
            get { return sub[index]; }
        }
        public string this[string str]
        {
            set 
            {
                switch (str.ToLower())
                {
                    case "name":name=value; break;
                    case "age":age = value; break;
                    case "grade": grade = value; break;
                    default:
                        Console.WriteLine("Invalid property selected!!!");
                        break;
                }
            }
            get 
            {
                switch (str.ToLower())
                {
                    case "name":return name;break;
                    case "age": return age; break;
                    case "grade": return grade; break;
                    default:
                        Console.WriteLine("invalid property provided!!!");
                        return null;
                        break;
                }
            }
        }

    }
    internal class Program
    {
        public static void sum(int? x,int? y)
        {
            int? z = x + y;
            Console.WriteLine(z);
        }
        static void Main(string[] args)
        {
            //cities c = new cities();
            //Console.WriteLine("------------------");
            //sum(100, 200);
            //Console.WriteLine("------------------");
            //sum(null, null);
            //Console.WriteLine("------------------");

            //int? no = 42554;
            //int ans = no??1;
            //Console.WriteLine("ans="+ans);


            //states st = new states();
            //st[2] = "maharashtra";//set

            //string MH = st[2];//get
            //Console.WriteLine(MH);

            //st[0, 0] = 411058;
            //st[1, 0] = 413001;
            //st[2, 0] = 414001;
            //Console.WriteLine("all PINcodes are");
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(st[i,0]);
            //}
            student s1 = new student();
            s1["name"] = "rajesh";
            s1["grade"] = "A";
            s1["asdfasd"] = "A";
            Console.WriteLine(s1["name"]);//rajesh
            Console.WriteLine(s1["grade"]);//A
            Console.WriteLine(s1["grade123"]);//A
        }
    }
}
