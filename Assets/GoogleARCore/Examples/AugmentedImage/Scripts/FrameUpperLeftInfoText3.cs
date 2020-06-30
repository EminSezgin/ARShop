using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameUpperLeftInfoText3 : MonoBehaviour
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
            textmesh.text = "-Fransa";
        else if (Image.Name.Equals("Cay"))
            textmesh.text = "-Türkiye";
        else if (Image.Name.Equals("Corba"))
            textmesh.text = "-Almanya";
        else if (Image.Name.Equals("Peynir"))
            textmesh.text = "-Türkiye";
    }
}
