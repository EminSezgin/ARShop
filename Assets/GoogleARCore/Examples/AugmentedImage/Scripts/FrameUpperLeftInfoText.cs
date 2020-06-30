using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameUpperLeftInfoText : MonoBehaviour
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
            textmesh.text = "-Carte d'Or Yoğun Çikolatalı";
        else if (Image.Name.Equals("Cay"))
            textmesh.text = "-Doğuş Karadeniz Çayı";
        else if (Image.Name.Equals("Corba"))
            textmesh.text = "-Knorr Ezogelin Çorbası";
        else if (Image.Name.Equals("Peynir"))
            textmesh.text = "-Pınar Süzme Peynir";
    }
}
