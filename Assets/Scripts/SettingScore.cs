using UnityEngine;
using UnityEngine.UI;


public class SettingScore : MonoBehaviour
{

    public int score = 0;
    string m_PlayerName;
    string l_Score;
    int highScore;
    string highScoreKey = "High Score";

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("."))
        {
            score += 1;
        }
     
        SetText();
        SetHighScore(); 
  
        if (Input.GetKeyDown("r"))
        {
            PlayerPrefs.DeleteAll();
        }
    }





    void SetText()
    {
       

        //Fetch name (string) from the PlayerPrefs (set these Playerprefs in another script). If no string exists, the default is "No Name"
        m_PlayerName = PlayerPrefs.GetString("Name", "Billy");

        
        
    }

    void SetHighScore()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);

        if (score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey , score);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 130, 200, 30), "Score : " + score);
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
        GUI.Label(new Rect(50, 50, 200, 30), "Name : " + m_PlayerName);
        GUI.Label(new Rect(50, 100, 200, 30), "High Score : " + highScore);

    }

   

}

