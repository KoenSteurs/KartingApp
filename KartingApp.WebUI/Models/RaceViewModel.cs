using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KartingApp.Domain.Entities;

namespace KartingApp.WebUI.Models
{
    public class RaceViewModel
    {
        public IQueryable<Race> Races { get; set; }
        public Track Track { get; set; }
    }
}
