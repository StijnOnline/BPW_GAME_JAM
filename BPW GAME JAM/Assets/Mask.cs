using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public float decay;
    private float count;
    private Vector3 startscale;

    private void Start() {
        startscale = transform.localScale;
    }

    void Update()
    {
        transform.localScale = startscale * (decay - count) / decay;
        count += Time.deltaTime;
        if(count > decay) {
            Destroy(gameObject);
        }
    }
}
