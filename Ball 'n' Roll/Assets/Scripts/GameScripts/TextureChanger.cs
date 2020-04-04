using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Renderer renderer;
    public Texture[] skins;
    public void Start()
    {
        renderer = GetComponent<Renderer>();
        switch (ButtonScriptHexagonCarbon.skinChoice)
        {
            case "HexagonCarbon":
                renderer.material.mainTexture = skins[0];
                break;
            case "Bones":
                renderer.material.mainTexture = skins[1];
                break;
        }
    }
}
