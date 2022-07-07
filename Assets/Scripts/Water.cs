using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{

    Slider Water_slider;
    int waterBar = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // スライダーを取得する
        Water_slider = GameObject.Find("Water_Slider").GetComponent<Slider>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        waterBar = gameManager.GetPlayerWater();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager != null)
        {
            waterBar = gameManager.GetPlayerWater();
        }

        //hp -= 1;
        if (waterBar <= 0)
        {
            waterBar = 0;
        }

        // HPゲージに値を設定
        Water_slider.value = waterBar;

        //Debug.Log(hpBar);
    }
}
