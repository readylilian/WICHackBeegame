using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    Text IntroText;
    [SerializeField]
    GameObject plantButtons;
    int TimeWithinGame = 1;
    GameObject[] choiceButtons;
    public bool talking = false;
    bool isFinished = false;
    GameObject beeHandler;
    BeeScript beeScript;
    // Start is called before the first frame update
    void Start()
    {
        IntroText.text = "Bee Mine? <3";
        beeHandler = GameObject.Find("BeeHandler");
        beeScript = beeHandler.GetComponent<BeeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void plantSelection()
    {
        StartCoroutine(WaitTime());
        
    }


    //Will split up displays of text
    IEnumerator WaitTime()
    {
        switch (TimeWithinGame)
        {
            case 1:
                IntroText.text = "Week One";
                yield return new WaitForSeconds(1.5f);
                IntroText.text = "Different bees are attracted to different plants, to meet the bee of your dreams, bee sure to keep this in mind!";
                yield return new WaitForSeconds(4f);
                IntroText.text = "What would you like to plant this week?";
                plantButtons.SetActive(true);
                choiceButtons = GameObject.FindGameObjectsWithTag("ChoiceButtons");
                Text buttonText;
                switch (TimeWithinGame)
                {
                    case 1:
                        buttonText = choiceButtons[0].GetComponentInChildren<Text>();
                        //BumbleBees, Mining, Honey, BeeFly
                        buttonText.text = "Rosemary";
                        Button curButton = choiceButtons[0].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointBumble);
                        curButton.onClick.AddListener(beeScript.AddPointMiner);
                        curButton.onClick.AddListener(beeScript.AddPointHoney);
                        curButton.onClick.AddListener(beeScript.AddPointFly);

                        buttonText = choiceButtons[1].GetComponentInChildren<Text>();
                        //LeafCutters, Honey, BumbleBees, Beefly
                        buttonText.text = "Roses";
                        curButton = choiceButtons[1].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointBumble);
                        curButton.onClick.AddListener(beeScript.AddPointHoney);
                        curButton.onClick.AddListener(beeScript.AddPointFly);
                        curButton.onClick.AddListener(beeScript.AddPointLeaf);

                        buttonText = choiceButtons[2].GetComponentInChildren<Text>();
                        //MinerBees, Honey, Bumble, Carpenter, Leaf, BeeFly 
                        buttonText.text = "Wildflowers";
                        buttonText = choiceButtons[2].GetComponentInChildren<Text>();
                        curButton = choiceButtons[2].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointFly);

                        buttonText = choiceButtons[3].GetComponentInChildren<Text>();
                        //BeeFly,
                        buttonText.text = "No plants";
                        curButton = choiceButtons[3].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointFly);

                        buttonText = choiceButtons[4].GetComponentInChildren<Text>();
                        //CarpenterBees, Honey, Bumble, Beefly
                        buttonText.text = "Salvia";
                        curButton = choiceButtons[4].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointBumble);
                        curButton.onClick.AddListener(beeScript.AddPointHoney);
                        curButton.onClick.AddListener(beeScript.AddPointFly);
                        curButton.onClick.AddListener(beeScript.AddPointCarp);

                        buttonText = choiceButtons[5].GetComponentInChildren<Text>();
                        //HoneyBee, Bumble, BeeFly
                        buttonText.text = "Sunflowers";                        curButton = choiceButtons[5].GetComponent<Button>();
                        curButton.onClick.AddListener(beeScript.AddPointBumble);
                        curButton.onClick.AddListener(beeScript.AddPointHoney);
                        curButton.onClick.AddListener(beeScript.AddPointFly);


                        talking = true;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                }
                //talking = true;
                break;
        }
        yield return talking;
    }
   
}
