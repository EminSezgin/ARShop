using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameLowerRightText : MonoBehaviour
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
        textmesh.text = Image.Name;
    }
}
