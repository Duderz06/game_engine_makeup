using System.Collections;
using UnityEngine;

public class RandomMover : MovementParent
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();

        StartCoroutine(DoThing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator DoThing() {


        while (true) {


            int num = Random.Range(0, 4);

            if (num == 0)
            {

                MoveUp();

            }

            else if (num == 1) {

                MoveDown();

            }

            else if (num == 2)
            {

                MoveLeft();

            }

            else if (num == 3)
            {

                MoveRight();

            }


            yield return null;
        }
    
    
    }

}
