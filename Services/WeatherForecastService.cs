using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVueStarter.Models.Request;
using AspNetCoreVueStarter.Models;


namespace AspNetCoreVueStarter.Services
{
    public class WeatherForecastService
    {
        //public class WeatherForecast
        //{
        //    public string DateFormatted { get; set; }
        //    public int TemperatureC { get; set; }
        //    public string Summary { get; set; }

        //    public int TemperatureF
        //    {
        //        get
        //        {
        //            return 32 + (int)(TemperatureC / 0.5556);
        //        }
        //    }
        //}
        public List<WeatherSummaries> getDBSummaries()
        {
            var response = new List<WeatherSummaries>();
            using (var db = new coreDBContext())
            {
                var summaryQuery = db.WeatherSummaries.AsQueryable();

                response = summaryQuery.ToList();
            }
            return response;
        }

        internal IEnumerable<WeatherForecast> getdata()
        {
            //var response = new List<WeatherSummaries>();
            var listSummaries = new List<WeatherForecast>();
            var Summaries = getDBSummaries();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),//.ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Count)].Summary
            }).ToArray();
        }
        internal IEnumerable<WeatherForecast> TestGet()
        {
            //var response = new List<WeatherSummaries>();
            var listSummaries = new List<WeatherForecast>();
            var Summaries = getDBSummaries();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),//.ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Count)].Summary
            }).ToArray();
        }
        //internal object uploadWeatherForcasts(WeatherForecastRequest postRequest)
        //{
        //    DateTime enteredDate = DateTime.Parse(postRequest.DateFormatted);
        //    var test = postRequest;
        //    WeatherForecasts weather = new WeatherForecasts
        //    {
        //        DateFormatted = enteredDate,
        //        Temperature = postRequest.TemperatureF,
        //        Summary = postRequest.Summary

        //    };

        //    using (var db = new coreDBContext())
        //    {
        //        WeatherForecast wf = new WeatherForecast();
        //        db.WeatherForecasts.Add(weather);
        //        db.SaveChanges();
        //        return true;
        //    }
        //}
    }
}
