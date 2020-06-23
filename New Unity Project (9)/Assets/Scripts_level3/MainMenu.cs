using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "High score : " + ((int)PlayerPrefs.GetFloat("Higth score")).ToString();
    }

    // Update is called once per frame
    
    public void ToGame()
    {
        SceneManager.LoadScene("Level3");
    }
}
