using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : Obstacles
{
    // Start is called before the first frame update
    public override void ObjectMove(float upperLimit, float lowerLimit, float speed)
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, upperLimit, transform.position.z), new Vector3(transform.position.x, lowerLimit, transform.position.z), (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
