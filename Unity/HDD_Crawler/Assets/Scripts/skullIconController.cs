using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullIconController : MonoBehaviour {

    public static SpriteRenderer skullIconSprite;
    public static BoxCollider2D skullIconCollider;

    // Use this for initialization
    void Start () {
        skullIconSprite = GetComponent<SpriteRenderer>();
        skullIconCollider = GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        fightWindowController.fightWindowCollider.enabled = true;
        fightWindowController.fightWindowSprite.enabled = true;
        Debug.Log("FIGHT");
    }
}
