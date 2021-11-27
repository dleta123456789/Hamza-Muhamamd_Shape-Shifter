using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody playerRb;
    [SerializeField] private List<Vector3> playerShapes = new List<Vector3>() ;
    private bool gameActive=true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameActive == true)
        {
            MoveForward();
        }
    }
    private void Update()
    {
        if (gameActive == true)
        {
            PlayerInput();
        }
    }
    void MoveForward()
    {
        playerRb.AddForce(Vector3.right * speed);
    }
    void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerTransform(playerShapes[0]);
        }
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    playerTransform(playerShapes[1]);
        //}
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerTransform(playerShapes[2]);
        }
    }
    void playerTransform(Vector3 shape)
    {
        transform.localScale = new Vector3(shape.x, shape.y, shape.z);
    }
    public void SetInActive()
    {
        gameActive = false;
    }
}
