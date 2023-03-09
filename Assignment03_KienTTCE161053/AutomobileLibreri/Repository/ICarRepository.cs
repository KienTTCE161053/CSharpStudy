using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibreri.DataAccess
{
    public interface ICarRepository
    {

        public IEnumerable<Car> GetCarList();
        public Car GetCarById(int carId);
            
        public void DeleteCar(int carId);
        public void UpdateCar(Car car);
        public void AddCar (Car car);
                
    }
}
