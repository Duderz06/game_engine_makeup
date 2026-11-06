using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SIgnleotnUITHing : MonoBehaviour
{
    public TextMeshProUGUI scorenum;

    private SIngleton s;

    private void Start()
    {

        s = SIngleton.Instance;
        StartCoroutine(s.StartScoreing());
    }


    private void Update()
    {

        scorenum.text = s.Score+"";

    }

}
