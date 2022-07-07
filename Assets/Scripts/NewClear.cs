using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewClear : MonoBehaviour
{

    Slider NewClear_slider;
    int KakuNum = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // スライダーを取得する
        NewClear_slider = GameObject.Find("Kaku_Slider").GetComponent<Slider>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        KakuNum = gameManager.GetKaku();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager != null)
        {
            KakuNum = gameManager.GetKaku();
        }

        //hp -= 1;
        if (100 <= KakuNum)
        {
            KakuNum = 100;
        }

        // HPゲージに値を設定
        NewClear_slider.value = KakuNum;

        //Debug.Log(KakuNum);
    }
}
