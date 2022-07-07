using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour
{

    Slider HP_slider;
    int hpBar = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // �X���C�_�[���擾����
        HP_slider = GameObject.Find("HP_Slider").GetComponent<Slider>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        hpBar = gameManager.GetPlayerHP();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager != null)
        {
            hpBar = gameManager.GetPlayerHP();
        }

        //hp -= 1;
        if (hpBar <= 0)
        {
            hpBar = 0;
        }

        // HP�Q�[�W�ɒl��ݒ�
        HP_slider.value = hpBar;

        //Debug.Log(hpBar);
    }
}
