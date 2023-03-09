using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibreri.DataAccess
{
    public class CarDAO
    {
        private static CarDAO instance = null;

        private static readonly object instanceLock = new object();

        private CarDAO() { }
        public static CarDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDAO();
                    }
                    return instance;
                }

            }
        }

        private MyStockCarContext GetContext()
        {
            MyStockCarContext CarContext = null;
            try
            {
                CarContext = new MyStockCarContext();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return CarContext;
        }

        

        public IEnumerable<Car> GetCarList()
        {
            var cars = new List<Car>();
            cars = GetContext().Cars.ToList();
            return cars;
        }

        public Car GetCarByID(int carID)
        {
            Car car = null;
            try
            {
                car = GetContext().Cars.SingleOrDefault(car => car.CarId == carID);
                
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return car;

        }

        public void AddNew(Car car)
        {
            Car newCar = GetCarByID(car.CarId);
            if (newCar == null)
            {
                GetContext().Cars.Add(newCar);
                GetContext().SaveChanges();
            } else {
                throw new Exception("The car is already exist. ");
            }
        }

        public void Update(Car car)
        {
            Car newCar = GetCarByID(car.CarId);
            if (newCar != null ) { 
                GetContext().Cars.Update(newCar);
                GetContext().SaveChanges();
            }
            else
            {
                throw new Exception("The car is not exist. ");
            }
        }

        public void Delete(int carID)
        {
            Car newCar = GetCarByID(carID);
            if (newCar != null)
            {
                GetContext().Cars.Remove(newCar);
                GetContext().SaveChanges();
            }
            else
            {
                throw new Exception("The car is not exist. ");
            }
        }
    }
}
