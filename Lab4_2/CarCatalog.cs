using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lab4_3

namespace Lab4_2
{
    public class CarCatalog : IEnumerator<Car>
    {
        Car[] catalog;

        public CarCatalog(Car[] cars)
        {
            catalog = cars;
        }

        public Car Current => throw new NotImplementedException(); //

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Car> GetEnumerator() 
        {
            for (int i = 0; i < catalog.Length; i++)
            {
                yield return catalog[i];
            }
        }

        public IEnumerable<Car> GetEnumeratorReverse()
        {
            for (int i = catalog.Length - 1; i >= 0; --i)
            {
                yield return catalog[i];
            }
        }

        public IEnumerable<Car> FilterByMaxSpeed(int speed)
        {
            for (int i = catalog.Length - 1; i >= 0; --i)
            {
                if (catalog[i].MaxSpeed >= speed)
                {
                    yield return catalog[i];
                }
            }
        }

        public IEnumerable<Car> FilterByYear(int year)
        {
            for (int i = catalog.Length - 1; i >= 0; --i)
            {
                if (catalog[i].MaxSpeed <= year)
                {
                    yield return catalog[i];
                }
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
