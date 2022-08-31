using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHP_bar : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject boss;
    float time;
    float hp;
    float initial_value;
    float hp_bar;
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss");
    }
    // Update is called once per frame
    void Update()
    {
        if(time < 1)
        {
            time += Time.deltaTime;
            this.GetComponent<Image>().fillAmount = time;
        }
        if(time >= 1)
        {
            initial_value = boss.GetComponent<boss>().max_hp;
            hp = boss.GetComponent<boss>().hp;
            hp_bar = hp / initial_value;
            this.GetComponent<Image>().fillAmount = hp_bar;
        }
    }
}
