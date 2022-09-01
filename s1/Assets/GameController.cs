using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject teki1;
    public GameObject inverted_teki1;
    public GameObject teki2;
    public GameObject target;
    public GameObject target2;
    public GameObject teki3; 
    public GameObject teki4;
    public GameObject teki5;
    public GameObject boss,ziki,ziki_right,ziki_left;
    public GameObject message,bossHP_bar,boss_name;
    public GameObject ziki_tatie;
    public GameObject teki_tatie;
    int rnd;
    public int boss_term;
    int boss_appear;

    // Start is called before the first frame update
    void Awake() 
    {
        StartCoroutine ("teki1_Appearance");
        Application.targetFrameRate = 60; //60FPSに設定
    }

    // Update is called once per frame
    void Update()
    {
        rnd = Random.Range(450, -450);
        if(boss_appear == 1)
        {
            boss = GameObject.FindGameObjectWithTag("boss");
            boss_term = boss.gameObject.GetComponent<boss_move>().boss_term;
            if(boss_term == 1)
            {
                message.gameObject.SetActive(true);
                ziki_tatie.gameObject.SetActive(true);
                teki_tatie.gameObject.SetActive(true);
                boss_name.gameObject.SetActive(true);
                ziki.GetComponent<ziki>().enabled = false;
                ziki_right.GetComponent<ziki_right>().enabled = false;
                ziki_left.GetComponent<ziki_left>().enabled = false;
            }
            if(boss_term == 2)
            {
                message.gameObject.SetActive(false);
                ziki_tatie.gameObject.SetActive(false);
                teki_tatie.gameObject.SetActive(false);
                bossHP_bar.gameObject.SetActive(true);
                ziki.GetComponent<ziki>().enabled = true;
                ziki_right.GetComponent<ziki_right>().enabled = true;
                ziki_left.GetComponent<ziki_left>().enabled = true;
            }
        }
    }

    private IEnumerator teki1_Appearance()
    {
        yield return new WaitForSeconds (2f);
        Instantiate(teki1, new Vector3( 600, 600, -1), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(teki1, new Vector3( 600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(teki1, new Vector3( 600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(teki1, new Vector3( 600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (5f);
        Instantiate(target2, new Vector3( 300, 400, 0), Quaternion.identity);//オブジェクト「target」を生成
        yield return new WaitForSeconds (0.1f);
        Instantiate(teki2, new Vector3( -600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( -600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( -600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( -600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( -600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (5f);
        Instantiate(inverted_teki1, new Vector3( -600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(inverted_teki1, new Vector3( -600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(inverted_teki1, new Vector3( -600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (0.5f);
        Instantiate(inverted_teki1, new Vector3( -600, 600, 0), Quaternion.identity);//オブジェクト「teki1」を生成
        yield return new WaitForSeconds (5f);
        Instantiate(target, new Vector3( -300, 400, 0), Quaternion.identity);//オブジェクト「target2」を生成
        yield return new WaitForSeconds (0.1f);
        Instantiate(teki2, new Vector3( 600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( 600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( 600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( 600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (0.07f);
        Instantiate(teki2, new Vector3( 600, 500, 0), Quaternion.identity);//オブジェクト「teki2」を生成
        yield return new WaitForSeconds (5);
        Instantiate(teki3, new Vector3( 400, 600, 0), Quaternion.identity);//オブジェクト「teki3」を生成
        Instantiate(teki3, new Vector3( -400, 600, 0), Quaternion.identity);//オブジェクト「teki3」を生成
        yield return new WaitForSeconds (15);
        Instantiate(teki4, new Vector3( 0, 600, 0), Quaternion.identity);//オブジェクト「teki3」を生成
        yield return new WaitForSeconds (0.25f);
        Instantiate(teki4, new Vector3( 400, 600, 0), Quaternion.identity);//オブジェクト「teki4」を生成
        Instantiate(teki4, new Vector3( -400, 600, 0), Quaternion.identity);//オブジェクト「teki4」を生成
        yield return new WaitForSeconds (15);
        Instantiate(teki5, new Vector3( rnd, 500, 0), Quaternion.identity);//オブジェクト「teki5」を生成
        yield return new WaitForSeconds (1);
        Instantiate(teki5, new Vector3( rnd, 500, 0), Quaternion.identity);//オブジェクト「teki5」を生成
        yield return new WaitForSeconds (1f);
        Instantiate(teki5, new Vector3( rnd, 500, 0), Quaternion.identity);//オブジェクト「teki5」を生成
        yield return new WaitForSeconds (1);
        Instantiate(teki5, new Vector3( rnd, 500, 0), Quaternion.identity);//オブジェクト「teki5」を生成
        yield return new WaitForSeconds (1);
        Instantiate(teki5, new Vector3( rnd, 500, 0), Quaternion.identity);//オブジェクト「teki5」を生成
        yield return new WaitForSeconds (0.7f);
        Instantiate(boss, new Vector3( 550, 300, 0), Quaternion.identity);//オブジェクト「boss」を生成
        boss_appear = 1;
    }
}
