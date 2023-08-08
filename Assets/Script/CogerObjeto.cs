using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
public class CogerObjeto : MonoBehaviour
{
    public GameObject handPoint;
    private GameObject pickedObject=null;
    private void private void OnTriggerStay(Collider other) {
        if (other.GameObject.CompareTag("Objeto")){
            if(Input.GetKey("e") && pickedObject==null){
                other.GetComponent<RigidBody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.GameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(pickedObject!=null){
            if(Input.GetKey("r")){
                pickedObject.GetComponent<RigidBody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
            }
       } 
    }
}