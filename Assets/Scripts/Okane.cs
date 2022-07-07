using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Okane : MonoBehaviour
{

    Text Okane_text;
    //�g�[�^���X�R�A
    private int OkaneNum;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        OkaneNum = 0;//�X�R�A������
        //Text�R���|�[�l���g�擾
        Okane_text = this.GetComponent<Text>();
        //�e�L�X�g�̕�������
        Okane_text.text = " " + OkaneNum;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        OkaneNum = gameManager.GetOkane();
    }

    // Update is called once per frame
    void Update()
    {
        OkaneNum = gameManager.GetOkane();
        //�e�L�X�g�̕�������
        Okane_text.text = " " + OkaneNum;
    }
}
