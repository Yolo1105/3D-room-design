using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag: MonoBehaviour{
    private void onMouseDrag(){
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        mousePos.z = 0;

        return mousePos;
    }
}
