using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeGame : MonoBehaviour
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
        if (NextGameScene.b_GameScene == true)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }

        if (alfa >= 1)
        {
            //ステージ１シーンへ
            SceneManager.LoadScene("GameScene");
            NextGameScene.b_GameScene = false;
        }
    }
}
