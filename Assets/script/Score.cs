using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private float count = 0f;
    private TextMeshProUGUI Points;

    public float countRate = 0.10f;

    void Start()
    {
        Points = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        count += countRate * Time.deltaTime;
        Points.text = "Your Points: " + Mathf.Round(count).ToString();

        //registra el ultimo numero de la cuenta de puntos para la pantalla de perdiste 
        CountManager.SetLastCount(Mathf.RoundToInt(count));
    }
}
