using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkwin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winmessage;
    void Start()
    {
        winmessage.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if(winmessage.activeInHierarchy)
            winmessage.SetActive(true);
        }
    }
}
