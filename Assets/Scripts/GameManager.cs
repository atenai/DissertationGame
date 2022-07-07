using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ゲーム全体のスクリプトをこのGameManagerで全て管理する(main.cppの役割にする)

public class GameManager : MonoBehaviour
{
    public static int OkaneNum = 0;
    public static int FoodNum = 0;
    public static int WaterNum = 0;
    public static int KakuNum = 0;
    public static int KarumaNum = 0;

    //テキストの表示・非表示
    Text Food_text;
    Text Water_text;
    Text Kaku_text;
    Text Aku_text;

    //ボタンの表示・非表示
    Button button5;
    Button button6;

    //フェード
    public static bool b_TansakuFade;
    public static bool b_GomiFade;
    public static bool b_NeruFade;
    public static bool b_DorobouFade;
    public static bool b_KihuFade;
    public static bool b_KauFade;
    public static bool b_KawaFade;

    public static bool b_FoodGameOver;
    public static bool b_WaterGameOver;
    public static bool b_KakuGameOver;
    public static bool b_RouyaGameOver;
    public static bool b_TrueGameClear;
    public static bool b_DayGameClear;

    //サウンド
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, true, 60);//解像度の設定
        Application.targetFrameRate = 60;//フレームレートの設定

        //Componentを取得
        audioSource = GetComponent<AudioSource>();

        //テキストの表示・非表示
        Food_text = GameObject.Find("CanvasGame/Food_Text").GetComponent<Text>();
        Water_text = GameObject.Find("CanvasGame/Water_Text").GetComponent<Text>();
        Kaku_text = GameObject.Find("CanvasGame/Kaku_Text").GetComponent<Text>();
        Aku_text = GameObject.Find("CanvasGame/Aku_Text").GetComponent<Text>();

        //ボタンの表示・非表示
        button5 = GameObject.Find("CanvasUI/ButtonMessage5").GetComponent<Button>();
        button6 = GameObject.Find("CanvasUI/ButtonMessage6").GetComponent<Button>();

        //フェード
        b_TansakuFade = false;
        b_GomiFade = false;
        b_NeruFade = false;
        b_DorobouFade = false;
        b_KihuFade = false;
        b_KauFade = false;
        b_KawaFade = false;

        b_FoodGameOver = false;
        b_WaterGameOver = false;
        b_KakuGameOver = false;
        b_RouyaGameOver = false;
        b_TrueGameClear = false;
        b_DayGameClear = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Escapeキーでゲーム終了
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();//ゲーム終了
        }

        //体力
        if (TitleManager.HP <= 0)
        {
            //SceneManager.LoadScene("FoodGameOverScene");

            

            b_FoodGameOver = true;
        }

        if (30 < TitleManager.HP)
        {
            Food_text.enabled = false;
        }

        if (TitleManager.HP <= 30)
        {
            Food_text.enabled = true;
        }

        //水
        if (TitleManager.Water <= 0)
        {
            //SceneManager.LoadScene("WaterGameOverScene");

            

            b_WaterGameOver = true;
        }

        if (30 < TitleManager.Water)
        {
            Water_text.enabled = false;
        }

        if (TitleManager.Water <= 30)
        {
            Water_text.enabled = true;
        }

        //放射能
        if (100 <= TitleManager.Kaku)
        {
            //SceneManager.LoadScene("KakuGameOverScene");

           

            b_KakuGameOver = true;
        }

        if (70 <= TitleManager.Kaku)
        {
            Kaku_text.enabled = true;
        }

        if (TitleManager.Kaku < 70)
        {
            Kaku_text.enabled = false;
        }

        //業
        if (TitleManager.Karuma <= 0)
        {
            //SceneManager.LoadScene("RouyaScene");

            

            b_RouyaGameOver = true;
        }

        if (30 < TitleManager.Karuma)
        {
            Aku_text.enabled = false;
        }

        if (TitleManager.Karuma <= 30)
        {
            Aku_text.enabled = true;
        }

        if (100 <= TitleManager.Karuma)
        {
            //SceneManager.LoadScene("TrueScene");

          

            b_TrueGameClear = true;
        }

        //日
        if(TitleManager.Day == 10)
        {
            //SceneManager.LoadScene("GameClearScene");

           

            b_DayGameClear = true;
        }

        //ボタンの非表示
        if (TitleManager.Okane <= 1999)
        {
            button5.interactable = false;
        }

        //ボタンの非表示
        if (TitleManager.Okane <= 999)
        {
            button6.interactable = false;
        }

        //ボタンの表示
        if(2000 <= TitleManager.Okane)
        {
           if (button5.interactable == false)
           {
               button5.interactable = true;
           }
        }

        //ボタンの表示
        if (1000 <= TitleManager.Okane)
        {
           if (button6.interactable == false)
           {
               button6.interactable = true;
           }
        }
        
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

    //日

    public int GetDay()
    {
        return TitleManager.Day;
    }

    //お金

    public void SetOkanePlus(int Plus)
    {
        OkaneNum = Plus;

        TitleManager.Okane = TitleManager.Okane + Plus;
    }

    public void SetOkaneMinus(int Minus)
    {
        OkaneNum = Minus;

        if (TitleManager.Okane != 0)
        {
            TitleManager.Okane = TitleManager.Okane - Minus;
        }
    }

    public int GetOkane()
    {
        return TitleManager.Okane;
    }

    //食べ物

    public void SetPlayerDamage(int Damage)
    {
        FoodNum = Damage;

        TitleManager.HP = TitleManager.HP - Damage;
        if (TitleManager.HP <= 0)
        {
            TitleManager.HP = 0;
        }
    }

    public void SetPlayerRecovery(int Recovery)
    {
        FoodNum = Recovery;

        TitleManager.HP = TitleManager.HP + Recovery;
        if (100 <= TitleManager.HP)
        {
            TitleManager.HP = 100;
        }
    }

    public int GetPlayerHP()
    {
        return TitleManager.HP;
    }

    //水

    public void SetPlayerWaterDamage(int WaterDamage)
    {
        WaterNum = WaterDamage;

        TitleManager.Water = TitleManager.Water - WaterDamage;
        if (TitleManager.Water <= 0)
        {
            TitleManager.Water = 0;
        }
    }

    public void SetPlayerWaterRecovery(int WaterRecovery)
    {
        WaterNum = WaterRecovery;

        TitleManager.Water = TitleManager.Water + WaterRecovery;
        if (100 <= TitleManager.Water)
        {
            TitleManager.Water = 100;
        }
    }

    public int GetPlayerWater()
    {
        return TitleManager.Water;
    }

    //業

    public void SetKarumaPlus(int Plus)
    {
        KarumaNum = Plus;

        TitleManager.Karuma = TitleManager.Karuma + Plus;
        if(100 <= TitleManager.Karuma)
        {
            TitleManager.Karuma = 100;
        }
    }

    public void SetKarumaMinus(int Minus)
    {
        KarumaNum = Minus;

        TitleManager.Karuma = TitleManager.Karuma - Minus;
        if (TitleManager.Karuma <= 0)
        {
            TitleManager.Karuma = 0;
        }
    }

    public int GetKaruma()
    {
        return TitleManager.Karuma;
    }

    //放射能

    public void SetKakuPlus(int Plus)
    {
        KakuNum = Plus;

        TitleManager.Kaku = TitleManager.Kaku + Plus;
        if (100 <= TitleManager.Kaku)
        {
            TitleManager.Kaku = 100;
        }
    }

    public void SetKakuMinus(int Minus)
    {
        KakuNum = Minus;

        TitleManager.Kaku = TitleManager.Kaku - Minus;
        if (TitleManager.Kaku <= 0)
        {
            TitleManager.Kaku = 0;
        }
    }

    public int GetKaku()
    {
        return TitleManager.Kaku;
    }

    //メッセージをタップ//探索をする
    public void PushButtonMessage1()
    {
        //お金+
        SetOkanePlus(Random.Range(1000, 10000));

        //水-
        SetPlayerWaterDamage(Random.Range(10, 100));

        //放射能+
        SetKakuPlus(Random.Range(10, 90));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("TansakuScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_TansakuFade = true;
    }

    //メッセージをタップ//ゴミ箱をあさる
    public void PushButtonMessage2()
    {
        //食べ物+
        SetPlayerRecovery(Random.Range(10, 100));

        //水-
        SetPlayerWaterDamage(Random.Range(10, 100));

        //放射能+
        SetKakuPlus(Random.Range(10, 90));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("GomiScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_GomiFade = true;
    }

    //メッセージをタップ//寝る
    public void PushButtonMessage3()
    {
        //食べ物-
        SetPlayerDamage(Random.Range(10, 30));

        //水-
        SetPlayerWaterDamage(Random.Range(10, 30));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("NeruScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_NeruFade = true;
    }

    //メッセージをタップ//物を盗む
    public void PushButtonMessage4()
    {
        //業-
        SetKarumaMinus(Random.Range(10, 30));

        //お金+
        TitleManager.Okane = TitleManager.Okane + Random.Range(1000, 5000);

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("DorobouScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_DorobouFade = true;
    }

    //メッセージをタップ//寄付をする
    public void PushButtonMessage5()
    {
        //お金-
        SetOkaneMinus(2000);

        //業+
        SetKarumaPlus(Random.Range(10, 40));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("KihuScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_KihuFade = true;
    }

    //メッセージをタップ//食事を買う
    public void PushButtonMessage6()
    {
        //お金-
        SetOkaneMinus(1000);

        //食べ物+
        SetPlayerRecovery(Random.Range(10, 100));
        
        //水+
        SetPlayerWaterRecovery(Random.Range(10, 100));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("KauScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_KauFade = true;
    }

    //メッセージをタップ//川の水を飲む
    public void PushButtonMessage7()
    {

        //水+
        SetPlayerWaterRecovery(Random.Range(10, 100));

        //放射能+
        SetKakuPlus(Random.Range(10, 90));

        //日+
        TitleManager.Day = TitleManager.Day + 1;

        //演出にシーン繊維
        //SceneManager.LoadScene("KawaScene");

        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_KawaFade = true;
    }

}
