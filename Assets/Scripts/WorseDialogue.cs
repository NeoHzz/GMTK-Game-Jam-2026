using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class WorseDialogue : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    int index = 0;
    GameObject levelManager;
    [SerializeField] GameObject dialogueBox;
    [SerializeField] GameObject timer;
    [SerializeField] GameObject interaction;
    [SerializeField] GameObject black;
    [SerializeField] GameObject endingDialogue;
    [SerializeField] GameObject gameOver;
    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] GameObject win;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        levelManager = GameObject.Find("LevelManager");
        timer.SetActive(false);
        dialogueBox.SetActive(false);
        interaction.SetActive(false);
        black.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            ContinueDialogue();
        }
    }

    void ContinueDialogue()
    {
        if (index == 0)
        {
            textBox.text = "You finally get to the cafe and she’s there, waiting for you.";
        }
        else if (index == 1)
        {
            textBox.text = "Her: “Hey! I was beginning to think when you’d show up”";
        }
        else if (index == 2 && levelManager.GetComponent<LevelManager>().gotDressed == false)
        {
            textBox.text = "“It really took you long eno…. why are you not wearing any clothes.”";
        }
        else if (index == 3 && levelManager.GetComponent<LevelManager>().gotDressed == false)
        {
            GameOver("You forgot to get dressed");
        }
        else if (index == 2)
        {
            textBox.text = "“It really took you long enough! I almost thought you weren’t gonna show.”";
        }
        else if (index == 3)
        {
            textBox.text = "You: “Yeah sorry! I had a few things I had to do first before I came but I’m glad I made it!”";
        }
        else if (index == 4 && levelManager.GetComponent<LevelManager>().brushedTeeth == false)
        {
            textBox.text = "As you say your first words to her, an overwhelming stench erupts out your mouth directly into hers, causing her to pass out immediately.";
        }
        else if (index == 5 && levelManager.GetComponent<LevelManager>().brushedTeeth == false)
        {
            GameOver("You forgot to brush your teeth.");
        }
        else if (index == 4)
        {
            textBox.text = "Her: “Hey no worries! You showed up and that’s all that matters :)”";
        }
        else if (index == 5)
        {
            textBox.text = "“Say, did you bring those flowers you promised me?”";
        }
        else if (index == 6 && levelManager.GetComponent<LevelManager>().flowersPicked == false)
        {
            textBox.text = "Your heart stops as you realize the grave mistake you’ve just made, not bringing flowers on a first date?";
        }
        else if (index == 7 && levelManager.GetComponent<LevelManager>().flowersPicked == false)
        {
            textBox.text = "Before you could make your next move, you feel your heart refuse to start again as you collapse onto the floor.";
        }
        else if (index == 8 && levelManager.GetComponent<LevelManager>().flowersPicked == false)
        {
            GameOver("You forgot to bring her flowers.");
        }
        else if (index == 6)
        {
            textBox.text = "You: “Yeah they’re right here! A great serving of exquisitie flowers for my exquisite lady”";
        }
        else if (index == 7)
        {
            textBox.text = "Her: “Awww they’re beautiful, thank you so much! Come here and give me a hug”";
        }
        else if (index == 8 && levelManager.GetComponent<LevelManager>().showered == false)
        {
            textBox.text = "As your bodies touch, a vile odor seeps out from underneath your arm pits, completely enveloping her until she is consumed fully by the evils of your body and melts into a pool of goop.";
        }
        else if (index == 9 && levelManager.GetComponent<LevelManager>().showered == false)
        {
            GameOver("You forgot to shower.");
        }
        else if (index == 8)
        {
            textBox.text = "You lean in for a hug and it is very nice, she wraps her arms around you gently as you hold onto her. That dumpster soap really did the trick!";
        }
        else if (index == 9)
        {
            textBox.text = "Her: “C’mon, let’s go in and enjoy some coffee”";
        }
        else if (index == 10)
        {
            textBox.text = "The two you of go into the cafe and you end up ordering the same drink by accident! Maybe it’s all a coincidence or fate must’ve brought you two together.";
        }
        else if (index == 11)
        {
            textBox.text = "You both begin talking about your fascinations in life and sharing life stories.";
        }
        else if (index == 12 && levelManager.GetComponent<LevelManager>().foodEaten == false)
        {
            textBox.text = "But the entire time your stomach was growling quite loudly, cutting her off on multiple points.";
        }
        else if (index == 13 && levelManager.GetComponent<LevelManager>().foodEaten == false)
        {
            textBox.text = "She felt disrespected by your noisiness and ended up making some excuse to leave early.";
        }
        else if (index == 14 && levelManager.GetComponent<LevelManager>().foodEaten == false)
        {
            GameOver("You forgot to eat.");
        }
        else if (index == 12)
        {
            textBox.text = "Afterwards, you two feel closer than ever. Having shared all that you did, she recommends a quick walk around the park before you part ways. ";
        }
        else if (index == 13)
        {
            textBox.text = "When you start walking, she quickly grabs your hand and flashes you a smile. You’ve got this in the bag for sure.";
        }
        else if (index == 14 && levelManager.GetComponent<LevelManager>().fixedLight == false)
        {
            textBox.text = "As you approach the park, a crooked street light sparkles a bit too brightly; letting out an explosion of electricity to any unsuspecting passersby (that’s you two).";
        }
        else if (index == 15 && levelManager.GetComponent<LevelManager>().fixedLight == false)
        {
            textBox.text = "The shock is too strong to handle, and you both end up fried on the floor. At least you look cute as you’re still holding hands.";
        }
        else if (index == 16 && levelManager.GetComponent<LevelManager>().fixedLight == false)
        {
            GameOver("You didn’t fix the street lamp.");
        }
        else if (index == 14)
        {
            textBox.text = "You get to the park and hear an ever growing meowing coming from within.";
        }
        else if (index == 15 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            textBox.text = "You realize there is a cat stuck in a tree. Your date pressures you to save it urgently.";
        }
        else if (index == 16 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            textBox.text = "The anxiety of such a request in front of such a person causes you to slip up while attempting to save him.";
        }
        else if (index == 17 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            textBox.text = "The cat falls down onto your face, scratching you all over until you wake up in a hospital.";
        }
        else if (index == 18 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            textBox.text = "It’s quite the sudden cut I know, but that’s all you remember. You look around the room and your date isn’t even at your bedside.";
        }
        else if (index == 19 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            textBox.text = "What a shame.";
        }
        else if (index == 20 && levelManager.GetComponent<LevelManager>().savedCat == false)
        {
            GameOver("You didn’t save the cat.");
        }
        else if (index == 15)
        {
            textBox.text = "The cat you saved earlier approaches and snuggles up to you.";
        }
        else if (index == 16)
        {
            textBox.text = "Your date asks why he’s so friendly and you admit your heroic deeds from earlier.";
        }
        else if (index == 17)
        {
            textBox.text = "She swoons over you as you tell her the story, look at you go!";
        }
        else if (index == 18)
        {
            textBox.text = "Her: “Why don’t we go over to your place for some coffee?”";
        }
        else if (index == 19)
        {
            textBox.text = "You get to your apartment and sit down on the couch.";
        }
        else if (index == 20 && levelManager.GetComponent<LevelManager>().wateredPlant == false)
        {
            textBox.text = "She notices your plant is withering away and lets out a large exclamation.";
        }
        else if (index == 21 && levelManager.GetComponent<LevelManager>().wateredPlant == false)
        {
            textBox.text = "Turns out she has quite the green thumb and doesn’t want to be associated with anyone who would carry out such heinous acts as she storms out.";
        }
        else if (index == 22 && levelManager.GetComponent<LevelManager>().wateredPlant == false)
        {
            GameOver("You didn’t water the plant.");
        }
        else if (index == 20)
        {
            textBox.text = "She comes and sits down next to you, your eyes meet and instantaneously lock.";
        }
        else if (index == 21)
        {
            textBox.text = "Her: “I’ve had a really nice time with you today, maybe we could do something like this again soon?”";
        }
        else if (index == 22)
        {
            textBox.text = "You: “I’d really like that”";
            Win();
        }

        index++;
    }

    void GameOver(string ending)
    {
        endingDialogue.SetActive(false);
        gameOver.SetActive(true);
        gameOverText.text = ending;
        index = 100;
    }

    void Win()
    {
        endingDialogue.SetActive(false);
        win.SetActive(true);
        index = 100;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }







    //setup run out of time dialogue
    //setup the menu coming up when clicking on door or running out of time
}
