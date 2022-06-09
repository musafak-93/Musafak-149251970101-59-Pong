using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;

    // Update is called once per frame

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    /*    void Update()
        {
            transform.Translate(speed * Time.deltaTime);
        }*/
}
