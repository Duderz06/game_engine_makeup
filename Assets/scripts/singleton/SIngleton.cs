using System.Collections;
using UnityEngine;

public class SIngleton : MonoBehaviour
{


    public static SIngleton Instance { get; private set; }

    public float Score = 0;

    public virtual void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }


    public void TestMethod()
    {

        Debug.Log("it work yay");

    }

    public IEnumerator StartScoreing() {


        while (true) {

            Score++;
            yield return null;
        
        }
    
    }

}
