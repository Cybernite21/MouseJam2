using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if((transform.GetChild(i).transform.position.x < GameObject.FindGameObjectWithTag("Player").transform.position.x)
                && Mathf.Abs(transform.GetChild(i).transform.position.x - GameObject.FindGameObjectWithTag("Player").transform.position.x) > 5.3f)
            {
                transform.GetChild(i).transform.position = new Vector3(
                    transform.GetChild(i).transform.position.x + 4.81f*3
                    , 0, 0.1f);
            }
        }
    }
}
