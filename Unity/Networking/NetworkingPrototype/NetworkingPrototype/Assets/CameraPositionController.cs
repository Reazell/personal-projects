using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraPositionController : NetworkBehaviour {

	public bool manualCameraPositionControl;
	[SerializeField] GameObject player;
	[SerializeField] private NetworkIdentity networkIdentity;
	Transform cameraContainer;
	float xPosition;
	float yPosition;
	float zPosition;

	void Start() {
		cameraContainer = GetComponent<Transform>();
	}
	public void AdjustPositionX(float newXPosition) {
		xPosition = newXPosition;
	}
	public void AdjustPositionY(float newYPosition) {
		yPosition = newYPosition;
	}
	public void AdjustPositionZ(float newZPosition) {
		zPosition = newZPosition;
	}

	void Update() {
		if (player.tag == "Player") {
			if (manualCameraPositionControl) {
				var newPosition = new Vector3(xPosition, yPosition, zPosition);
				player.transform.position = newPosition;
			}
		}
	}
}
