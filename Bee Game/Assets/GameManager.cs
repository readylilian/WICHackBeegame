using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    Text IntroText;
    int TimeWithinGame = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        IntroText.text = "Bee Mine? <3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlantSelection()
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
                break;
        }
        
    }
}
