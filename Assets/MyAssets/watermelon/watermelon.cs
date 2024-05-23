using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float span = 1f;

    void Start()
    {
        int rnd = Random.Range(-10, 10);
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(rnd, rnd, rnd) * 5, ForceMode.Force);

        StartCoroutine("Force");
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトがbatだった場合
        if (collision.gameObject.name.Contains("bat"))
        {
            Destroy(this.gameObject);
        }
    }

    // n秒ごとにランダムに外力を与える
    IEnumerator Force()
    {
        while (true)
        {
            yield return new WaitForSeconds(span);
            int rnd1 = Random.Range(5, 11);
            if (Random.Range(0, 2) == 0)
            {
                rnd1 = rnd1 * -1;
            }
            int rnd2 = Random.Range(5, 8);

            int rnd3 = Random.Range(5, 11);
            if (Random.Range(0, 2) == 0)
            {
                rnd3 = rnd3 * -1;
            }
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(rnd1, rnd2, rnd3) * 10, ForceMode.Force);
        }
    }
}
