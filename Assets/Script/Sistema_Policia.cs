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
    string texto;
    int velocidadDeMovimiento=1;


    float velocidadRotacion=1;
    int tiempoReaccion,movimiento;
    bool espera, caminar, gira;
    GameObject enemigo=null;
    //atributos de movimiento
    Vector3 m_Movement;
    Rigidbody m_Rigidbody;
    Animator m_Animator;
    [SerializeField]
    float turnSpeed=20f;
    Quaternion m_Rotation=Quaternion.identity;

    GameObject target=null;
    //funcion
        void deteccion(){
            buscarPlayer();
            if(target!=null){
                espera=true;
                caminar=false;
                gira=false;
            }else{
                caminar=true;
                espera=false;
            }
        }
        void buscarPlayer(){
            enemigo=GameObject.FindWithTag("Player");
        }
    // Start is called before the first frame update
    void Start()
    {
         m_Rigidbody = GetComponent<Rigidbody>();
        m_Animator  = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        deteccion();
        if(enemigo!=null){
        if(espera){
            GetComponent<Animator>().SetBool("Caminar",false);
            espera=false;
            caminar=true;
            gira=false;
        }
        if(caminar){
            buscarPlayer();
             if(transform.position!=objetoDestino.transform.position){
            GetComponent<Animator>().SetBool("Caminar",true);
            this.transform.position = Vector3.MoveTowards(transform.position,objetoDestino.transform.position,velocidadDeMovimiento*Time.deltaTime);
            caminar=false;
            }else{
            espera=true;
            caminar=false;
            gira=true;
            objetoDestino=objetoDestino.PuntoFinal;
            }
        }
        if(gira){
            transform.Rotate(objetoDestino.transform.position.x*velocidadRotacion*Time.deltaTime,0f,0f);
            gira=false;
            espera=true;
            caminar=false;
        }
        }
        //Movimiento automatico
        velocidadDeMovimiento=5;
    }
}
