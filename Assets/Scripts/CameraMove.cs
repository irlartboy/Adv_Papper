using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject follow;

    public float speed = 4.0f;

    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, follow.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, follow.transform.position.x, interpolation);

        this.transform.position = position;
    }
}
