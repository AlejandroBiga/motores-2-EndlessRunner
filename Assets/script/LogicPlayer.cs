using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody playerRb;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // basic move X
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizontalInput, 0f, 0f);
        Input.GetAxis("Horizontal");
    }
}
