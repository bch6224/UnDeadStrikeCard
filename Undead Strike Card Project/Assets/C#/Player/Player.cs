using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        MoveMent();
    }

    private void MoveMent()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, 0) * Time.deltaTime;
    }
}
