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
    [SerializeField] private GameObject player;

    OutlineOnLook outline;

    private bool gotDressed = false;
    private bool brushedTeeth = false;
    private bool ateFood = false;
    private bool wateredPlant = false;
    private bool savedCat = false;
    private bool fixedLight = false;
    private bool foodEaten = false;
    private bool flowersPicked = false;
    public bool gotWater = false;
    public bool gotLightbulb = false;


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
    public void OpenInsideDoor()
    {
        player.transform.position = new Vector3(24.42f, 1.41f, 10.75f);
    }
    public void OpenOutsideDoor()
    {
        player.transform.position = new Vector3(-15.28f, 1.41f, 46.85f);
    }

    public void OpenCafeDoor()
    {

    }

    public void FixedLight()
    {
        if (!gotLightbulb)
            dialogueText.text = "I could probably fix this with a light bulb";
        else
        {
            fixedLight = true;
            Debug.Log(message: ("Fixed light"));
        }
    }

    public void EatFood()
    {
        foodEaten = true;
        Debug.Log(message: ("Ate food"));
    }

    public void PickFlowers()
    {
        flowersPicked = true;
        Debug.Log(message: ("Picked flowers"));
    }
}
