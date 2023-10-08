using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class horsekontrol : MonoBehaviour

{
    private Rigidbody playerRb;
    public Button btn;
    public Text zaman, score,enemy,polygon,durumm;
    float zamanSayaci=100f;
    int enemySayaci=20;
    int polygonSayaci = 10;
    int topscore = 0;
    int scorenemy = 0;
    int scorepolygon = 0;

    bool oyunDevam = true;
    bool oyunTamam = false;
    
    private Animator animator;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    public float speed = 20f;
    RaycastHit hit;

    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";

            Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
            transform.position += hizEklentisi;
        }
        else if (!oyunTamam)
        {
            durumm.text = "PUANIN: " +topscore + "BÝR DAHAKÝ SEFERE ASKER";
            btn.gameObject.SetActive(true);

        }
        if (zamanSayaci < 0)
        {
            oyunDevam = false;
        }
        if (topscore == 100)
        {
            oyunTamam = true;
            durumm.text = "BAÞARDIN ASKER";
            btn.gameObject.SetActive(true);
        }

        

        void Update()
        {
           /* if (Input.GetMouseButton(0))
            {
                if (Physics.Raycast(Camera.main.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
                {
                    Debug.DrawRay(Camera.main.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                    if (hit.collider.gameObject.tag == "enemyy")
                    {
                        Destroy(hit.collider.gameObject);
                        enemySayaci--;
                        enemy.text = enemySayaci + "";

                    }
                    if (hit.collider.gameObject.tag == "polygon")
                    {
                        Destroy(hit.collider.gameObject);

                    }
                }
            }*/
        }
    }
    private void FixedUpdate()
    {
        if (oyunDevam && !oyunTamam)
        {
            if (Input.GetMouseButton(0))
            {
                if (Physics.Raycast(Camera.main.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
                {
                    Debug.DrawRay(Camera.main.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                    if (hit.collider.gameObject.tag == "enemyy")
                    {
                        Destroy(hit.collider.gameObject);
                        enemySayaci--;
                        enemy.text = enemySayaci + "";
                        scorenemy += 4;
                        //topscore=scorenemy
                      

                    }
                    if (hit.collider.gameObject.tag == "polygon")
                    {
                        Destroy(hit.collider.gameObject);
                        polygonSayaci--;
                        polygon.text = polygonSayaci + "";

                        scorepolygon += 2;

                    }
                    topscore = scorepolygon + scorenemy;
                    score.text = topscore + "";
                }
            }
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("backleft", true);
                animator.SetBool("backright", true);
                transform.Translate(new Vector3(0, 0, 5f) * Time.deltaTime);
            }
            else
            {
                animator.SetBool("bacleft", false);
                animator.SetBool("backright", false);

            }

          
        }
        else
        {
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
        }
    }
    
}

