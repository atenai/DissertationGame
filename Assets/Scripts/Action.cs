using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    Text OkaneAction_text;
    Text FoodAction_text;
    Text WaterAction_text;
    Text KakuAction_text;
    Text KarumaAction_text;

    // Start is called before the first frame update
    void Start()
    {
        //Textコンポーネント取得
        OkaneAction_text = GameObject.Find("OkaneAction_Text").GetComponent<Text>();
        FoodAction_text = GameObject.Find("FoodAction_Text").GetComponent<Text>();
        WaterAction_text = GameObject.Find("WaterAction_Text").GetComponent<Text>();
        KakuAction_text = GameObject.Find("KakuAction_Text").GetComponent<Text>();
        KarumaAction_text = GameObject.Find("KarumaAction_Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //テキストの文字入力
        OkaneAction_text.text = " " + GameManager.OkaneNum;
        FoodAction_text.text = " " + GameManager.FoodNum;
        WaterAction_text.text = " " + GameManager.WaterNum;
        KakuAction_text.text = " " + GameManager.KakuNum;
        KarumaAction_text.text = " " + GameManager.KarumaNum;
    }
}
