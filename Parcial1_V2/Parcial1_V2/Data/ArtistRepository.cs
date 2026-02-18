using Parcial1_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_V2.Data
{
    public static class ArtistRepository
    {
        public static List<Album> GetAlbums() => new()
        {
        new Album { Title = "Afrodisíaco", Year = 2020, Cover = "afrodisiaco.jpg" },
        new Album { Title = "Vice Versa", Year = 2021, Cover = "viceversa.jpg" },
        new Album { Title = "Saturno", Year = 2023, Cover = "saturno.jpg" },
        new Album { Title = "Cosa Nuestra", Year = 2024, Cover = "cosanuestra.jpg" }
        };

        public static List<Tour> GetUpcomingTours() => new()
        {
        new Tour { Name = "Saturno World Tour", Location = "Miami", Date = DateTime.Now.AddMonths(1) },
        new Tour { Name = "Europa Tour", Location = "Madrid", Date = DateTime.Now.AddMonths(2) }
        };

        public static List<Tour> GetPastTours() => new()
        {
        new Tour { Name = "Vice Versa Tour", Location = "Chile", Date = new DateTime(2022, 8, 10) },
        new Tour { Name = "Saturno World Tour", Location = "México", Date = new DateTime(2023, 5, 20) }

        };
    }
}
