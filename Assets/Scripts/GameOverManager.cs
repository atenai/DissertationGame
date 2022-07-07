using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    //�T�E���h
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushTitleReturnButton()
    {
        //SE�Đ�
        //��(GOALSound)��炷
        audioSource.PlayOneShot(StartSound);

        SceneManager.LoadScene("TitleScene");
    }
}
