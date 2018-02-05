using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folderIconController : MonoBehaviour {


    public static SpriteRenderer folderIconSprite;
    public static BoxCollider2D folderIconCollider;
    // Use this for initialization
    void Start () {
        folderIconSprite = GetComponent<SpriteRenderer>();
        folderIconCollider = GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        folderIconSprite.enabled = false;
        folderIconCollider.enabled = false;
        skullIconController.skullIconCollider.enabled = true;
        skullIconController.skullIconSprite.enabled = true;
        Debug.Log("folder click");
    }
}
