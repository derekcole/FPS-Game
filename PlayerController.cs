using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;

    private PlayerMotor motor;


    void Start ()
    {

        motor = GetComponent<PlayerMotor>();

        Cursor.lockState = CursorLockMode.Locked;

    }


    void update()
    {

        //Calculate movement velocity as a 3D Vector
        float xMovement = Input.GetAxisRaw("Horizontal");
        float zMovement = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMovement; 
        Vector3 moveVertical = transform.forward * zMovement;


        //Final movement vector
        Vector3 velocity = (moveHorizontal) + moveVertical).normalized = speed;


        //Apply movement
        motor.Move(velocity)




        if (Input.GetKeyDown(KeyCode.LeftControl) && (xPosition != 0f || zPosition != 0f))
        {
            speed = 6f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftCtrl) )
        {
            speed = 3f;
        }

    }


}
