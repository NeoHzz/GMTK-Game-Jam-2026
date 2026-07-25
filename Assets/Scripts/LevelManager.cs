using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private float currentTime;
    private float timer = 300;
    [SerializeField] private TextMeshProUGUI timerText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = Time.deltaTime / 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= currentTime;
        timerText.text = $"{timer:#0.00}";
    }
}
