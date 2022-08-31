using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama : MonoBehaviour
{
    [SerializeField]float shot_speed;  //弾速
    public static GameObject teki;
    // Start is called before the first frame update
    void Start()
    {
        teki = GameObject.FindGameObjectWithTag("teki");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,40,0);
        if (transform.position.y > 700)
        {
			Destroy (gameObject);
        }
    }
    
}
