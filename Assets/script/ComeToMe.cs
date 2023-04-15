using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComeToMe : MonoBehaviour
{

    private float scrollSpeed = 8f;

    

    // los bloques vienen a mi
    void Update()
    {
        transform.Translate(Vector3.back * scrollSpeed * Time.deltaTime);

    }

    

}
