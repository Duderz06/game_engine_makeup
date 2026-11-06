using UnityEngine;

public class PLayerMovement : MovementParent
{

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)) {


            MoveUp();
        
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            MoveLeft();

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            MoveDown();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            MoveRight();

        }




    }



}
