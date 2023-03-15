using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        mousePos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = (mousePos - transform.position).normalized;
    }

    public void OnLook(InputValue input)
    {
        mousePos = Camera.main.ScreenToWorldPoint(input.Get<Vector2>());
        mousePos.z = transform.position.z;
        print(mousePos);
    }
}
