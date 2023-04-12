using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMoveON : MonoBehaviour
{
    public float SpeedX;
    public float SpeedY;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //para poder scrolear la textura main
        meshRenderer.material.mainTextureOffset = new Vector2(Time.realtimeSinceStartup * SpeedX, Time.realtimeSinceStartup * SpeedY);
    }
}
