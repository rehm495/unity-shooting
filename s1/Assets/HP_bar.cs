using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HP_bar : MonoBehaviour
{
    GameObject text_manager;
    float hp;
    float initial_value;
    float hp_bar;
    // Start is called before the first frame update
    void Start()
    {
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
        initial_value = text_manager.GetComponent<text_manager>().hp;
    }
    // Update is called once per frame
    void Update()
    {
        hp = text_manager.GetComponent<text_manager>().hp;
        hp_bar = hp / initial_value;
        this.GetComponent<Image>().fillAmount = hp_bar;

    }
}
