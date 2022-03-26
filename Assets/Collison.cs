using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    [SerializeField]
    Color32 hasPackageColor = new Color32(1,205,20,155);
    [SerializeField]
    Color32 hasNoPackageColor = new Color32(255,255,255,255);
  
    SpriteRenderer spriteRenderer;
    bool hasPackage = false;

    public void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Oh no hit something!");
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "PackageObject" && !hasPackage){
            Debug.Log("Picked up Package!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,.25f);
            
            
        } 
        if(other.tag == "CustomerObject" && hasPackage){
            Debug.Log("Delivered to Customer");
            hasPackage = false;
            spriteRenderer.color = hasNoPackageColor;
        }

       
    }
}
