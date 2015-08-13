using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour
{
    public Texture2D[] NovaTextura;

    public int conte;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        conte++;
        if (conte > 20)
        {
            conte = 0;
        }
        gameObject.GetComponent<Renderer>().material.mainTexture = NovaTextura[conte];

    }
}
