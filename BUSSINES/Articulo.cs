using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUSSINES
{
    public class Articulo
    {
        public static Articulo ObtenerArticulo()
        {
            Articulo obj_articulo = new Articulo();

            return obj_articulo;
        }
        public static MODEL.Articulo PopulateArticulo(DataRow dr_articulo)
        {
            MODEL.Articulo obj_articulo = new MODEL.Articulo();

            obj_articulo.NOMBRE_ARTICULO = (string)dr_articulo["NOMBRE_ARTICULO"];

            return obj_articulo;
        }
        public static List<MODEL.Articulo> ObtenerArticulos()
        {

            DataTable dt_articulos = DATA.Articulo.ObtenerArticulos();

            List<MODEL.Articulo> lst_articulos = new List<MODEL.Articulo>();

            foreach (DataRow dr_articulo in dt_articulos.Rows)
            {
                MODEL.Articulo obj_articulo = PopulateArticulo(dr_articulo);

                lst_articulos.Add(obj_articulo);

            }


            return lst_articulos;
        }
    }
}
