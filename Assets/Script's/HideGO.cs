using System;
using UnityEngine;

public class HideGO : MonoBehaviour {
    void Update () {
     if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.x, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
            {
                if (_hit.transform.tag == "DestroyObject")
                Destroy(_hit.transform.gameObject);
            }
        }
    }
}
