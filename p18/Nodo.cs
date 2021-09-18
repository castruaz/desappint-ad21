using System.Collections.Generic;

namespace p17_repasopoo
{
    public class Nodo {

        public Nodo() => vulnerabilidades = new List<Vulnerabilidad>();

        public Nodo(string pip,string ptipo,int ppuertos,int psaltos,string pso) : this() =>
            (ip,tipo,puertos,saltos,so) = (pip,ptipo,ppuertos,psaltos,pso);

        public string ip {get;  set;}
        public string tipo {get;  set;}
        public int puertos {get;  set;}
        public int saltos {get;  set;}
        public string so {get;  set;}
        public List<Vulnerabilidad> vulnerabilidades {get;  set;}

        public void AgregarVulnerabilidad(Vulnerabilidad v) => vulnerabilidades.Add(v);

        public override string ToString() => 
                $"Ip: {ip} Tipo: {tipo} Puertos: {puertos} Saltos: {saltos} So: {so}";
    }

}