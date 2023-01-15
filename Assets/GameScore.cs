using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class GameScore : MonoBehaviour
{
    public int MyScore;
    public TextMeshProUGUI Scoretext;
    public static GameScore Instance;
    public void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Scoretext = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        Scoretext.text = MyScore.ToString();
    }
    public void AddScore(int newScore)
    {
        MyScore += newScore + 1;
    }

}
