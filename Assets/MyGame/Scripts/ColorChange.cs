using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Image color;

    public void ChangeColor()
    {
        int ranNumber;

        var colors = new List<Color>()
        {
            new Color32(255, 205, 25, 100),
            new Color32(95, 34, 0, 100),
            new Color32(207, 63, 21, 100),
            new Color32(102, 47, 84, 100)
        };

        if (Input.GetKeyDown("space"))
        {
            ranNumber = Random.Range(0, colors.Count);
            color.color = colors[ranNumber];
        }

    }

    public void Update()
    {
        ChangeColor();
    }
}
