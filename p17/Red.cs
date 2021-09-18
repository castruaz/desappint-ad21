using System;
using System.Collections.Generic;

namespace p17 {
public class Red {

    public Red(){ nodos=new List<Nodo>();}

    public Red(string pempresa, string ppropietario, string pdomicilio) : this() =>
        (empresa, propietario, domicilio) = (pempresa, ppropietario, pdomicilio);

    public String empresa {get; private set;}
    public String propietario {get; private set;}
    public String domicilio {get; private set;}
    public List<Nodo> nodos {get; private set;}

    public void AgregarNodo(Nodo n) => nodos.Add(n);

    public int MaySal {
        get {
            int m=nodos[0].saltos;
            foreach(Nodo n in nodos)  
                if(n.saltos>m)
                    m=n.saltos;
             return m;
        }
    }

    public int MenSal { 
        get {
            int m=nodos[0].saltos;
            foreach(Nodo n in nodos)  
                if(n.saltos<m)
                    m=n.saltos;
            return m;
        }
    }

    public int TotVuln { 
        get {
            int s=0;
            foreach(Nodo n in nodos)
                s+=n.vulnerabilidades.Count;
             return s;
        }
    }
    
}

}