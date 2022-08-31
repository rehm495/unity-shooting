using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikei : MonoBehaviour
{
     [SerializeField] float y_size;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,y_size/2-540,1);//初期位置を設定
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed,0);
        if (transform.position.y < -y_size/2+540)
        {
            transform.position = new Vector3(0,y_size/2-540,1);//初期位置に戻す
        }
    }
}
