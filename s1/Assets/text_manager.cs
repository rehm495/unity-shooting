using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_manager : MonoBehaviour
{
    public int hp;
    public GameObject hp_object;
    // Start is called before the first frame update
    void Awake()
    {
        hp = 100;
    }
    // Update is called once per frame
    void Update()
    {
        Text hp_text = hp_object.GetComponent<Text> ();
        hp_text.text = "" + hp;
        hp = Mathf.Clamp(hp,0,100000);
    }

    public void Damage()
    {
        hp--;
    }
}
