using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class LengthUnit
    {
        public string UnitName
        {
            get { return UnitName; }
            private set { UnitName = value.ToLower(); }
        }

        public string UnitAlias
        {
            get { return UnitAlias; } 
            private set { UnitAlias = value.ToLower(); }
        }

        public LengthUnit (string unitName, string unitAlias)
        {
            UnitName = unitName;
            UnitAlias = unitAlias;
        }

        private LengthUnit BaseUnit;

        public void SetBaseUnit(LengthUnit baseUnit)
        {
            if (Object.Equals(baseUnit, null))
            {
                throw  new ArgumentNullException("baseUnit is NULL");
            }
            BaseUnit = baseUnit;
        }
        public void ConvetUnit(string , LengthUnit from)
      
    }
}
