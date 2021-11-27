using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private bool canMove;

    [SerializeField] protected float speed;

    [SerializeField] protected float upperLimit;
    [SerializeField] protected float lowerLimit;

    private LevelMenuManager levelMenu;

    // Start is called before the first frame update
    void Start()
    {
        levelMenu = FindObjectOfType<LevelMenuManager>().GetComponent<LevelMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            ObjectMove(upperLimit, lowerLimit, speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        Debug.Log("You Lost");
        collision.gameObject.GetComponent<Player>().SetInActive();
        levelMenu.ActivateRestartUI();//replace with menu once it is made
    }
    public virtual void ObjectMove(float upperLimit, float lowerLimit,float speed)
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, upperLimit), new Vector3(transform.position.x, transform.position.y, lowerLimit), (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
