using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeMatManager : MonoBehaviour
{

    public Material planeMat;
    public Button[] planeTexButton;

     void Awake(){
        foreach(var b in planeTexButton){
            Texture tex = b.transform.Find("Mask/RawImage").GetComponent<RawImage>().texture;
            b.onClick.AddListener(() => OnClickButton(tex));
        }
    }
    void OnClickButton(Texture tex){
        planeMat.mainTexture = tex;
    }
}
