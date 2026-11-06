using UnityEngine;

public class DestoryThing : MonoBehaviour
{

    public void Kill() {


        Destroy(gameObject);
    
    
    }

    public void Kill(GameObject obj)
    {


        Destroy(obj);


    }

}
