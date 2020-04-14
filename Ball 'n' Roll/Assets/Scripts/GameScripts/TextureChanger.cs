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
            case "FlamingoPink":
                renderer.material.mainTexture = skins[8];
                break;
            case "EmeraldMosaic":
                renderer.material.mainTexture = skins[9];
                break;
            case "Multiverse":
                renderer.material.mainTexture = skins[10];
                break;
            case "Pokeball":
                renderer.material.mainTexture = skins[11];
                break;
            case "DeepBlue":
                renderer.material.mainTexture = skins[12];
                break;
            case "Football":
                renderer.material.mainTexture = skins[13];
                break;
            case "Bulgaria":
                renderer.material.mainTexture = skins[14];
                break;
            case "AvatarBitcoin":
                renderer.material.mainTexture = skins[15];
                break;
        }

    }
}
