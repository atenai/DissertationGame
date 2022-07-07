using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    //日
    public static int Day = 1;

    //体力(Food)
    public static int HP = 100;

    //水(Water)
    public static int Water = 100;

    //お金
    public static int Okane = 1000;

    //業
    public static int Karuma = 50;

    //放射能
    public static int Kaku = 0;

    //サウンド
    public AudioClip StartSound;
    AudioSource audioSource;

    public static bool b_Fade = false;

    // Start is called before the first frame update
    void Start()
    {

        Screen.SetResolution(1920, 1080, true, 60);//解像度の設定
        Application.targetFrameRate = 60;//フレームレートの設定

        //Componentを取得
        audioSource = GetComponent<AudioSource>();

        //日
        Day = 1;

        //体力
        HP = 100;

        //水(Water)
        Water = 100;

        //お金
        Okane = 1000;

        //業
        Karuma = 50;

        //放射能
        Kaku = 0;

        b_Fade = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Escapeキーでゲーム終了
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();//ゲーム終了
        }

        Debug.Log(b_Fade);
    }

    //ゲーム終了
    void Quit()
    {
        #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
                                      UnityEngine.Application.Quit();
        #endif
    }

    public void PushStartButton()
    {
        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_Fade = true;

        //SceneManager.LoadScene("GameScene");
    }
}
