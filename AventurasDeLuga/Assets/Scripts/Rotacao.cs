using UnityEngine;
using System.Collections;

public class Rotacao : MonoBehaviour {

    public Vector3 rotacao = new Vector3(0, 1f, 0);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotacao * Time.deltaTime);

    }
}
