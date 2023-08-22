using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Voice : MonoBehaviour
{
    public AudioSource explosionSound_JH;
    public AudioSource explosionSound_JM;
    public AudioSource explosionSound_SJ;
    public AudioSource explosionSound_HN;
    public AudioSource explosionSound_GM;
    public Animator rangeBtnAnim;

    public GameObject elephant;
    public Button JH_Btn;

    void Start()
    {
        elephant.SetActive(false);
        JH_Btn.onClick.AddListener(ShowElp);
    }

    void ShowElp()
    {
        elephant.SetActive(true);
    }

    public void PlaySound_HN(){
        explosionSound_HN.Play();
    }

    public void PlaySound_SJ(){
        explosionSound_SJ.Play();
    }

    public void PlaySound_JM(){
        explosionSound_JM.Play();
    }

    public void PlaySound_JH(){
        explosionSound_JH.Play();
    }

    public void PlaySound_GM(){
        explosionSound_GM.Play();
    }
}