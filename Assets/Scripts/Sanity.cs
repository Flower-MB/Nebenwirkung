using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Sanity : MonoBehaviour
{
    //Sanity
    private uint currentSanity = 0;
    public uint currentMood = 0;
    private uint maxSanity;
    private uint newSanity;
    public Slider sanityBar;
    
    //UI imput
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
    
    private void SaveSanity ()
    {
        ValueToKeep.sanityToKeep = currentSanity;
    }
    private void SaveMood()
    {
        ValueToKeep.moodToKeep = currentMood;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSanity = ValueToKeep.sanityToKeep;
        currentMood = ValueToKeep.moodToKeep;
        maxSanity = 100;
        sanityBar.value = currentSanity;
        sanityBar.maxValue = maxSanity;
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

    //Set Character Mood
    public void SetMood()
    {
        if (currentSanity <= 50)
        {
            currentMood = 0;
        }
        else if (currentSanity > 50 && currentSanity <= 75)
        {
            currentMood = 1;
        }
        else if (currentSanity > 75 && currentSanity < 100)
        {
            currentMood = 2;
        }
        else
        {
            currentMood = 3;
        }
        SaveMood();
        UpdateUI();
    }
    //Actualise the UI
    public void UpdateUI()
    {
        if (currentMood == 0)
        {

            descriptionText.font = fontMoodOne;
        }
        else if (currentMood == 1)
        {
            descriptionText.font = fontMoodTwo;
        }
        else if (currentMood == 2)
        {
            descriptionText.font = fontMoodThree;
        }
        else if (currentMood == 3)
        {

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
    // Update is called once per frame
    void Update()
    {

    }
}
