using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskSpawner : MonoBehaviour
{
    public GameObject Mask;

    private void Start() {
        //mouse visible
    }

    void Update()
    {
        Instantiate(Mask, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity, transform);
        
    }
}
