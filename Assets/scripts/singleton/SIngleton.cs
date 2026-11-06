using UnityEngine;

public class SIngleton : MonoBehaviour
{


    public static SIngleton Instance { get; private set; }

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

}
