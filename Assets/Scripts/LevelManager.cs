using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private float currentTime;
    private float timer = 300;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI dialogueText;

    OutlineOnLook outline;

    private bool gotDressed = false;
    private bool brushedTeeth = false;
    private bool ateFood = false;
    private bool wateredPlant = false;
    private bool savedCat = false;
    public bool gotWater = false;
    private bool gotLightbulb = false;


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

    public void GotDressed()
    {
        gotDressed = true;
        Debug.Log(message: ("Got dressed"));
    }

    public void BrushedTeeth()
    {
        brushedTeeth = true;
        Debug.Log(message: ("Brushed teeth"));
    }
    public void AteFood()
    {
        ateFood = true;
        Debug.Log(message: ("Ate food"));
    }

    public void WateredPlant()
    {
        if (!gotWater)
            dialogueText.text = "I need some water first!";
        else
        {
            wateredPlant = true;
            Debug.Log(message: ("Watered plant"));
        }
    }

    public void SavedCat()
    {
        savedCat = true;
        Debug.Log(message: ("Saved cat"));
    }

    public void CheckedFridge()
    {
        dialogueText.text = "No food here, it's empty :/";
    }

    public void GotLightbulb()
    {
        gotLightbulb = true;
        dialogueText.text = "I'll just take this lightbulb with me";
        Debug.Log(message: ("Got lightbulb"));
    }

    public void GotWater()
    {
        gotWater = true;
        dialogueText.text = "Let me get a glass of water";
        Debug.Log(message: ("Got water"));
    }
}
