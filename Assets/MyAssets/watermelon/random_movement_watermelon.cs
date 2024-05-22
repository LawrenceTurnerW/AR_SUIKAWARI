using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // リセット地点


    void Start()
    {


        int rnd = Random.Range(-10, 10);
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(rnd, rnd, rnd) * 5, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        int rnd = Random.Range(-10, 10);
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(rnd, rnd, rnd) * 1, ForceMode.Force);
    }
}
