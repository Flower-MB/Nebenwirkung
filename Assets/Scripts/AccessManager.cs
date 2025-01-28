using UnityEngine;
//A class which manages wether or not you are allowed to enter a location
public class AccessManager
{
    //To give or denie Access to rooms!
    public string passwordForOffice = "CAGED";
    public bool hasPickedUpExitKey = false;
    public bool hasRepairedElevator = false;
    public bool hasPickedArchiveKey = false;
    public bool hasUnlockedOffice = false;
    //methods which change the boolean value, in order to make locations accessible
    public void PickUpExitKey()
    {
        hasPickedUpExitKey = true;
    }
    public void RepairElevator()
    {
        hasRepairedElevator = true;
    }
    public void HasPickedUpArchiveKey()
    {
        hasPickedArchiveKey = true;
    }

}
