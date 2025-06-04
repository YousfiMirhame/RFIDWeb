using Microsoft.AspNetCore.Mvc;
using RFIDWeb.Models;
using System;

namespace RFIDWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string id)
        {
            var user = GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        private User GetUserById(string id)
        {
            // Simulation statique
            switch (id)
            {
                case "12345678":
                    return new User
                    {
                        Id = "12345678",
                        Nom = "TherTHERMOTEX NAGEL GmbHmotex",
                        Adresse = "Schutterstraße 14, 77746 Schutterwald, Allemagne",
                        DateNaissance = new DateTime(2015, 1, 15),
                        Photo = "/images/photo1.jpg",
                        Description = "THERMOTEX positioniert sich als führendes Unternehmen im Bereich der Wäscheverwaltung und Textilkennzeichnung und bietet innovative und nachhaltige Lösungen, die auf die spezifischen Anforderungen verschiedenster Branchen zugeschnitten sind."
                    };

                case "87654321":
                    return new User
                    {
                        Id = "87654321",
                        Nom = "Aidouni Sofiane",
                        Adresse = "Königstrasse 22, Offenburg",
                        DateNaissance = new DateTime(1992, 1, 31),
                        Photo = "/images/photo2.jpg",
                        Description = "Employée chez THERMOTEX NAGEL GmbH."
                    };

                case "11112222":
                    return new User
                    {
                        Id = "11112222",
                        Description = "Herzlich willkommen",
                        Audio = "/audio/warning.mp3"
                    };

                default: return null;
            }
        }
    }
}
