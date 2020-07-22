using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Submarine : MonoBehaviour
{
    public float delta; // Amount to move left and right from the start point
    public float subSpeed; 
    public float clawSpeed; 
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

        // Settings based on level
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "SubmarineGameL2"){
            delta = 1.8f;
            subSpeed = 1f;
            clawSpeed = 0.08f;
        }

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
        v.x += delta * -Mathf.Sin (Time.time * subSpeed);
        transform.position = v;

        // Flips the image of the sub when it changes direction
        if(-Mathf.Cos (Time.time * subSpeed)>0){
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else{
            transform.localRotation = Quaternion.Euler(0, 0, 0);
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
            claw.transform.Translate(0, -clawSpeed,0);
        }
        else if(!screenPressed && (claw.transform.position.y<clawYMaxThreshold)){
            claw.transform.Translate(0, clawSpeed,0);
        }
    }
}
