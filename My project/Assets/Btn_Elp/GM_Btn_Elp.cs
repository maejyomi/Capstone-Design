using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_Btn_Elp : MonoBehaviour
{
    public GameObject elephant;
    public Button Btn;


    void Start()
    {
        elephant.SetActive(false);
        Btn.onClick.AddListener(ShowElp);
    }

    void ShowElp()
    {
        elephant.SetActive(true);
    }
}
