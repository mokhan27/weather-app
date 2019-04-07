using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace WeatherApp.Models
{
    public class GetLatAndLong
    {
        public IEnumerable<Position> GetPosition(string city)
        {
            //to get the weather info we need Latitude and Longtitude.
            //we will call google api to get info from city name
            string rawJson = string.Empty;
            string requestUriString = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&sensor=false&key={1}", city, "AIzaSyAz9-quwX-Vt3Qzj8te3DJML2MpQZqLmf0");
            
            //create webrequest using the url defined earlier
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);

            //calling get endpoint of Google API.
            //docs example : https://developers.google.com/maps/documentation/geocoding/start
            request.Method = "GET";

            //read the response from the google api as json object and get more info on city
            using (WebResponse response = request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                rawJson = reader.ReadToEnd();
            }


            //we will parse json object and read the required values
            var json = JObject.Parse(rawJson);

            //response will be in below format.
            //            {
            //                "results" : [
            //                   {
            //         "address_components" : [
            //                         {
            //               "long_name" : "277",
            //                            "short_name" : "277",
            //                            "types" : [ "street_number" ]
            //    },
            //            {
            //               "long_name" : "Bedford Avenue",
            //               "short_name" : "Bedford Ave",
            //               "types" : [ "route" ]
            //},
            //            {
            //               "long_name" : "Williamsburg",
            //               "short_name" : "Williamsburg",
            //               "types" : [ "neighborhood", "political" ]
            //            },
            //            {
            //               "long_name" : "Brooklyn",
            //               "short_name" : "Brooklyn",
            //               "types" : [ "sublocality", "political" ]
            //            },
            //            {
            //               "long_name" : "Kings",
            //               "short_name" : "Kings",
            //               "types" : [ "administrative_area_level_2", "political" ]
            //            },
            //            {
            //               "long_name" : "New York",
            //               "short_name" : "NY",
            //               "types" : [ "administrative_area_level_1", "political" ]
            //            },
            //            {
            //               "long_name" : "United States",
            //               "short_name" : "US",
            //               "types" : [ "country", "political" ]
            //            },
            //            {
            //               "long_name" : "11211",
            //               "short_name" : "11211",
            //               "types" : [ "postal_code" ]
            //            }
            //         ],
            //         "formatted_address" : "277 Bedford Avenue, Brooklyn, NY 11211, USA",
            //         "geometry" : {
            //            "location" : {
            //               "lat" : 40.714232,
            //               "lng" : -73.9612889
            //            },
            //            "location_type" : "ROOFTOP",
            //            "viewport" : {
            //               "northeast" : {
            //                  "lat" : 40.7155809802915,
            //                  "lng" : -73.9599399197085
            //               },
            //               "southwest" : {
            //                  "lat" : 40.7128830197085,
            //                  "lng" : -73.96263788029151
            //               }
            //            }
            //         },
            //         "place_id" : "ChIJd8BlQ2BZwokRAFUEcm_qrcA",
            //         "types" : [ "street_address" ]
            //      },
            
            //   ... Additional results truncated in this example[] ...
            
            //   ],
            //   "status" : "OK"
            //}

            //we will read the result and required values from the above json object
            var results = json["results"];
            var positions = new List<Position>();
            for (int i = 0; i < results.Count(); i++)
            {
                var address = (string)results[i]["formatted_address"];
                var lat = (double)results[i]["geometry"]["location"]["lat"];
                var lng = (double)results[i]["geometry"]["location"]["lng"];
                positions.Add(new Position(city, address, lat, lng));
            }

            return positions;

        }
        public List<Weather> GetData(Position position)
        {
            //call open weather map api to get weather info
            //example https://openweathermap.org/api
            var requestUriString = String.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&APPID=5a706bb81def2c43bf3b4b82baad0243", position.Latitude, position.Longitude);
            var weathers = new List<Weather>();
            var rawJson = String.Empty;
            HttpWebResponse response = null;

            var request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.Method = "GET";
            try
            {
                using (response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    rawJson = reader.ReadToEnd();
                }

                DateTime today = DateTime.Now;

                var item = JObject.Parse(rawJson);
                
                var temp = (double)item["main"]["temp"];
                var symbol = (string)item["weather"][0]["icon"];
                var desc = (string)item["weather"][0]["description"];

                var weather = new Weather
                {
                    desc = desc,
                    time = DateTime.Now,
                    temp = temp,
                    symbol = symbol
                };


                weathers.Add(weather);
                today = today.AddDays(1);

            }
            catch (WebException e)
            {
                weathers = null;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return weathers;
        }
    }
}
