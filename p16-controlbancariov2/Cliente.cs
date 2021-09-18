using System.Collections.Generic;

namespace p15_controlbancario
{
    public class Cliente {
        public Cliente(string nombre, string apeido) {
            this.nombre=nombre;
            this.apeido=apeido;
            cuentas = new List<CuentaBancaria>();
        }
        public string nombre {get; private set;}
        public string apeido {get; private set;}
        public List<CuentaBancaria> cuentas {get; private set;}

        public void AgregarCuenta(CuentaBancaria cta) {
            cuentas.Add(cta);
        }
    }

}