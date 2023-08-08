public class entidad{
    //buscador de objetos
    public GameObject buscarObjetoPorTag(string tagABuscar){
        return GameObject.FindWithTag(tagABuscar);
    }
    //funcion para caminar automatico
    public void movimientoAutomatico(){
        if(transform.position!=objetoDestino.posicion()){
            this.transform.position = Vector3.MoveTowards(transform.position,objetoDestino.transform.position,velocidadDeMovimiento*Time.deltaTime);
        }
    }
    //funcion para agarrar objetos
    public void agarrarObjeto(Player_Character jugador){
        jugador.agregarInventario(objetoCerca())

    }
    //funcion para colicionar objetos
    public void objetoCerca(Player_Character jugador){
        jugador.private void OnCollisionEnter(Collision other) {
            if(other.gameObject.){

            }
        }
    }
}
