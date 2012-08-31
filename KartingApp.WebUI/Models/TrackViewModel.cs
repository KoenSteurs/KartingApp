using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KartingApp.Domain.Entities;

namespace KartingApp.WebUI.Models
{
    public class TrackViewModel
    {
        public Track Track { get; set; }
        public Driver Driver { get; set; }
    }
}