using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bul : MonoBehaviour
{
    public GameObject Hedef;

    public NavMeshAgent Bulucu;

    public bool denetim;

    // Start is called before the first frame update
    void Start()
    {
        denetim = true;
        GetComponent<Light>().range = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (denetim)
        {
            Bulucu.SetDestination(Hedef.GetComponent<Transform>().position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hedef") 
        {
            denetim = false;
            gameObject.SetActive(false);
        }
        
    }
    
}
