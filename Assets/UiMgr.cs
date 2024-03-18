using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiMgr : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreDisplay;

    GameMgr gameMgr;
    private void Start()
    {
        gameMgr = GameMgr.Instance;
    }

    private void OnGUI()
    {
        scoreDisplay.text = ("score") + gameMgr.ScoreDisplay();
    }
}
