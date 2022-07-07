using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Okane : MonoBehaviour
{

    Text Okane_text;
    //トータルスコア
    private int OkaneNum;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        OkaneNum = 0;//スコア初期化
        //Textコンポーネント取得
        Okane_text = this.GetComponent<Text>();
        //テキストの文字入力
        Okane_text.text = " " + OkaneNum;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        OkaneNum = gameManager.GetOkane();
    }

    // Update is called once per frame
    void Update()
    {
        OkaneNum = gameManager.GetOkane();
        //テキストの文字入力
        Okane_text.text = " " + OkaneNum;
    }
}
