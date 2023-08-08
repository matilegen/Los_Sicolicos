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
    int velocidadDeMovimiento=0;

//atributos de movimiento
    Vector3 m_Movement;
    Rigidbody m_Rigidbody;
    Animator m_Animator;
    [SerializeField]
    float turnSpeed=20f;
    Quaternion m_Rotation=Quaternion.identity;
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
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Animator  = GetComponent<Animator>();
    }
    void objetoRobado(Sistema_ObjetosARobar objetoRobado){
        if(objetoRobado.valor>0.0){
            valorTotalObjetosRobados+=objetoRobado.valor;
        }
    }
//llamados y acciones del juego

//accion saltar

//agarrar objeto

//guardar objeto

//abrir inventario

//apuntar

//disparar

//agacharse

//contra la pared

//ponerse una caja

//caminar con la caja

//salir de la caja

//realizar una accion(romper vidrio o abrir caja)

//colocar objeto

//buscar en tacho

//cambiar de arma

//recargar arma

//morir
    void Start()
    {
        inicializarPersonaje();
    }

    // Update is called once per frame
    void Update()
    {   //Movimiento Player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal,0f, vertical);
        m_Movement.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal,0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical,0f);
        
        //variable Animator
        bool IsWalking=hasHorizontalInput || hasVerticalInput;
        
        m_Animator.SetBool("IsWalking", IsWalking);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime,0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
        m_Rigidbody.MovePosition(m_Rigidbody.position+m_Movement*Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rotation);
        //Movimiento automatico
        //velocidadDeMovimiento=5;
        //this.transform.position = Vector3.MoveTowards(transform.position,recorrido().transform.position,velocidadDeMovimiento);
    }
}
