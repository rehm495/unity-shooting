using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama2_highspped : MonoBehaviour
{ 
    public static GameObject text_manager;
    // Start is called before the first frame update
    void Start()
    {
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,-15,0);
        if(this.transform.position.y<= -700||this.transform.position.y>= 700||this.transform.position.x<= -700||this.transform.position.x>= 700)
        {
           Destroy (this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.gameObject.tag == "text_manager")
        {
            text_manager.GetComponent<text_manager>().Damage();
            Destroy (this.gameObject);
        }
	}
    
}