using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerIconSprite : MonoBehaviour {
    

    void OnMouseDown()
    {
        mainWindowController.mainWindow.enabled = true;
        exitButtonController.exitButtonSprite.enabled = true;
        exitButtonController.exitButtonCollider.enabled = true;
        folderIconController.folderIconSprite.enabled = true;
        folderIconController.folderIconCollider.enabled = true;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
