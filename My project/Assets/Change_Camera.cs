using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Camera : MonoBehaviour
{
   public void ChangeScene()
   {
       switch(this.gameObject.name)
       {
           case "Scene_Change_Btn":
                SceneManager.LoadScene("SampleScene");
                break;
       }
   }
}
