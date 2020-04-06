using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Renderer renderer = new Renderer();
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
            case "FireBorne":
                renderer.material.mainTexture = skins[2];
                break;
            case "Poisoned":
                renderer.material.mainTexture = skins[3];
                break;
            case "DarkWater":
                renderer.material.mainTexture = skins[4];
                break;
            case "PhoenixNebula":
                renderer.material.mainTexture = skins[5];
                break;
            case "GoldenRain":
                renderer.material.mainTexture = skins[6];
                break;
            case "CrystalWater":
                renderer.material.mainTexture = skins[7];
                break;
        }

    }
}
