using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeliculasAPI.Data;

namespace PeliculasAPI.Models
{
    public class Actor
    {
        #region Properties
        public int IdActor { get; set; }
        public string NombreActor { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Nacionalidad { get; set; }
        public string Perfil { get; set; }
        public string Biografia { get; set; }
        #endregion


        public Actor() { }

        public Actor(string Nombre)
        {
            try
            {
                Data.PeliculasDBTableAdapters.sp_SelectActoresTableAdapter adapter = new Data.PeliculasDBTableAdapters.sp_SelectActoresTableAdapter();
                Data.PeliculasDB.sp_SelectActoresDataTable dt = adapter.SelectActor(Nombre);

                foreach (var item in dt)
                {
                    Console.WriteLine(NombreActor, FechaNacimiento, Nacionalidad, Biografia);
                };


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}