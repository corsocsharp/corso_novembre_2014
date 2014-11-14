﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcContatti.Models
{
    public class DBService
    {
        private List<Contatto> _dbContatti;

        /// <summary>
        /// Costruttore, chiamato automaticamente quando 
        /// viene fatto il new di un nuovo dbservice
        /// </summary>
        public DBService() {
            _dbContatti = new List<Contatto>();

            Contatto c = new Contatto();
            c.Id = "1";
            c.Nome = "Gigi";
            c.Cognome = "Lucchetti";
            c.Indirizzo = "Via lontano 23";
            c.Email = "g.l@qualcosa.com";
            c.Telefono = "2323432";
            _dbContatti.Add(c);

            c = new Contatto(){
                Id = "2",
                Nome = "Pippo",
                Cognome = "Disney",
                Indirizzo = "...",
                Email = "pippo@disney.com"
            };
            _dbContatti.Add(c);

            c = new Contatto()
            {
                Id = "3",
                Nome = "Pluto",
                Cognome = "Disney",
                Indirizzo = "...",
                Email = "pluto@disney.com"
            };
            _dbContatti.Add(c);

            c = new Contatto()
            {
                Id = "4",
                Nome = "Paperino",
                Cognome = "Disney",
                Indirizzo = "...",
                Email = "paperino@disney.com"
            };
            _dbContatti.Add(c);

        }


        public List<Contatto> ListContatti() {
            return _dbContatti;
        }
    }
}