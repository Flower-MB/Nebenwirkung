using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
//A class which manages the var Sanity. Moreover, how we get and lose it.
//Depending on its value it affects the font
public class Sanity : MonoBehaviour
{
    //Sanity
    private uint currentSanity = 0;
    public uint currentMood = 1;
    private uint maxSanity;
    private uint newSanity;
    public Slider sanityBar;
    
    //UI imput through Unity
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI uiTextTwo;
    public TextMeshProUGUI uiTextThree;
    public TextMeshProUGUI uiTextFour;
    public TextMeshProUGUI uiTextFive;
    public TextMeshProUGUI uiTextSix;
    public TextMeshProUGUI uiTextSeven;
    public TextMeshProUGUI uiTextEight;
    public TextMeshProUGUI uiTextNine; 
    public TextMeshProUGUI uiTextTen;
    public TextMeshProUGUI uiTextEleven;
    public TextMeshProUGUI uiTextTwelve;
    public TextMeshProUGUI uiTextThirteen;
    public TextMeshProUGUI uiTextForteen;
    public TextMeshProUGUI uiTextFifthteen;
    public TextMeshProUGUI uiTextSixteen;
    public TextMeshProUGUI uiTextSeventeen;
    public TextMeshProUGUI uiTextEighteen;
    public TMP_FontAsset fontMoodOne;
    public TMP_FontAsset fontMoodTwo;
    public TMP_FontAsset fontMoodThree;

    //Button to hid if certain creterias are met
    public Button hideButtonOne;
    public Button hideButtonTwo;
    public Button hideButtonThree;
    public Button hideButtonFour;
    public Button hideButtonFive;
    public Button hideButtonSix;
    public Button hideButtonSeven;
    public Button hideButtonEight;
    
    //To keep the current Sanity through all Scenes.
    private void SaveSanity ()
    {
        ValueToKeep.sanityToKeep = currentSanity;
    }
    private void SaveMood()
    {
        ValueToKeep.moodToKeep = currentMood;
    }

    //Sanity Reset
    public void SanityReset()
    {
        currentSanity = 0;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityResetChapterTwo()
    {
        currentSanity = 20;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityResetChapterThree()
    {
        currentSanity = 40;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }

    //Sanity Loss
    public void SanityLossTest()
    {
        newSanity = currentSanity + 10;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }

    public void SanityLossMinimum()
    {
        newSanity = currentSanity + 1;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityLossMiddle()
    {
        newSanity = currentSanity + 2;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityLossHigher()
    {
        newSanity = currentSanity + 4;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityLossMaximum()
    {
        newSanity = currentSanity + 10;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }
    public void SanityRegain()
    {
        newSanity = currentSanity - 4;
        currentSanity = newSanity;
        sanityBar.value = currentSanity;
        SaveSanity();
        SetMood();
        UpdateUI();
    }

    //Set Character Mood
    public void SetMood()
    {
        if (currentSanity <= 50)
        {
            currentMood = 1;
        }
        else if (currentSanity > 50 && currentSanity <= 75)
        {
            currentMood = 2;
        }
        else if (currentSanity > 75 && currentSanity < 100)
        {
            currentMood = 3;
        }
        else
        {
            currentMood = 4;
        }
        SaveMood();
        UpdateUI();
    }
    //Update the UI to new Font
    public void UpdateUI()
    {
        if (currentMood == 1)
        {

            descriptionText.font = fontMoodOne;
        }
        else if (currentMood == 2)
        {
            descriptionText.font = fontMoodTwo;
        }
        else if (currentMood == 3)
        {
            descriptionText.font = fontMoodThree;
        }
        else if (currentMood == 4)
        {
            //If player Reaches this Mood he should only be able  to use a certain button!
            descriptionText.font = fontMoodThree;
            hideButtonOne.gameObject.SetActive(false);
            hideButtonTwo.gameObject.SetActive(false);
            hideButtonThree.gameObject.SetActive(false);
            hideButtonFour.gameObject.SetActive(false);
            hideButtonFive.gameObject.SetActive(false);
            hideButtonFive.gameObject.SetActive(false);
            hideButtonSix.gameObject.SetActive(false);
            hideButtonSeven.gameObject.SetActive(false);
            hideButtonEight.gameObject.SetActive(false);
        }
        else
        {
            descriptionText.font = fontMoodOne;
        }
        

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSanity = ValueToKeep.sanityToKeep;
        currentMood = ValueToKeep.moodToKeep;
        maxSanity = 100;
        //Sanity Bar updating
        sanityBar.value = currentSanity;
        sanityBar.maxValue = maxSanity;
        //Updating Mood + UI
        SetMood();
        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        sanityBar.value = currentSanity;
        sanityBar.maxValue = maxSanity;
        SetMood();
        UpdateUI();
    }
}
