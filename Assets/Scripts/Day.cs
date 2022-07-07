using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{

    Text Day_text;
    //トータルスコア
    private int DayNum;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        DayNum = 0;//スコア初期化
        //Textコンポーネント取得
        Day_text = this.GetComponent<Text>();
        //テキストの文字入力
        Day_text.text = " " + DayNum;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        DayNum = gameManager.GetDay();
    }

    // Update is called once per frame
    void Update()
    {
        DayNum = gameManager.GetDay();
        //テキストの文字入力
        Day_text.text = " " + DayNum;
    }
}
