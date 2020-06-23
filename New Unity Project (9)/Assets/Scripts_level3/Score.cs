using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public static Score instance;
    public Text scoretext;
    private bool isdead = false;

    public DeathMenu menu;
    // Start is called before the first frame update

    private void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (isdead)
            return;
        
    }
  
    public void OnisDead()
    {
        isdead = true;
        if (PlayerPrefs.GetFloat("Higth score", score) < score)
            PlayerPrefs.SetFloat("Higth score", score);
        menu.TouchMenu(score);
    }
    public void IncreaseScore(int increment)
    {
        
        scoretext.text = ((int)score).ToString();
        score += increment;
    }
}
