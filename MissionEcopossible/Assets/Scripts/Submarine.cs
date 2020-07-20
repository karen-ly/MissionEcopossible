using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    public float delta = 1.5f; // Amount to move left and right from the start point
    public float speed = 1f; 
    private Vector3 startPos;
    public GameObject claw;
    public GameObject subBody;
    public GameObject clawExtension;
    public LineRenderer lineRenderer;
    private bool screenPressed;
    public const int clawYMaxThreshold = 2; // maximum y value that claw should not exceed when going up
    public const int clawYMinThreshold = -3; //// minimum y value that claw should not go below when going down

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        claw = GameObject.Find("claw");
        subBody = GameObject.Find("subBody");
        clawExtension = GameObject.Find("clawExtension");
        lineRenderer = clawExtension.GetComponent<LineRenderer> ();
        screenPressed = false;

        // Setting the line renderer endpoints to the subBody and claw respectively
        lineRenderer.SetPosition(0, claw.transform.position);
        lineRenderer.SetPosition(1, subBody.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        SubmarineMoveX();
        ClawMoveY();

        // Updating end points of the line renderer as the subBody and claw move
        lineRenderer.SetPosition(0, claw.transform.position);
        lineRenderer.SetPosition(1, subBody.transform.position);
    }

    void SubmarineMoveX(){
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin (Time.time * speed);
        transform.position = v;
        if(Mathf.Cos (Time.time * speed)>0){
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else{
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void ClawMoveY(){
        // Get whether screen is pressed or not
        foreach(Touch touch in Input.touches){
            if(touch.phase == TouchPhase.Began){
                screenPressed = true;
            }
            else if(touch.phase == TouchPhase.Ended){
                screenPressed = false;
            }
        }

        // Claw movement
        if(screenPressed && (claw.transform.position.y>clawYMinThreshold)){
            claw.transform.Translate(0, -0.05f,0);
        }
        else if(!screenPressed && (claw.transform.position.y<clawYMaxThreshold)){
            claw.transform.Translate(0, 0.05f,0);
        }
    }
}
