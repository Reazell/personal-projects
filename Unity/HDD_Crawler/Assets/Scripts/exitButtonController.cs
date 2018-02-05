using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButtonController : MonoBehaviour {

    public static SpriteRenderer exitButtonSprite;
    public static BoxCollider2D exitButtonCollider;
	// Use this for initialization
	void Start () {
        exitButtonSprite = GetComponent<SpriteRenderer>();
        exitButtonCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        mainWindowController.mainWindow.enabled = false;
        exitButtonSprite.enabled = false;
        exitButtonCollider.enabled = false;
        folderIconController.folderIconCollider.enabled = false;
        folderIconController.folderIconSprite.enabled = false;
        skullIconController.skullIconCollider.enabled = false;
        skullIconController.skullIconSprite.enabled = false;
    }
}
