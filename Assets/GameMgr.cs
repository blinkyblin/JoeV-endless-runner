using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
   public static GameMgr Instance;
    public float currentScore = 0f;

    public bool isPlaying = false;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

       

    public string ScoreDisplay()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }
        

    public void GameOver()
    {
        isPlaying = false;
    }


    private void Update()
    {
        if (isPlaying == true)
        {
            currentScore += Time.deltaTime;
        }

        if(Input.GetKeyDown("j"))
        {
            isPlaying = true;
        }
    }
}
