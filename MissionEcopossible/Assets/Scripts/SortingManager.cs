using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{

    
    public GameObject apple, banana, bottle, glassbottle, ink, lightbulb, magazine, binHarmful, binRecycle, binLandfill, binCompost; // Garbage and bin items


    Vector2 appleInitialPos, bananaInitialPos, bottleInitialPos, glassbottleInitialPos, inkInitialPos, lightbulbInitialPos, magazineInitialPos, binHarmfulInitialPos, binRecycleInitialPos, binLandfillInitialPos, binCompostInitialPos;
    
    // Start is called before the first frame update
    void Start()
    {
        //Position of garbage items
        appleInitialPos = apple.transform.position;
        bananaInitialPos = banana.transform.position;
        bottleInitialPos = bottle.transform.position;
        glassbottleInitialPos = glassbottle.transform.position;
        inkInitialPos = ink.transform.position;
        lightbulbInitialPos = lightbulb.transform.position;
        magazineInitialPos = magazine.transform.position;

        //Position of trash bins
        binHarmfulInitialPos = binHarmful.transform.position;
        binRecycleInitialPos = binRecycle.transform.position;
        binLandfillInitialPos = binLandfill.transform.position;
        binCompostInitialPos = binLandfill.transform.position;

    }


    public void DragApple() {

        apple.transform.position = Input.mousePosition;

    }

    public void DragBanana() {

        banana.transform.position = Input.mousePosition;

    }

    public void DragBottle() {

        bottle.transform.position = Input.mousePosition;

    }

    public void DragGlassbottle() {

        glassbottle.transform.position = Input.mousePosition;

    }

    public void DragInk() {

        ink.transform.position = Input.mousePosition;

    }

    public void DragLightbulb() {

        lightbulb.transform.position = Input.mousePosition;

    }

    public void DragMagazine() {

        magazine.transform.position = Input.mousePosition;

    }
    
    public void DropApple() {

        float Distance = Vector3.Distance(apple.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            apple.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            apple.transform.position = appleInitialPos;
        }
    
    }

    public void DropBanana() {

        float Distance = Vector3.Distance(banana.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            banana.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            banana.transform.position = bananaInitialPos;
        }
    
    }

    public void DropBottle() {

        float Distance = Vector3.Distance(bottle.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            bottle.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            bottle.transform.position = bottleInitialPos;
        }
    
    }

    public void DropGlassbottle() {

        float Distance = Vector3.Distance(glassbottle.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            glassbottle.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            glassbottle.transform.position = glassbottleInitialPos;
        }
    
    }

    public void DropInk() {

        float Distance = Vector3.Distance(ink.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            ink.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            ink.transform.position = inkInitialPos;
        }
    
    }

    public void DropLightbulb() {

        float Distance = Vector3.Distance(lightbulb.transform.position, binHarmful.transform.position);
        if (Distance < 50) {
            lightbulb.transform.position = binHarmful.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            lightbulb.transform.position = lightbulbInitialPos;
        }
    
    }

    public void DropMagazine() {

        float Distance = Vector3.Distance(magazine.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            magazine.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            magazine.transform.position = magazineInitialPos;
        }
    
    }
}
