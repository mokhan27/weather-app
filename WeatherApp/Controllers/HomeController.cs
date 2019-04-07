using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            CityIndex city = new CityIndex();

            //Send the dummy model to view, we will select value from view that will be posted back on another action with Post
            return View(city);
        }
        
        [HttpPost]
        public IActionResult Index(string city)
        {
            //we got city value from view. User sent city value. ex. Hoffman Estates.

            //get the latitude and longitude from google api.
            //initiate class
            GetLatAndLong position = new GetLatAndLong();

            //get the position of the city, we will use this position to call openweather app api.
            var latAndLong = position.GetPosition(city).ToList();

            //Add refrence to the other classes which we are going to use in next if condition
            //no need to initiate the class becuase we are going to assign value to its property
            Weather val;
            List<Weather> ret;
            CityIndex model;

            //we will check if the lat and long has some value in it
            if(latAndLong.Count > 0)
            {
                //get the data from openweather app api using lat and long from previous function call.
                //no need of instanciating class again since we initiated earlier.
                ret = position.GetData(latAndLong.FirstOrDefault());


                //we will check to see if the data returned is valid or not
                if (ret != null)
                {
                    //if it is a valid value this code will be executed.
                    //we will select the first or default values from the ret variable.
                    val = ret.FirstOrDefault();

                    //assing the value to model to send to the ui
                    model = new CityIndex
                    {
                        City = city,
                        TempC = val.temp.ToString(),
                        TempF = (Convert.ToDouble(val.temp) * 9 / 5 + 32).ToString(),
                        Day = DateTime.Now.ToString(),
                        Desc = val.desc,
                        SymbolId = val.symbol
                    };

                }
                else
                {
                    model = new CityIndex
                    {
                        City = city,
                        TempC = null,
                        TempF = null,
                        Day = DateTime.Now.ToString()
                    };

                }
            }
            else
            {
                model = new CityIndex
                {
                    City = city,
                    TempC = null,
                    TempF = null,
                    Day = DateTime.Now.ToString()
                };
            }
            return View(model);
        }

    }
}
