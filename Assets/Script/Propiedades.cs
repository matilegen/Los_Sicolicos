using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propiedades : MonoBehaviour
{
    public double vida=100.0;
    public GameObject objetoDesconocido=null;
    [SerializeField]
    public double velocidadMovimiento=3.0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida<0){
            Debug.Log("Estas Muerto");
        }
    }
}
