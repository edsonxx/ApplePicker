using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour { 
    [Header("Set in Inspector")]
    public static float bottomY = -20f; // a
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject); // b
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker> (); // b
            apScript.AppleDestroyed();
        }
    }
}
