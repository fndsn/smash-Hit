using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider contact)
    {
        if (contact.gameObject.CompareTag("MainCamera"))
            Destroy(gameObject);
        if (contact.gameObject)
            Destroy(gameObject);

    }
}
