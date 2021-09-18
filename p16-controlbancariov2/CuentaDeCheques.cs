
namespace p15_controlbancario
{
    public class CuentaDeCheques : CuentaBancaria {

        public CuentaDeCheques(float saldo, float sobregiro) : base(saldo) {
            this.sobregiro = sobregiro;
        }

        public float sobregiro {get; protected set;}

        public override bool retira(float cantidad) {
            float requerida = cantidad - saldo;
            if(sobregiro<requerida) {
                return false;
            } else {
                saldo=0.0f;
                sobregiro=-requerida;
            }
            return true;
        }
    }
}