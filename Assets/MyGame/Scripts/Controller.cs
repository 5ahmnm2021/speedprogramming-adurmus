using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{

    public void ChangeScenetoFrage2()
    {
        SceneManager.LoadScene("01Frage2");

    }

    public void ChangeScenetoFinal()
    {
        SceneManager.LoadScene("02FinalScreen");

    }


}
