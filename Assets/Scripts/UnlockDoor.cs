using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    [SerializeField] GameObject door = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Key")) {
            if (door.activeInHierarchy)
            {
                door.SetActive(false);
            }
        }
    }
}
