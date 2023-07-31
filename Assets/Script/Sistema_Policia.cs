using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistema_Policia : MonoBehaviour
{
    GameObject ubicacion;
    public SistemaRecorrido objetoDestino;
    public Sistema_Armas arma=null;
    public Sistema_Chaleco chaleco=null;
    private double vidaPlayer; 
    public double valorTotalObjetosRobados=0;
    int NumeroRecorrido=0;
    string texto;
    int velocidadDeMovimiento=1;


    //funcion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position!=objetoDestino.transform.position){
            this.transform.position = Vector3.MoveTowards(transform.position,objetoDestino.transform.position,velocidadDeMovimiento*Time.deltaTime);
        }else{
            objetoDestino=objetoDestino.PuntoFinal;
        }
        //Movimiento automatico
        velocidadDeMovimiento=5;
        

    }
}
