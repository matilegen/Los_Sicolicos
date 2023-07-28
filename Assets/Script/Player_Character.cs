using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Character : MonoBehaviour
{
//Atributos
    public Sistema_Armas arma=null;
    public Sistema_Chaleco chaleco=null;
    private double vidaPlayer; 
    public double valorTotalObjetosRobados=0;
    int NumeroRecorrido=0;
    string texto;
    // Start is called before the first frame update

//Funciones
    GameObject recorrido(){
        texto="recorrido "+NumeroRecorrido;
        GameObject objeto;
        objeto= GameObject.Find(texto);
        if(objeto!=null){
            NumeroRecorrido++;
            Debug.Log("se encontro el recorrido");
        }else{
            Debug.Log("no se encontro el recorrido");
            NumeroRecorrido=0;
        }
        return objeto;
    }
    void inicializarPersonaje(){
        //vidaPlayer=Propiedades.vida;
    }
    void objetoRobado(Sistema_ObjetosARobar objetoRobado){
        if(objetoRobado.valor>0.0){
            valorTotalObjetosRobados+=objetoRobado.valor;
        }
    }
//llamados y acciones del juego
    void Start()
    {
        inicializarPersonaje();
    }

    // Update is called once per frame
    void Update()
    {
        velocidadDeMovimiento=5;
        this.transform.position = Vector3.MoveTowards(transform.position,recorrido().transform.position,velocidadDeMovimiento);
    }
}
