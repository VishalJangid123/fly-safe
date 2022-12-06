using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSlider : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    Material[] mat_backgrounds;
    float offeset;

    Material planeMaterial;

    void Start()
    {
        planeMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offeset += (Time.deltaTime * scrollSpeed) / 10f;
        planeMaterial.SetTextureOffset("_MainTex", new Vector2(offeset, 0));
    }
}
