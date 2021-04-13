using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public InputField A;
    public InputField B;
    public float result;
    public Text t;

    public Text error;
    public float nr1;
    public float nr2;
    public Color grey = Color.grey;
    public Color red = Color.red;

    public void ChangeScenetoColor()
    {
        SceneManager.LoadScene("01Colorscene");

    }

    public void ChangeScenetoNumber()
    {
        SceneManager.LoadScene("02Numberscene");

    }

    public void ChangeScenetoWelcome()
    {
        SceneManager.LoadScene("00Welcomescene");
    }

    public void Add()
    {

        try
		{
            nr1 = float.Parse(A.text);
            A.image.color = grey;
        }

        catch (System.Exception)
		{
            A.image.color = red;
            error.text = "Error! Enter Number";
		}

        try
		{
            nr2 = float.Parse(B.text);
            B.image.color = grey;
        }

        catch (System.Exception)
		{
            B.image.color = red;
            error.text = "Error! Enter Number";
		}


        result = float.Parse(A.text) + float.Parse(B.text);
        t.text = result.ToString();
        
    }

}
