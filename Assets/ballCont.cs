using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCont : MonoBehaviour
{
    private Rigidbody2D rigidb2D;

    [SerializeField]
    private float pacSpeed = 1;

    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector2(transform.position.x, transform.position.y);
        rigidb2D = GetComponent<Rigidbody2D>();
        rigidb2D.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.position = new Vector3(transform.position.x + pacSpeed, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.position = new Vector3(transform.position.x - pacSpeed, transform.position.y, transform.position.z);
        }

        if(Input.GetKey("space"))
        {
            rigidb2D.isKinematic = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = startPos;
        }
    }
}
