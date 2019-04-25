using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonActivator : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision) {
        transform.parent.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        transform.parent.GetComponent<BoxCollider2D>().enabled = false;
    }
}
