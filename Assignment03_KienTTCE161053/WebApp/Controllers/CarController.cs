using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomobileLibreri.DataAccess;
using AutomobileLibreri.Repository;
using System;
using System.Runtime.ConstrainedExecution;

namespace AutomobileWebApp
{
    public class CarController : Controller
    {
        ICarRepository carRepository = null;

        public CarController() => carRepository = new CarRepository();
        // GET: CarController
        public ActionResult Index()
        {
            var carList = carRepository.GetCarList();
            return View(carList);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if  (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
            
        

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carRepository.AddCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(car);
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carRepository.UpdateCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(car);
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carRepository.DeleteCar(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
