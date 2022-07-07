using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    //ƒTƒEƒ“ƒh
    public AudioClip StartSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Component‚ğæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushTitleReturnButton()
    {
        //SEÄ¶
        //‰¹(GOALSound)‚ğ–Â‚ç‚·
        audioSource.PlayOneShot(StartSound);

        SceneManager.LoadScene("TitleScene");
    }
}
