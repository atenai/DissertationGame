using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{

    public float alfa = 0.0f;
    public float speed;
    public float red, green, blue;

    // Start is called before the first frame update
    void Start()
    {
        alfa = 0.0f;
        speed = 0.025f;

        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.b_TansakuFade == true || GameManager.b_GomiFade == true || GameManager.b_NeruFade == true || GameManager.b_DorobouFade == true || GameManager.b_KihuFade == true || GameManager.b_KauFade == true || GameManager.b_KawaFade == true || GameManager.b_FoodGameOver == true || GameManager.b_WaterGameOver == true || GameManager.b_KakuGameOver == true || GameManager.b_RouyaGameOver == true || GameManager.b_TrueGameClear == true || GameManager.b_DayGameClear == true)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }

        if (alfa >= 1 && GameManager.b_TansakuFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("TansakuScene");
            GameManager.b_TansakuFade = false;
        }

        if (alfa >= 1 && GameManager.b_GomiFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("GomiScene");
            GameManager.b_TansakuFade = false;
        }

        if (alfa >= 1 && GameManager.b_NeruFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("NeruScene");
            GameManager.b_NeruFade = false;
        }

        if (alfa >= 1 && GameManager.b_DorobouFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("DorobouScene");
            GameManager.b_DorobouFade = false;
        }

        if (alfa >= 1 && GameManager.b_KihuFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("KihuScene");
            GameManager.b_KihuFade = false;
        }

        if (alfa >= 1 && GameManager.b_KauFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("KauScene");
            GameManager.b_KauFade = false;
        }

        if (alfa >= 1 && GameManager.b_KawaFade == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("KawaScene");
            GameManager.b_KawaFade = false;
        }

        if (alfa >= 1 && GameManager.b_FoodGameOver == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("FoodGameOverScene");
            GameManager.b_FoodGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_WaterGameOver == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("WaterGameOverScene");
            GameManager.b_WaterGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_KakuGameOver == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("KakuGameOverScene");
            GameManager.b_KakuGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_RouyaGameOver == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("RouyaScene");
            GameManager.b_RouyaGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_TrueGameClear == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("TrueScene");
            GameManager.b_TrueGameClear = false;
        }

        if (alfa >= 1 && GameManager.b_DayGameClear == true)
        {
            //�X�e�[�W�P�V�[����
            SceneManager.LoadScene("GameClearScene");
            GameManager.b_DayGameClear = false;
        }
    }
}
