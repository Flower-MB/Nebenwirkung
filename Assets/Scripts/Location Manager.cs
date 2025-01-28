using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LocationManager : MonoBehaviour
{
    public string currentPlace = "Awakening Room";

    private void SaveCurrentPlace()
    {
        ValueToKeep.placeToKeep = currentPlace;
    }

    /*Locations with descriptions (old) still in the script for eventual use:
    Dictionary<string, List<string>> descriptionMoods = new Dictionary<string, List<string>>();
    [SerializeField] TextMeshProUGUI descriptionText;

    public void AddLocation(string location, List<string> description)
    {
          descriptionMoods[location] = description;
    }
    
    public void DisplayText(string location, int currentMood)
    {
        if (descriptionMoods.ContainsKey(location))
        {
            string text = descriptionMoods[location][currentMood];
            descriptionText.text = string.Format(text);
        }

    }

   
    static void Main(string[] args)
    {
        
         * 
        LocationManager locationManager = new LocationManager();
        
        //Chapter 1
        
        //Awakening Room
        locationManager.AddLocation("Aufwachraum", new List<string> { "Ich bin hier im Aufwachraum.", "Ein Raum, in dem ich ich mich gerne umbringen wollte.", "Es stinkt nach frischem Blut." });

        locationManager.DisplayText("Aufwachraum", 0);
        locationManager.DisplayText("Aufwachraum", 1);
        locationManager.DisplayText("Aufwachraum", 2);
        //Basement Corridor
        locationManager.AddLocation("Gang Keller", new List<string> { "Ich bin hier im Gang.", "", "" });

        locationManager.DisplayText("Gang Keller", 0);
        locationManager.DisplayText("Gang Keller", 1);
        locationManager.DisplayText("Gang Keller", 2);
        //Chess
        locationManager.AddLocation("Schach", new List<string> { "", "", "" });

        locationManager.DisplayText("Schach", 0);
        locationManager.DisplayText("Schach", 1);
        locationManager.DisplayText("Schach", 2);
        //Elevator
        locationManager.AddLocation("Fahrstuhl", new List<string> { "", "", "" });

        locationManager.DisplayText("Fahrstuhl", 0);
        locationManager.DisplayText("Fahrstuhl", 1);
        locationManager.DisplayText("Fahrstuhl", 2);
        //Engine Room
        locationManager.AddLocation("Betriebsraum", new List<string> { "", "", "" });

        locationManager.DisplayText("Betriebsraum", 0);
        locationManager.DisplayText("Betriebsraum", 1);
        locationManager.DisplayText("Betriebsraum", 2);
        //Fuse Box
        locationManager.AddLocation("Sicherungskasten", new List<string> { "", "", "" });

        locationManager.DisplayText("Sicherungskasten", 0);
        locationManager.DisplayText("Sicherungskasten", 1);
        locationManager.DisplayText("Sicherungskasten", 2);
        //Library
        locationManager.AddLocation("Bücherei", new List<string> { "", "", "" });

        locationManager.DisplayText("Bücherei", 0);
        locationManager.DisplayText("Bücherei", 1);
        locationManager.DisplayText("Bücherei", 2);
        //Lounge
        locationManager.AddLocation("Aufenthaltsraum", new List<string> { "", "", "" });

        locationManager.DisplayText("Aufenthaltsraum", 0);
        locationManager.DisplayText("Aufenthaltsraum", 1);
        locationManager.DisplayText("Aufenthaltsraum", 2);
        //Piano
        locationManager.AddLocation("Klavier", new List<string> { "", "", "" });

        locationManager.DisplayText("Klavier", 0);
        locationManager.DisplayText("Klavier", 1);
        locationManager.DisplayText("Klavier", 2);

        //Chapter 2

        //Archives
        locationManager.AddLocation("Archive", new List<string> { "", "", "" });

        locationManager.DisplayText("Archive", 0);
        locationManager.DisplayText("Archive", 1);
        locationManager.DisplayText("Archive", 2);
        //Deescalationroom
        locationManager.AddLocation("Deeskalationsraum", new List<string> { "", "", "" });

        locationManager.DisplayText("Deeskalationsraum", 0);
        locationManager.DisplayText("Deeskalationsraum", 1);
        locationManager.DisplayText("Deeskalationsraum", 2);
        //First Floor Corridor
        locationManager.AddLocation("Gang 1. Stock", new List<string> { "", "", "" });

        locationManager.DisplayText("Gang 1. Stock", 0);
        locationManager.DisplayText("Gang 1. Stock", 1);
        locationManager.DisplayText("Gang 1. Stock", 2);
        //Medical Base
        locationManager.AddLocation("Stützpunkt", new List<string> { "", "", "" });

        locationManager.DisplayText("Stützpunkt", 0);
        locationManager.DisplayText("Stützpunkt", 1);
        locationManager.DisplayText("Stützpunkt", 2);
        //Single Room Window
        locationManager.AddLocation("Einzelraum mit Fenster", new List<string> { "", "", "" });

        locationManager.DisplayText("Einzelraum mit Fenster", 0);
        locationManager.DisplayText("Einzelraum mit Fenster", 1);
        locationManager.DisplayText("Einzelraum mit Fenster", 2);
        //Single Room Windowless one
        locationManager.AddLocation("Erster Einzelraum ohne Fenster", new List<string> { "", "", "" });

        locationManager.DisplayText("Erster Einzelraum ohne Fenster", 0);
        locationManager.DisplayText("Erster Einzelraum ohne Fenster", 1);
        locationManager.DisplayText("Erster Einzelraum ohne Fenster", 2);
        //Single Room Windowless two
        locationManager.AddLocation("Zweiter Einzelraum ohne Fenster", new List<string> { "", "", "" });

        locationManager.DisplayText("Zweiter Einzelraum ohne Fenster", 0);
        locationManager.DisplayText("Zweiter Einzelraum ohne Fenster", 1);
        locationManager.DisplayText("Zweiter Einzelraum ohne Fenster", 2);
        //Single Room Windowless three
        locationManager.AddLocation("Dritter Einzelraum ohne Fenster", new List<string> { "", "", "" });

        locationManager.DisplayText("Dritter Einzelraum ohne Fenster", 0);
        locationManager.DisplayText("Dritter Einzelraum ohne Fenster", 1);
        locationManager.DisplayText("Dritter Einzelraum ohne Fenster", 2);

        //Chapter 3

        //Ground Floor Coridor
        locationManager.AddLocation("Gang Erdgeschoss", new List<string> { "Ich bin hier im Gang.", "", "" });

        locationManager.DisplayText("Gang Erdgeschoss", 0);
        locationManager.DisplayText("Gang Erdgeschoss", 1);
        locationManager.DisplayText("Gang Erdgeschoss", 2);
        //Exit
        locationManager.AddLocation("Ausgang", new List<string> { "", "", "" });

        locationManager.DisplayText("Ausgang", 0);
        locationManager.DisplayText("Ausgang", 1);
        locationManager.DisplayText("Ausgang", 2);
        //Office
        locationManager.AddLocation("Büro", new List<string> { "", "", "" });

        locationManager.DisplayText("Büro", 0);
        locationManager.DisplayText("Büro", 1);
        locationManager.DisplayText("Büro", 2);
        //Reception
        locationManager.AddLocation("Rezeption", new List<string> { "", "", "" });

        locationManager.DisplayText("Rezeption", 0);
        locationManager.DisplayText("Rezeption", 1);
        locationManager.DisplayText("Rezeption", 2);
        //Vending Machine
        locationManager.AddLocation("Getränke Automat", new List<string> { "", "", "" });

        locationManager.DisplayText("Getränke Automat", 0);
        locationManager.DisplayText("Getränke Automat", 1);
        locationManager.DisplayText("Getränke Automat", 2);
        
}*/

    //Chapter 1 Room Loading
    public void AwakeningRoom()
    {
        currentPlace = "Awakening Room";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(1);

    }
    public void BasmentCorridor()
    {
        currentPlace = "Basement Corridor";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(7);
    }
    public void Elevator() 
    {
        currentPlace = "Elevator";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(6);
    }
    public void EngineRoom()
    {
        currentPlace = "Engine Room";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(8);
    }
    public void FuseBox()
    {
        currentPlace = "Fuse Box";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(9);
    }
    public void Lounge()
    {
        currentPlace = "Lounge";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(10);
    }
    public void Piano()
    {
        currentPlace = "Piano";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(11);
    }
    public void Chess()
    {
        currentPlace = "Chess";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(12);
    }
    public void Library()
    {
        currentPlace = "Library";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(13);
    }
    //Chapter 2 Room Loading
    public void FirstFloorCorridor()
    {
        currentPlace = "1st Florr Corridor";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(4);
    }
    public void Archives()
    {
        currentPlace = "Archive";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(15);
    }
    public void DeescalationRoom()
    {
        currentPlace = "Deescalation Room";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(16);
    }
    public void MedicalBase()
    {
        currentPlace = "Medical Base";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(17);
    }
    public void SingleRoomWindow()
    {
        currentPlace = "Windowless Room 1";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(18);
    }
    public void SingleRoomWindowlessOne()
    {
        currentPlace = "Windowless Room 2";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(19);
    }
    public void SingleRoomWindowlessTwo()
    {
        currentPlace = "Windowless Room 3";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(20);
    }
    public void SingleRoomWindowlessThree()
    {
        currentPlace = "Windowless Room 4";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(21);
    }
    //Chapter 3 Room Loading
    public void GroundFloorCorridor()
    {
        currentPlace = "Ground Floor Corridor";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(5);
    }
    public void Exit()
    {
        currentPlace = "Exit";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(22);
    }
    public void Office()
    {
        currentPlace = "Office";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(23);
    }
    public void Reception()
    {
        currentPlace = "Reception";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(24);
    }
    public void VendingMaschine()
    {
        currentPlace = "Vending Machine";
        SaveCurrentPlace();
        SceneManager.LoadSceneAsync(25);
    }

}
