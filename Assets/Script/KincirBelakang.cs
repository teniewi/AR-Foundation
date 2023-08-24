using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KincirBelakang : MonoBehaviour
{
    private float speed = 600.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}
