using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextGameScene : MonoBehaviour
{

    public static bool b_GameScene;

    //サウンド
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();

        b_GameScene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushGameSceneButton()
    {
        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        b_GameScene = true;
        //SceneManager.LoadScene("GameScene");
    }
}
