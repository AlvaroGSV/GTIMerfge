using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class inventario
    {
        int idProduto, idCategoria, capacidadMG;
        float altura, ancho, largo;
        string marca, tipoPuerto;

        inventario(int IdProduc, int IdCategory, int CapacityMG, float Altura, float Ancho, float Largo, string Marca, string TipoPuerto)
        {
            idProduto = IdProduc;
            idCategoria = IdCategory;
            capacidadMG = CapacityMG;
            altura = Altura;
            ancho = Ancho;
            largo = Largo;
            marca = Marca;
            tipoPuerto = TipoPuerto;
        }

        public int pIdProducto
        {
            get
            {
                return idProduto;
            }
            set
            {
                idProduto = value;
            }
        }

        public int pidCategoria
        {
            get
            {
                return idCategoria;
            }
            set
            {
                idCategoria = value;
            }
        }

        public float paltura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }

        public float pAncho
        {
            get
            {
                return ancho;
            }
            set
            {
                ancho = value;
            }
        }

        public float pLargo
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }

        public string pmarca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public string ptipoPuerto
        {
            get
            {
                return tipoPuerto;
            }
            set
            {
                tipoPuerto = value; 
            }
        }
    }
}
