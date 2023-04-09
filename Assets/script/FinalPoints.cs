using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalPoints : MonoBehaviour
{
    // saco el ultimo numero del script del score
    private TextMeshProUGUI Points;

    void Start()
    {
        Points = GetComponent<TextMeshProUGUI>();

        // me pone el ultimo numero registrado de la anterior escena el cual especifique que no borrase en el CountManager
        Points.text = " " + CountManager.lastCount.ToString();
    }
}
