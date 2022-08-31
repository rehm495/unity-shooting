using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teki1 : MonoBehaviour

{
    public static GameObject player;
    float rotate ;
    [SerializeField]float x_speed ;
    float y_speed ;
    float TIME;
    [SerializeField] private GameObject tama;
    public Vector3 target;
    public GameObject text_manager;
    public float hp;
    public GameObject explosion_effect;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
        StartCoroutine ("shot");
    }

    // Update is called once per frame
    void Update()
    {
        rotate = Mathf.Sin(Time.time*3);
        y_speed += 3*Time.deltaTime;

        Vector3 localAngle = this.transform.localEulerAngles;
        
        this.transform.Translate(x_speed,-5+y_speed,0,Space.World);

        if (transform.position.y > 700)
        {
			Destroy (gameObject);
        }

        this.transform.Rotate (0, 0, rotate);

        target = (this.transform.position - player.transform.position);
        if(hp <= 0)
        {
            Instantiate(explosion_effect, transform.position, Quaternion.identity);
            Destroy (gameObject);
        }
    }
    private IEnumerator  shot()
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,-10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target));
        yield return new WaitForSeconds(0.5f);
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,-10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target));
        yield return new WaitForSeconds(0.5f);
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target) * Quaternion.Euler(0,0,-10));
        Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target));
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.gameObject.tag == "Player")
        {
            text_manager.GetComponent<text_manager>().Damage();
            hp--;
        }
        if (coll.gameObject.tag == "ziki_tama")
        {
            Destroy (coll.gameObject);
		    hp--;
        }
	}
}
