using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    //簡單用鍵盤控制移動的腳本
    public float speed = 5f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
