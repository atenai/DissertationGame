using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    //サウンド
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushTitleReturnButton()
    {
        //SE再生
        //音(GOALSound)を鳴らす
        audioSource.PlayOneShot(StartSound);

        SceneManager.LoadScene("TitleScene");
    }
}
