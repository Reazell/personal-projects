using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMapCamera : MonoBehaviour {

    private Transform swivel, stick;

    private float zoom = 1f;

    public float stickMinZoom, stickMaxZoom;


    void Awake() {
        swivel = transform.GetChild(0);
        stick = swivel.GetChild(0);
    }

    void Update() {
        float zoomDelta = Input.GetAxis("Mouse ScrollWheel");
        if (zoomDelta != 0f) {
            AdjustZoom(zoomDelta);
        }
    }

    private void AdjustZoom(float delta) {
        zoom = Mathf.Clamp01(zoom + delta);

        float distance = Mathf.Lerp(stickMinZoom, stickMaxZoom, zoom);
        stick.localPosition = new Vector3(0f, 0f, distance);
    }
}
