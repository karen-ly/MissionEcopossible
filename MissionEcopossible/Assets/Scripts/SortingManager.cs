﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{

    public GameObject wrongInfoBox;
    public GameObject finalPanel;
    private int count = 0;
    private int targetCount = 15;

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
      * Close wrong info box.
      */
      public void closeWrongInfoBox() {
          wrongInfoBox.SetActive(false);
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
            count++;
            Destroy(apple);
            // apple.transform.position = binCompost.transform.position;
        } else {
            // If sorting is wrong, destroy the item
            apple.transform.position = appleInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropBanana() {

        float Distance = Vector3.Distance(banana.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(banana);
            // banana.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            banana.transform.position = bananaInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    }

    public void DropBottle() {

        float Distance = Vector3.Distance(bottle.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(bottle);
            // bottle.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            bottle.transform.position = bottleInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropGlassbottle() {

        float Distance = Vector3.Distance(glassbottle.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(glassbottle);
            // glassbottle.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            glassbottle.transform.position = glassbottleInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropInk() {

        float Distance = Vector3.Distance(ink.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(ink);
            // ink.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            ink.transform.position = inkInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropLightbulb() {

        float Distance = Vector3.Distance(lightbulb.transform.position, binHarmful.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(lightbulb);
            // lightbulb.transform.position = binHarmful.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            lightbulb.transform.position = lightbulbInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropMagazine() {

        float Distance = Vector3.Distance(magazine.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(magazine);
            // magazine.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            magazine.transform.position = magazineInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropMilk() {

        float Distance = Vector3.Distance(milk.transform.position, binRecycle.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(milk);
            // milk.transform.position = binRecycle.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            milk.transform.position = milkInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropBattery() {

        float Distance = Vector3.Distance(battery.transform.position, binHarmful.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(battery);
            // battery.transform.position = binHarmful.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            battery.transform.position = batteryInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropPizzabox() {

        float Distance = Vector3.Distance(pizzabox.transform.position, binLandfill.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(pizzabox);
            // pizzabox.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            pizzabox.transform.position = pizzaboxInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropSnackbag() {

        float Distance = Vector3.Distance(snackbag.transform.position, binLandfill.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(snackbag);
            // snackbag.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            snackbag.transform.position = snackbagInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropStraw() {

        float Distance = Vector3.Distance(straw.transform.position, binLandfill.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(straw);
            // straw.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            straw.transform.position = strawInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropStyrofoam() {

        float Distance = Vector3.Distance(styrofoam.transform.position, binLandfill.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(styrofoam);
            // styrofoam.transform.position = binLandfill.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            styrofoam.transform.position = styrofoamInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    }

    public void DropTeabag() {

        float Distance = Vector3.Distance(teabag.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(teabag);
            // teabag.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            teabag.transform.position = teabagInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }

    public void DropNapkin() {

        float Distance = Vector3.Distance(napkin.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            count++;
            Destroy(napkin);
            // napkin.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, destroy the item
            napkin.transform.position = napkinInitialPos;
            wrongInfoBox.SetActive(true);
        }
        // check if user has correctly sorted all items, if so end game with pop up
        if (count == targetCount) {
            finalPanel.SetActive(true);
        }
    
    }
}
