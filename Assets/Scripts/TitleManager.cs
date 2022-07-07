using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    //��
    public static int Day = 1;

    //�̗�(Food)
    public static int HP = 100;

    //��(Water)
    public static int Water = 100;

    //����
    public static int Okane = 1000;

    //��
    public static int Karuma = 50;

    //���˔\
    public static int Kaku = 0;

    //�T�E���h
    public AudioClip StartSound;
    AudioSource audioSource;

    public static bool b_Fade = false;

    // Start is called before the first frame update
    void Start()
    {

        Screen.SetResolution(1920, 1080, true, 60);//�𑜓x�̐ݒ�
        Application.targetFrameRate = 60;//�t���[�����[�g�̐ݒ�

        //Component���擾
        audioSource = GetComponent<AudioSource>();

        //��
        Day = 1;

        //�̗�
        HP = 100;

        //��(Water)
        Water = 100;

        //����
        Okane = 1000;

        //��
        Karuma = 50;

        //���˔\
        Kaku = 0;

        b_Fade = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Escape�L�[�ŃQ�[���I��
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();//�Q�[���I��
        }

        Debug.Log(b_Fade);
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

    public void PushStartButton()
    {
        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_Fade = true;

        //SceneManager.LoadScene("GameScene");
    }
}
