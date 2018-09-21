using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
	void Update () {
        Vector3 mousePos2D = Input.mousePosition; //
        
// The Camera's z position sets how far to push the mouse into 3D
mousePos2D.z = -
Camera.main.transform.position.z; // b
                                  // Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); // c
                                                                         // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }
    void OnCollisionEnter(Collision coll)
    { // a
      // Find out what hit this basket
        GameObject collidedWith = coll.gameObject; // b
        if (collidedWith.tag == "Apple")
        { // c
            Destroy(collidedWith);
        }
    }
}

