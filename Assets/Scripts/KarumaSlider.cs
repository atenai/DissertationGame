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
        //// HPã¸
        //_Karuma += 1.0f;
        //if (_Karuma > 100)
        //{
        //    // Å‘å‚ğ’´‚¦‚½‚ç0‚É–ß‚·
        //    _Karuma = 0;
        //}

        _Karuma = gameManager.GetKaruma();

        // HPƒQ[ƒW‚É’l‚ğİ’è
        Karuma_slider.value = _Karuma;
    }
}
