using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{

    // Garbage and bin items
    public GameObject apple, banana, bottle, glassbottle, ink, lightbulb, magazine, milk, battery, 
    pizzabox, snackbag, straw, styrofoam, teabag, napkin,
    binHarmful, binRecycle, binLandfill, binCompost; 


    // Garbage and bin positions
    Vector2 appleInitialPos, bananaInitialPos, bottleInitialPos, glassbottleInitialPos, inkInitialPos, 
    lightbulbInitialPos, magazineInitialPos, milkInitialPos, batteryInitialPos, pizzaboxInitialPos,
    snackbagInitialPos, strawInitialPos, styrofoamInitialPos, teabagInitialPos, napkinInitialPos,
    binHarmfulInitialPos, binRecycleInitialPos, binLandfillInitialPos, binCompostInitialPos;
    
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
        milkInitialPos = milk.transform.position;
        batteryInitialPos = battery.transform.position;
        pizzaboxInitialPos = pizzabox.transform.position;
        snackbagInitialPos = snackbag.transform.position;
        strawInitialPos = straw.transform.position;
        styrofoamInitialPos = styrofoam.transform.position;
        teabagInitialPos = teabag.transform.position;
        napkinInitialPos = napkin.transform.position;

        //Position of trash bins
        binHarmfulInitialPos = binHarmful.transform.position;
        binRecycleInitialPos = binRecycle.transform.position;
        binLandfillInitialPos = binLandfill.transform.position;
        binCompostInitialPos = binLandfill.transform.position;

    }


    /**
      * Drag item method groups.
      */ 
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

    public void DragMilk() {

        milk.transform.position = Input.mousePosition;

    }

    public void DragBattery() {

        battery.transform.position = Input.mousePosition;

    }

    public void DragPizzabox() {

        pizzabox.transform.position = Input.mousePosition;

    }

    public void DragSnackbag() {

        snackbag.transform.position = Input.mousePosition;

    }

    public void DragStraw() {

        straw.transform.position = Input.mousePosition;

    }

    public void DragStyrofoam() {

        styrofoam.transform.position = Input.mousePosition;

    }

    public void DragTeabag() {

        teabag.transform.position = Input.mousePosition;

    }

    public void DragNapkin() {

        napkin.transform.position = Input.mousePosition;

    }
    
    /**
      * Drop item method groups.
      */  
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
        if (Distance < 100) {
            magazine.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            magazine.transform.position = magazineInitialPos;
        }
    
    }

    public void DropMilk() {

        float Distance = Vector3.Distance(milk.transform.position, binRecycle.transform.position);
        if (Distance < 100) {
            milk.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            milk.transform.position = milkInitialPos;
        }
    
    }

    public void DropBattery() {

        float Distance = Vector3.Distance(battery.transform.position, binHarmful.transform.position);
        if (Distance < 100) {
            battery.transform.position = binHarmful.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            battery.transform.position = batteryInitialPos;
        }
    
    }

    public void DropPizzabox() {

        float Distance = Vector3.Distance(pizzabox.transform.position, binLandfill.transform.position);
        if (Distance < 100) {
            pizzabox.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            pizzabox.transform.position = pizzaboxInitialPos;
        }
    
    }

    public void DropSnackbag() {

        float Distance = Vector3.Distance(snackbag.transform.position, binLandfill.transform.position);
        if (Distance < 100) {
            snackbag.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            snackbag.transform.position = snackbagInitialPos;
        }
    
    }

    public void DropStraw() {

        float Distance = Vector3.Distance(straw.transform.position, binLandfill.transform.position);
        if (Distance < 100) {
            straw.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            straw.transform.position = strawInitialPos;
        }
    
    }

    public void DropStyrofoam() {

        float Distance = Vector3.Distance(styrofoam.transform.position, binLandfill.transform.position);
        if (Distance < 100) {
            styrofoam.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            styrofoam.transform.position = styrofoamInitialPos;
        }
    
    }

    public void DropTeabag() {

        float Distance = Vector3.Distance(teabag.transform.position, binCompost.transform.position);
        if (Distance < 100) {
            teabag.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            teabag.transform.position = teabagInitialPos;
        }
    
    }

    public void DropNapkin() {

        float Distance = Vector3.Distance(napkin.transform.position, binCompost.transform.position);
        if (Distance < 100) {
            napkin.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            napkin.transform.position = napkinInitialPos;
        }
    
    }
}
