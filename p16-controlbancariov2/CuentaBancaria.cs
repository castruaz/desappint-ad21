namespace p15_controlbancario
{
    public class CuentaBancaria {
        public CuentaBancaria() {}
        public CuentaBancaria(float saldo) {
            this.saldo = saldo;
        }
        public float saldo {get; protected set;}
        public void deposita(float cantidad) {
            saldo += cantidad;
        }
        public virtual bool retira(float cantidad) {
            if(cantidad<=saldo) {
                saldo-=cantidad;
                return true;
            }
            else return false;
        }
    }
}