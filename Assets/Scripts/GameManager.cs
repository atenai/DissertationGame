using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//�Q�[���S�̂̃X�N���v�g������GameManager�őS�ĊǗ�����(main.cpp�̖����ɂ���)

public class GameManager : MonoBehaviour
{
    public static int OkaneNum = 0;
    public static int FoodNum = 0;
    public static int WaterNum = 0;
    public static int KakuNum = 0;
    public static int KarumaNum = 0;

    //�e�L�X�g�̕\���E��\��
    Text Food_text;
    Text Water_text;
    Text Kaku_text;
    Text Aku_text;

    //�{�^���̕\���E��\��
    Button button5;
    Button button6;

    //�t�F�[�h
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

    //�T�E���h
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, true, 60);//�𑜓x�̐ݒ�
        Application.targetFrameRate = 60;//�t���[�����[�g�̐ݒ�

        //Component���擾
        audioSource = GetComponent<AudioSource>();

        //�e�L�X�g�̕\���E��\��
        Food_text = GameObject.Find("CanvasGame/Food_Text").GetComponent<Text>();
        Water_text = GameObject.Find("CanvasGame/Water_Text").GetComponent<Text>();
        Kaku_text = GameObject.Find("CanvasGame/Kaku_Text").GetComponent<Text>();
        Aku_text = GameObject.Find("CanvasGame/Aku_Text").GetComponent<Text>();

        //�{�^���̕\���E��\��
        button5 = GameObject.Find("CanvasUI/ButtonMessage5").GetComponent<Button>();
        button6 = GameObject.Find("CanvasUI/ButtonMessage6").GetComponent<Button>();

        //�t�F�[�h
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

        //Escape�L�[�ŃQ�[���I��
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();//�Q�[���I��
        }

        //�̗�
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

        //��
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

        //���˔\
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

        //��
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

        //��
        if(TitleManager.Day == 10)
        {
            //SceneManager.LoadScene("GameClearScene");

           

            b_DayGameClear = true;
        }

        //�{�^���̔�\��
        if (TitleManager.Okane <= 1999)
        {
            button5.interactable = false;
        }

        //�{�^���̔�\��
        if (TitleManager.Okane <= 999)
        {
            button6.interactable = false;
        }

        //�{�^���̕\��
        if(2000 <= TitleManager.Okane)
        {
           if (button5.interactable == false)
           {
               button5.interactable = true;
           }
        }

        //�{�^���̕\��
        if (1000 <= TitleManager.Okane)
        {
           if (button6.interactable == false)
           {
               button6.interactable = true;
           }
        }
        
    }

    //�Q�[���I��
    void Quit()
    {
        #if UNITY_EDITOR
                                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
                                              UnityEngine.Application.Quit();
        #endif
    }

    //��

    public int GetDay()
    {
        return TitleManager.Day;
    }

    //����

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

    //�H�ו�

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

    //��

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

    //��

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

    //���˔\

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

    //���b�Z�[�W���^�b�v//�T��������
    public void PushButtonMessage1()
    {
        //����+
        SetOkanePlus(Random.Range(1000, 10000));

        //��-
        SetPlayerWaterDamage(Random.Range(10, 100));

        //���˔\+
        SetKakuPlus(Random.Range(10, 90));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("TansakuScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_TansakuFade = true;
    }

    //���b�Z�[�W���^�b�v//�S�~����������
    public void PushButtonMessage2()
    {
        //�H�ו�+
        SetPlayerRecovery(Random.Range(10, 100));

        //��-
        SetPlayerWaterDamage(Random.Range(10, 100));

        //���˔\+
        SetKakuPlus(Random.Range(10, 90));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("GomiScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_GomiFade = true;
    }

    //���b�Z�[�W���^�b�v//�Q��
    public void PushButtonMessage3()
    {
        //�H�ו�-
        SetPlayerDamage(Random.Range(10, 30));

        //��-
        SetPlayerWaterDamage(Random.Range(10, 30));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("NeruScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_NeruFade = true;
    }

    //���b�Z�[�W���^�b�v//���𓐂�
    public void PushButtonMessage4()
    {
        //��-
        SetKarumaMinus(Random.Range(10, 30));

        //����+
        TitleManager.Okane = TitleManager.Okane + Random.Range(1000, 5000);

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("DorobouScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_DorobouFade = true;
    }

    //���b�Z�[�W���^�b�v//��t������
    public void PushButtonMessage5()
    {
        //����-
        SetOkaneMinus(2000);

        //��+
        SetKarumaPlus(Random.Range(10, 40));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("KihuScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_KihuFade = true;
    }

    //���b�Z�[�W���^�b�v//�H���𔃂�
    public void PushButtonMessage6()
    {
        //����-
        SetOkaneMinus(1000);

        //�H�ו�+
        SetPlayerRecovery(Random.Range(10, 100));
        
        //��+
        SetPlayerWaterRecovery(Random.Range(10, 100));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("KauScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_KauFade = true;
    }

    //���b�Z�[�W���^�b�v//��̐�������
    public void PushButtonMessage7()
    {

        //��+
        SetPlayerWaterRecovery(Random.Range(10, 100));

        //���˔\+
        SetKakuPlus(Random.Range(10, 90));

        //��+
        TitleManager.Day = TitleManager.Day + 1;

        //���o�ɃV�[���@��
        //SceneManager.LoadScene("KawaScene");

        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_KawaFade = true;
    }

}
