using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yuru : MonoBehaviour
{
    public GameObject Oyun;
    public GameObject isik;
    public Text HakText;
    private int hak = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        float speed = 20f;
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKeyUp("x"))
        {
            if (hak > 0) 
            {
                GameObject yeni= Instantiate(isik,transform.position,transform.rotation);
                yeni.SetActive(true);
                hak--;
            } 
        }
        HakText.text = hak.ToString();

        transform.position = pos;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hedef")
        {
            Oyun.GetComponent<Panel>().Bitir();
        }
    }
}
