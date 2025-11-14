using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Gallery
    {
        private List<Car> cars = new List<Car>();
        private List<Bicycle> bicycles = new List<Bicycle>();

        public void AddCar(Car car)
        {
            cars.Add(car);

        }
        public void AddBicycle(Bicycle bicycle)
        {
            bicycles.Add(bicycle);
        }

        public List<Car> FilterCar(string brand)
        {
            return cars.FindAll(c => c.Brand == brand);
        }
        public List<Car> FilterCar(double mile)
        {
            return cars.FindAll(c => c.Mile == mile);
        }

        public List<Car> FilterBicycle(string brand)
        {
            return cars.FindAll(b => b.Brand == brand);
        }
        public List<Car> FilterBicycle(double mile)
        {
            return cars.FindAll(b => b.Mile == mile);
        }

        public void ShowAllCars()
        {
            foreach (var car in cars)
            {
                car.ShowFullInfo();
            }
        }

        public void ShowAllBicycles()
        {
            foreach (var bicycle in bicycles)
            {
                bicycle.ShowFullInfo();
            }
        }
    }
}
