using UnityEngine;

public class destoryotherthingontouch : MonoBehaviour
{
    private DestoryThing DT;
    private void Start()
    {
        DT = GetComponent<DestoryThing>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            DT.Kill(other.gameObject);


        }

        else {

            DT.Kill();
        
        }
    }

}
