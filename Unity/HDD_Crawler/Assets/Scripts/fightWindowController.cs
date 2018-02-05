using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightWindowController : MonoBehaviour {
    int attackCount;
    public static SpriteRenderer fightWindowSprite;
    public static BoxCollider2D fightWindowCollider;
    // Use this for initialization
    void Start()
    {
        fightWindowSprite = GetComponent<SpriteRenderer>();
        fightWindowCollider = GetComponent<BoxCollider2D>();
    }


    // Update is called once per frame
    void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("BOOM BOOM TRACH");
        
        attackCount++;
        if (attackCount == 5)
        {
            fightWindowCollider.enabled = false;
            fightWindowSprite.enabled = false;
            skullIconController.skullIconCollider.enabled = false;
            skullIconController.skullIconSprite.enabled = false;
        }
    }
}
