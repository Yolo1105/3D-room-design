using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test: MonoBehaviour{
    private void onMouseDrag(){
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        return mousePos;
    }
}
