using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IDataFormatter
    {
        void Format(Data data);
    }

    public class CSVFormatter : IDataFormatter
    {
        public void Format(Data data)
        {
            Console.WriteLine("Thi is from CSVFormatter");
        }
    }

    public class XMLFormatter : IDataFormatter
    {
        public void Format(Data data)
        {
            Console.WriteLine("Thi is from XMLFormatter");
        }
    }

    public class JSONFormatter : IDataFormatter
    {
        public void Format(Data data)
        {
            Console.WriteLine("Thi is from JSONFormatter");
        }
    }

    public class Data
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public IDataFormatter Formatter { get; set; }

        public Data(string name, string value, string type) 
        { 
            Name= name;
            Value= value;
            Type= type;
        }

        public void Format()
        {
            Formatter.Format(this);
        }
    }
}
