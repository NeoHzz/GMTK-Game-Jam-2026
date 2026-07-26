using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private float currentTime;
    [SerializeField] private float timer = 40;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ending;
    [SerializeField] private GameObject outOfTime;
    [SerializeField] private GameObject black;
    [SerializeField] private GameObject beginning;

    OutlineOnLook outline;

    [SerializeField] private GameObject outdoorObjects;
    [SerializeField] private GameObject indoorObjects;

    public bool gotDressed = false;
    public bool brushedTeeth = false;
    public bool wateredPlant = false;
    public bool savedCat = false;
    public bool fixedLight = false;
    public bool foodEaten = false;
    public bool flowersPicked = false;
    public bool showered = false;
    public bool gotWater = false;
    public bool gotLightbulb = false;
    public bool gotSoap = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = Time.deltaTime/ 20; // / 10
    }

    // Update is called once per frame
    void Update()
    {
        timer -= currentTime;
        timerText.text = $"{timer:#0.00}";

        if (timer <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            outOfTime.SetActive(true);
            black.SetActive(true);
        }
        if (timer <= 35 && beginning.activeInHierarchy)
        {
            beginning.SetActive(false);
        }
    }

    public void GotDressed()
    {
        gotDressed = true;
        dialogueText.text = "Got my clothes on, ready for the day!";
        Debug.Log(message: ("Got dressed"));
    }

    public void BrushedTeeth()
    {
        brushedTeeth = true;
        dialogueText.text = "My teeth are all shiny and clean now";
        Debug.Log(message: ("Brushed teeth"));
    }

    public void WateredPlant()
    {
        if (!gotWater)
            dialogueText.text = "I need some water first!";
        else
        {
            wateredPlant = true;
            dialogueText.text = "There you go little buddy";
            Debug.Log(message: ("Watered plant"));
        }
    }

    public void SavedCat()
    {
        savedCat = true;
        dialogueText.text = "I saved that poor cat stuck in the tree :)";
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
        outdoorObjects.SetActive(true);
        player.transform.position = new Vector3(24.42f, 1.41f, 10.75f);
        indoorObjects.SetActive(false);
    }
    public void OpenOutsideDoor()
    {
        indoorObjects.SetActive(true);
        player.transform.position = new Vector3(-15.28f, 1.41f, 46.85f);
        outdoorObjects.SetActive(false);
    }

    public void OpenCafeDoor()
    {
        ending.SetActive(true);
    }

    public void FixedLight()
    {
        if (!gotLightbulb)
            dialogueText.text = "I could probably fix this with a light bulb";
        else
        {
            fixedLight = true;
            dialogueText.text = "There we go, all fixed!";
            Debug.Log(message: ("Fixed light"));
        }
    }

    public void EatFood()
    {
        foodEaten = true;
        dialogueText.text = "That was delicious!";
        Debug.Log(message: ("Ate food"));
    }

    public void PickFlowers()
    {
        flowersPicked = true;
        dialogueText.text = "I hope she'll like these...";
        Debug.Log(message: ("Picked flowers"));
    }
    public void GotSoap()
    {
        gotSoap = true;
        dialogueText.text = "This is disgusting, but it'll have to do";
        Debug.Log(message: ("Got soap"));
    }

    public void Showered()
    {
        if (!gotSoap)
            dialogueText.text = "I'm all out of soap!";
        else
        {
            showered = true;
            dialogueText.text = "At least I'm somewhat clean now";
            Debug.Log(message: ("Showered"));
        }
    }
}
