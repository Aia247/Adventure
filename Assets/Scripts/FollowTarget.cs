using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    public Transform Hero;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Hero.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + Hero.position;
    }
}
