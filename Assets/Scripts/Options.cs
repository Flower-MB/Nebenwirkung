using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
//A class which manages our settings (including a slider, which operates the volume of the music)
public class Options : MonoBehaviour
{
    //Sound Options with slider
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
    }
}
