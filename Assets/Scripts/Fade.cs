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
            //ステージ１シーンへ
            SceneManager.LoadScene("TansakuScene");
            GameManager.b_TansakuFade = false;
        }

        if (alfa >= 1 && GameManager.b_GomiFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("GomiScene");
            GameManager.b_TansakuFade = false;
        }

        if (alfa >= 1 && GameManager.b_NeruFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("NeruScene");
            GameManager.b_NeruFade = false;
        }

        if (alfa >= 1 && GameManager.b_DorobouFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("DorobouScene");
            GameManager.b_DorobouFade = false;
        }

        if (alfa >= 1 && GameManager.b_KihuFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("KihuScene");
            GameManager.b_KihuFade = false;
        }

        if (alfa >= 1 && GameManager.b_KauFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("KauScene");
            GameManager.b_KauFade = false;
        }

        if (alfa >= 1 && GameManager.b_KawaFade == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("KawaScene");
            GameManager.b_KawaFade = false;
        }

        if (alfa >= 1 && GameManager.b_FoodGameOver == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("FoodGameOverScene");
            GameManager.b_FoodGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_WaterGameOver == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("WaterGameOverScene");
            GameManager.b_WaterGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_KakuGameOver == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("KakuGameOverScene");
            GameManager.b_KakuGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_RouyaGameOver == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("RouyaScene");
            GameManager.b_RouyaGameOver = false;
        }

        if (alfa >= 1 && GameManager.b_TrueGameClear == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("TrueScene");
            GameManager.b_TrueGameClear = false;
        }

        if (alfa >= 1 && GameManager.b_DayGameClear == true)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("GameClearScene");
            GameManager.b_DayGameClear = false;
        }
    }
}
