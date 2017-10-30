using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeliculasAPI.Models
{
    public class Pelicula
    {
        #region Properties
        public Int32 Id_Pelicula { get; set; }
        public string NombrePelicula { get; set; }
        public DateTime Estreno { get; set; }
        public int Categoria { get; set; }
        public int Clasificacion { get; set; }
        public int Rating { get; set; }
        public int Perfil { get; set; }
        public int MyProperty { get; set; }
        public string Sinopsis { get; set; }
        #endregion

        public Pelicula() { }

        public Pelicula(string NombrePelicula, int ID)
        {
            try
            {
                Data.PeliculasDBTableAdapters.sp_SelectPeliculasTableAdapter adapter = new Data.PeliculasDBTableAdapters.sp_SelectPeliculasTableAdapter();
                Data.PeliculasDB.sp_SelectPeliculasDataTable dt = adapter.SelectPelicula(NombrePelicula, ID);

                foreach (var item in dt)
                {
                    
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
  