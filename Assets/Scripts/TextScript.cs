using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour
{
    public Text sceneText;
    int m_Score;

    // Start is called before the first frame update
    void Start()
    {

        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("."))
        {
            m_Score += 10;
        }
        if (Input.GetKeyDown(","))
        {
            m_Score -= 10;
        }

        sceneText.text = (SceneManager.GetActiveScene().name);
    }

    void SetText()
    {
        m_Score = PlayerPrefs.GetInt("Score", 0);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 130, 200, 30), "Score : " + m_Score);
    }


    
}
