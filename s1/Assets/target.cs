using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("move");
    }


    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator  move()
    {
        yield return new WaitForSeconds (2f);
        this.transform.position = new Vector3(-200,0,0);
        yield return new WaitForSeconds (2f);
        this.transform.position = new Vector3(0,380,0);
        yield return new WaitForSeconds (2f);
        this.transform.position = new Vector3(200,400,0);
        yield return new WaitForSeconds (2f);
        this.transform.position = new Vector3(0,-400,0);
        yield return new WaitForSeconds (5f);
        Destroy (this.gameObject);
    }
}
