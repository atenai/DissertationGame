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
        // �X���C�_�[���擾����
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

        // HP�Q�[�W�ɒl��ݒ�
        Water_slider.value = waterBar;

        //Debug.Log(hpBar);
    }
}
