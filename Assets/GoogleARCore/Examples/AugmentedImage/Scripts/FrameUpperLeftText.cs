using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameUpperLeftText : MonoBehaviour
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
            textmesh.text = "Dondurma";
        else if (Image.Name.Equals("Cay"))
            textmesh.text = "Çay";
        else if (Image.Name.Equals("Corba"))
            textmesh.text = "Çorba";
        else if (Image.Name.Equals("Peynir"))
            textmesh.text = "Süzme Peynir";
    }
}
