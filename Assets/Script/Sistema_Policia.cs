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


    float velocidadRotacion=1
    int tiempoReaccion,movimiento;
    bool espera, camina, gira;
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
            target=gameObject.find("mobs");
            if(target!=null){
                espera=true;
                caminar=false;
            }else{
                caminar=true;
                espera=false;
            }
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
        if(espera){
            GetComponent<Animator>().setBool("Caminar",false);
        }
        if(camina){
            GetComponent<Animator>().setBool("Caminar",true);
             if(transform.position!=objetoDestino.transform.position){
            this.transform.position = Vector3.MoveTowards(transform.position,objetoDestino.transform.position,velocidadDeMovimiento*Time.deltaTime);
            }else{
            objetoDestino=objetoDestino.PuntoFinal;
            }
        }
        if(gira){
            transform.Rotate(Vector3.up*velocidadRotacion*Time.deltaTime);
        }
       
        bool hasHorizontalInput = !Mathf.Approximately(transform.position.x,0f);
        bool hasVerticalInput = !Mathf.Approximately(transform.position.y,0f);
        //Movimiento automatico
        velocidadDeMovimiento=5;
        //variable Animator
        bool IsWalking=hasHorizontalInput || hasVerticalInput;
        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime,0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
        m_Rigidbody.MovePosition(m_Rigidbody.position+m_Movement*Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
