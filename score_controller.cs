using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_controller : MonoBehaviour
{
    public GameObject scoreboard;
    
    public Text box1Text;
    public Text box2Text;
    public Text box3Text;
    public Text box4Text;
    public Text box5Text;
    public Text box6Text;
    public Text box7Text;
    public Text box8Text;
    public Text box9Text;
    public Text boxTText;


    public void updateScoreboard()
    {
        box1Text.text = "" + PlayerPrefs.GetInt("level 1 shots");
        box2Text.text = "" + PlayerPrefs.GetInt("level 2 shots");
        box3Text.text = "" + PlayerPrefs.GetInt("level 3 shots");
        box4Text.text = "" + PlayerPrefs.GetInt("level 4 shots");
        box5Text.text = "" + PlayerPrefs.GetInt("level 5 shots");
        box6Text.text = "" + PlayerPrefs.GetInt("level 6 shots");
        box7Text.text = "" + PlayerPrefs.GetInt("level 7 shots");
        box8Text.text = "" + PlayerPrefs.GetInt("level 8 shots");
        box9Text.text = "" + PlayerPrefs.GetInt("level 9 shots");
        boxTText.text = "" + PlayerPrefs.GetInt("Total Score");
    }

    // Update is called once per frame
    void Update()
    {
        updateScoreboard();
    }
}
