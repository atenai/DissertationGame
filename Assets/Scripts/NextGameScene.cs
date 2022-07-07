using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextGameScene : MonoBehaviour
{

    public static bool b_GameScene;

    //�T�E���h
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();

        b_GameScene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushGameSceneButton()
    {
        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        b_GameScene = true;
        //SceneManager.LoadScene("GameScene");
    }
}
