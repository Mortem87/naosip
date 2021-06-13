using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Articulo
    {
        public string ARTICULO_ID { get; set; }
        public string NOMBRE_ARTICULO { get; set; }
        public string NOMBRE_LINEA { get; set; }
        public string CLAVE_ARTICULO { get; set; }
        public static void GetProducts()
        {
            string sql =
@"
SELECT 
A.ARTICULO_ID, 
A.NOMBRE AS NOMBRE_ARTICULO, 
L.NOMBRE AS NOMBRE_LINEA, 
C.CLAVE_ARTICULO, 
A.UNIDAD_VENTA, 
A.UNIDAD_COMPRA, 
I.PCTJE_IMPUESTO
FROM ARTICULOS A 
LEFT JOIN CLAVES_ARTICULOS AS C ON (A.ARTICULO_ID=C.ARTICULO_ID)
LEFT JOIN LIBRES_ARTICULOS AS LA ON (A.ARTICULO_ID=LA.ARTICULO_ID)
LEFT JOIN LINEAS_ARTICULOS AS L ON (A.LINEA_ARTICULO_ID=L.LINEA_ARTICULO_ID) 
LEFT JOIN 
( 
SELECT 
IA.ARTICULO_ID, 
PCTJE_IMPUESTO 
FROM IMPUESTOS_ARTICULOS AS IA 
INNER JOIN IMPUESTOS AS I 
ON (IA.IMPUESTO_ID=I.IMPUESTO_ID AND I.TIPO_IVA IN (1,2,3)) 
)I ON (A.ARTICULO_ID=I.ARTICULO_ID)
;";

        }
    }
}
