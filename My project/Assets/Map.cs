using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public GameObject HN_Image;
    public GameObject SJ_Image;
    public GameObject JH_Image;
    public GameObject JM_Image;
    public GameObject GM_Image;

    public Button SJ_Map_Btn;
    public Button HN_Map_Btn;
    public Button JH_Map_Btn;
    public Button JM_Map_Btn;
    public Button GM_Map_Btn;
    // Start is called before the first frame update
    void Start()
    {
        HN_Image.SetActive(false);
        HN_Map_Btn.onClick.AddListener(ShowMap_HN);

        SJ_Image.SetActive(false);
        SJ_Map_Btn.onClick.AddListener(ShowMap_SJ);

        JH_Image.SetActive(false);
        JH_Map_Btn.onClick.AddListener(ShowMap_JH);

        JM_Image.SetActive(false);
        JM_Map_Btn.onClick.AddListener(ShowMap_JM);

        GM_Image.SetActive(false);
        GM_Map_Btn.onClick.AddListener(ShowMap_GM);

    }

    void ShowMap_HN()
    {
        HN_Image.SetActive(true);
        Invoke("Hide_HN",4);
    }

    void ShowMap_SJ()
    {
        SJ_Image.SetActive(true);
        Invoke("Hide_SJ",4);
    }

    void ShowMap_JH()
    {
        JH_Image.SetActive(true);
        Invoke("Hide_JH",4);
    }

    void ShowMap_JM()
    {
        JM_Image.SetActive(true);
        Invoke("Hide_JM",4);
    }

    void ShowMap_GM()
    {
        GM_Image.SetActive(true);
        Invoke("Hide_GM",4);
    }

    void Hide_HN()
    {
        HN_Image.SetActive(false);
    }

    void Hide_SJ()
    {
        SJ_Image.SetActive(false);
    }

    void Hide_JH()
    {
        JH_Image.SetActive(false);
    }

    void Hide_JM()
    {
        JM_Image.SetActive(false);
    }

    void Hide_GM()
    {
        GM_Image.SetActive(false);
    }
}
