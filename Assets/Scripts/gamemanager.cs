using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
   public Text _playscoretext;
    public Text _comscoretext;
    private int playerscore;
    private int comscore;

    private void Update()
    {
        close();
    }

    public ball ball;
    public void playerscores()
    {
        playerscore++;
        this._playscoretext.text = playerscore.ToString();
        this.ball.Reset();
        Debug.Log(playerscore);

    }

    public void comscores()
    {
        comscore++;
        this._comscoretext.text = comscore.ToString();
        this.ball.Reset(); 
        Debug.Log(comscore);
    }

    private void close()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
