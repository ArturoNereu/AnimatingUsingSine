using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    private Vector3 originalTransform;

    [SerializeField]
    private float speed;
    [SerializeField]
    private float amplitude;

    // Start is called before the first frame update
    void Start()
    {
        originalTransform = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = originalTransform + new Vector3(0, Mathf.Sin(Time.time * speed) * amplitude, 0);
    }
}
