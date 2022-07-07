using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{

    Text Day_text;
    //�g�[�^���X�R�A
    private int DayNum;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        DayNum = 0;//�X�R�A������
        //Text�R���|�[�l���g�擾
        Day_text = this.GetComponent<Text>();
        //�e�L�X�g�̕�������
        Day_text.text = " " + DayNum;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        DayNum = gameManager.GetDay();
    }

    // Update is called once per frame
    void Update()
    {
        DayNum = gameManager.GetDay();
        //�e�L�X�g�̕�������
        Day_text.text = " " + DayNum;
    }
}
