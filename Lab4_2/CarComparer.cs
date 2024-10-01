using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class CarComparer : IComparer<Car>
    {
        string sort_by;

        public CarComparer(string sort_by)
        {
            this.sort_by = sort_by;
        }
        public int Compare(Car A, Car B)
        {
            switch (sort_by)
            {
                case "Name":

                    /*for(int i = 1; i < cars.Length; ++i)
                    {
                        for (int j = 0; j < cars.Length - i; ++j)
                        {
                            for (int k = 0; k < Math.Min(cars[i - 1].Name.
                                Length, cars[j].Name.Length); ++k)
                            {
                                if (cars[j - 1].Name[k] < cars[j].Name[k])
                                {
                                    Car cur_car = cars[j - 1];
                                    cars[j - 1] = cars[j];
                                    cars[j] = cur_car;
                                    break;
                                }
                            }
                        }
                    }*/
                    return string.Compare(A.Name, B.Name);
                case "ProductionYear":
                    return A.ProductionYear.CompareTo(B.ProductionYear);
                case "MaxSpeed":
                    return A.MaxSpeed.CompareTo(B.MaxSpeed);
                default:
                    throw new ArgumentException("Error");
            }
        }
    }
}
