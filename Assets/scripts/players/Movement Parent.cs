using UnityEngine;

public class MovementParent : MonoBehaviour
{


    public Rigidbody RB;
    public float Speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }





    public void MoveUp() {

        RB.linearVelocity = new Vector3(0, Speed, 0);




    }



    public void MoveDown()
    {

        RB.linearVelocity = new Vector3(0, -Speed, 0);




    }

    public void MoveLeft() {

        RB.linearVelocity = new Vector3(-Speed, 0, 0);


    }


    public void MoveRight()
    {

        RB.linearVelocity = new Vector3(Speed, 0, 0);




    }






}
