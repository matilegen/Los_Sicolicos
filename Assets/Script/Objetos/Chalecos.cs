using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chalecos : MonoBehaviour
{  
    public double defensa;
    public double reduccionMovimiento;
    public double visibilidad;
    public double esquivarBalas;
    public double estabilidad;
    public double peso;
    public double movimientoReducido;

    //funciones
    double reduccionDeMovimiento(){
        return  movimientoReducido+(peso/2);
    }
    double defensaTotal(){
        return defensa+(movimientoReducido/2);
    }
    
}
