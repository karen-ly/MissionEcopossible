using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawCollide : MonoBehaviour
{
    private bool isTouched;
    // Start is called before the first frame update
    void Start()
    {
        isTouched=false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool IsPickedUp(){
        return isTouched;
    }

    void OnTriggerEnter2D(Collider2D other){
        isTouched=true;
    }
}
