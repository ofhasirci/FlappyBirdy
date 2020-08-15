using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource[] audios;
    private AudioSource flap;
    private AudioSource score;
    private AudioSource die;


    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponents<AudioSource>();

        flap = audios[0];
        score = audios[1];
        die = audios[2];

    }
    
    public void FlapSound()
    {
        flap.Play();
    }

    public void ScoreSound()
    {
        score.Play();
    }

    public void DieSound()
    {
        die.Play();
    }
}
