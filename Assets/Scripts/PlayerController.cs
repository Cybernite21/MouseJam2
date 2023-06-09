using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Transform camTarget;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        mousePos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos.x = transform.position.x + 2;
        transform.up = (mousePos - transform.position).normalized;
        transform.position += transform.up * speed * Time.deltaTime;
        camTarget.position = new Vector3(transform.position.x, 0, transform.position.z);
        
        if(transform.position.y > 2.1f)
        {
            transform.position = new Vector3(transform.position.x, 2.1f, transform.position.z);
        }
        if (transform.position.y < -2.1f)
        {
            transform.position = new Vector3(transform.position.x, -2.1f, transform.position.z);
        }

    }

    public void OnLook(InputValue input)
    {
        mousePos = Camera.main.ScreenToWorldPoint(input.Get<Vector2>());
        mousePos.z = transform.position.z;
        mousePos.x = transform.position.x + 2;
        print(mousePos);
    }
}
