using System;
namespace p17_repasopoo
{
    public class Vulnerabilidad {

        public Vulnerabilidad(string pclave,string pvendedor,string pdescripcion,string ptipo,DateTime pfecha) =>
            (clave,vendedor,descripcion,tipo,fecha) = (pclave,pvendedor,pdescripcion,ptipo,pfecha);

        public string clave {get; private set;}
        public string vendedor {get; private set;}
        public string descripcion {get; private set;}
        public string tipo {get; private set;}
        public DateTime fecha {get; private set;}
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
            $"Clave: {clave} Vendedor: {vendedor} Descripcion: {descripcion} Tipo: {tipo} " +
            $"Fecha: {fecha.ToString("dd/mm/yy")} Antiguedad: {Antiguedad.ToString()}";

    }
}