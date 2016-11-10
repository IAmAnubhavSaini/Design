using System;
using System.Collections.Generic;
using System.IO;

namespace MeasurementProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var measurementDictionary = new Dictionary<string, LinearQuantity>
            {
                {"Inch", new LinearQuantity(1.0, "Inch", Type.Length)},
                {"Foot", new LinearQuantity(12.0, "Inch", Type.Length)},
                {"Meter", new LinearQuantity(40.0, "Inch", Type.Length)},
                {"Pound", new LinearQuantity(453.592, "Gram", Type.Weight)},
                {"Gram", new LinearQuantity(1.0, "Gram", Type.Weight)}
            };

            var q = new LinearQuantity(24.0, "Inch", Type.Length);

            try
            {
                Console.Write(q.Value + " " + q.Unit + " = ");
                q = q.Convert("Foot", measurementDictionary);
                Console.WriteLine(q.Value + " " + q.Unit);

                Console.Write(q.Value + " " + q.Unit + " = ");
                q = q.Convert("Meter", measurementDictionary);
                Console.WriteLine(q.Value + " " + q.Unit);

                Console.Write(q.Value + " " + q.Unit + " = ");
                q = q.Convert("Pound", measurementDictionary);
                Console.WriteLine(q.Value + " " + q.Unit);
            }
            catch (InvalidDataException ide)
            {
                Console.WriteLine(ide.Message);
            }
        }
    }

    public enum Type
    {
        Length,
        Temprature,
        Volume,
        Weight
    }
    
    public class LinearQuantity
    {
        public double Value { get; private set; }
        // Unit should be class : don't allow garbage.
        public string Unit { get; private set; }
        public Type Type { get; private set; }

        public LinearQuantity(double value, string unit, Type type)
        {
            Value = value;
            Unit = unit;
            Type = type;
        }

        public LinearQuantity Convert(string toUnit, Dictionary<string, LinearQuantity> conversionMap)
        {
            if (!conversionMap.ContainsKey(Unit) || !conversionMap.ContainsKey(toUnit) || (Type != conversionMap[toUnit].Type))
            {
                throw  new InvalidDataException("Data not provided! Cannot convert.");
            }
            
            var currentToCommonValue = conversionMap[Unit].Value;
            var requiredToCommonValue = conversionMap[toUnit].Value;
            var quantity = new LinearQuantity(Value*currentToCommonValue/requiredToCommonValue, toUnit, Type);
            return quantity;
        }
    }

    

}


