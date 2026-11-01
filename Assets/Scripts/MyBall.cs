using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    // 실제 물리적인 충돌로 발생하는 이벤트
    void OnCollisionEnter(Collision collision) { }
    void OnCollisionStay(Collision collision) { }
    void OnCollisionExit(Collision collision) { }

    // 콜라이더 충돌로 발생하는 이벤트
    void OnTriggerEnter(Collider other) { }
    //void OnTriggerStay(Collider other) { }
    void OnTriggerExit(Collider other) { }
}