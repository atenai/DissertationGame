using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarumaSlider : MonoBehaviour
{

    Slider Karuma_slider;
    float _Karuma = 50;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Karuma_slider = GameObject.Find("Karuma_Slider").GetComponent<Slider>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _Karuma = gameManager.GetKaruma();
    }

    // Update is called once per frame
    void Update()
    {
        //// HP上昇
        //_Karuma += 1.0f;
        //if (_Karuma > 100)
        //{
        //    // 最大を超えたら0に戻す
        //    _Karuma = 0;
        //}

        _Karuma = gameManager.GetKaruma();

        // HPゲージに値を設定
        Karuma_slider.value = _Karuma;
    }
}
