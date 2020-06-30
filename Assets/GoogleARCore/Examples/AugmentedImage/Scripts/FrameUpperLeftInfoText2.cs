using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameUpperLeftInfoText2 : MonoBehaviour
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
            textmesh.text = "-TETT: 14.04.2022";
        else if (Image.Name.Equals("Cay"))
            textmesh.text = "-TETT: 03.05.2021";
        else if (Image.Name.Equals("Corba"))
            textmesh.text = "-TETT: 03.05.2021";
        else if (Image.Name.Equals("Peynir"))
            textmesh.text = "-TETT: 01.06.2020";
    }
}