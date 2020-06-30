using GoogleARCore;
using GoogleARCore.Examples.AugmentedImage;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FrameUpperRightText : MonoBehaviour
{
    // Text
    private static TextMeshPro textmesh;

    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void setIMG(AugmentedImage Image)
    {
        if (Image.Name.Equals("Dondurma"))
            textmesh.text = "4.99 TL";
        else if (Image.Name.Equals("Cay"))
            textmesh.text = "3.49 TL";
        else if (Image.Name.Equals("Corba"))
            textmesh.text = "2.99 TL";
        else if (Image.Name.Equals("Peynir"))
            textmesh.text = "11.25 TL";
    }
}

