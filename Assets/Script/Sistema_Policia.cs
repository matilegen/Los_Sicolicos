using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistema_Policia : MonoBehaviour
{
    public SistemaRecorrido objetoDestino;

        //caminar a un punto
        void movimientoAutomatico(){
            if(transform.position!=objetoDestino.posicion()){
            this.transform.position = Vector3.MoveTowards(transform.position,objetoDestino.transform.position,velocidadDeMovimiento*Time.deltaTime);
            }
        }
    void buscarPlayer(){
            enemigo=GameObject.FindWithTag("Player");
        }
        //hablar con otro npc

        //observar

        //funcion de que vio algo a lo lejos

        //funcion de ir a ver lo que vio

        //funcion de desenfundar arma

        //funcion de disparar

        //funcion de morir

        //funcion de guardar arma

        //funcion de agacharce

        
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Animator  = GetComponent<Animator>();
    }
    void Update()
    {

        movimientoAutomatico()

    }
   /* GameObject ubicacion;
    public SistemaRecorrido objetoDestino;
    public Sistema_Armas arma=null;
    public Chalecos chaleco=null;
    private double vidaPlayer; 
    public double valorTotalObjetosRobados=0;
    string texto;
    [SerializeField]
    public int velocidadDeMovimiento=5;


    float velocidadRotacion=1;
    int tiempoReaccion,movimiento;
    bool espera=true, caminar, gira;
    GameObject enemigo=null;
    public GameObject objetoGuardado=null;
    bool murio=false;
    //atributos de movimiento
    Vector3 m_Movement;
    Rigidbody m_Rigidbody;
    Animator m_Animator;
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
               Debug.Log("estoy en espera)");
            }/*
        if(caminar){
            buscarPlayer();
             if(transform.position!=objetoDestino.posicion()){
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
        /*
        //Movimiento automatico
        if(murio==true){
            Debug.Log("solto objeto");
        }
    }*/
}
