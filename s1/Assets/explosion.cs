using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy",2);
    }

    // Update is called once per frame
    void Destroy()
    {
        Destroy (this.gameObject);
    }
}
