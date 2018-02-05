using UnityEngine;
using System.Collections;

public class exitButtonVictoryController : MonoBehaviour {

    public static SpriteRenderer exitVictoryButtonSprite;
    public static BoxCollider2D exitVictoryButtonCollider;
    // Use this for initialization
    void Start()
    {
        exitVictoryButtonSprite = GetComponent<SpriteRenderer>();
        exitVictoryButtonCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        exitVictoryButtonSprite.enabled = false;
        exitVictoryButtonCollider.enabled = false;
        victoryWindowController.victoryWindowSprite.enabled = false;
        fightWindowController.fightWindowCollider.enabled = false;
        fightWindowController.fightWindowSprite.enabled = false;


    }

}
