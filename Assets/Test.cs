using System.Collections;
using System.Collections.Generic;
using Ging1991.Persistencia.Lectores;
using Ging1991.Persistencia.Lectores.Directos;
using Ging1991.Relojes;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Reloj.GetInstanciaGlobal();
        LectorEntero lector = new LectorEntero("", TipoLector.RECURSOS);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
