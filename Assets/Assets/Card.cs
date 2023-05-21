using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] 
    Sprite faceUpSprite; 
    [SerializeField] 
    Sprite faceDownSprite; 
    [SerializeField]
    string rank;
     [SerializeField]
    string suit;
     [SerializeField]
    bool faceUp;
    SpriteRenderer spriteRenderer; 


    // checking when we click or not

    void Start(){
          spriteRenderer = GetComponent<SpriteRenderer>();
          
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            faceUp = !faceUp;
        }

        if(faceUp){
             spriteRenderer.sprite = faceUpSprite; 
        }
        else{
             spriteRenderer.sprite = faceDownSprite; 
        }
    }
}
