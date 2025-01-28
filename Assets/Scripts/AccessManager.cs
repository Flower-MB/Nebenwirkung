using UnityEngine;

public class AccessManager
{
    //To give or denie Access to rooms!
    public string passwordForOffice = "CAGED";
    public bool hasPickedUpExitKey = false;
    public bool hasRepairedElevator = false;
    public bool hasPickedArchiveKey = false;
    public bool hasUnlockedOffice = false;

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
