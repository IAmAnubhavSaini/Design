using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var measurementDictionary = new Dictionary<string, LinearQuantity>
            {
                {"Inch", new LinearQuantity(1.0, "Inch")},
                {"Foot", new LinearQuantity(12.0, "Inch")},
                {"Meter", new LinearQuantity(40.0, "Inch")}
            };

            var q = new LinearQuantity(24.0, "Inch");
            
            Console.Write(q.Value + " "+ q.Unit +" = ");
            q = q.Convert("Foot", measurementDictionary);
            Console.WriteLine(q.Value + " "+ q.Unit);

            Console.Write(q.Value + " " + q.Unit + " = ");
            q = q.Convert("Meter", measurementDictionary);
            Console.WriteLine(q.Value + " " + q.Unit);
        }
    }


    
    public class LinearQuantity
    {
        public double Value { get; private set; }
        public string Unit { get; private set; }

        public LinearQuantity(double value, string unit)
        {
            Value = value;
            Unit = unit;
        }

        public LinearQuantity Convert(string required, Dictionary<string, LinearQuantity> conversionMap)
        {
            if (!conversionMap.ContainsKey(Unit) || !conversionMap.ContainsKey(this.Unit))
            {
                throw  new InvalidDataException("Data not provided! Cannot convert.");
            }
            var currentToCommonValue = conversionMap[Unit].Value;
            var requiredToCommonValue = conversionMap[required].Value;

            var quantity = new LinearQuantity(Value*currentToCommonValue/requiredToCommonValue, required);
            return quantity;
        }
    }

    public class TempratureQuantity
    {
        public double Value { get; private set; }
        public string Unit { get; private set; }

        public TempratureQuantity Convert(string required /*, pass delegated function for formula */)
        {
            return null;
        }
    } 

}


