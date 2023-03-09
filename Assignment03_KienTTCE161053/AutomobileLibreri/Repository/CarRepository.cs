using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibreri.DataAccess;

namespace AutomobileLibreri.Repository
{
    public class CarRepository : ICarRepository
    {
        public void AddCar(Car car) => CarDAO.Instance.AddNew(car);


        public void DeleteCar(int carId) => CarDAO.Instance.Delete(carId);


        public Car GetCarById(int carId) => CarDAO.Instance.GetCarByID(carId);



        public IEnumerable<Car> GetCarList() => CarDAO.Instance.GetCarList();


        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);

    }
}
