using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip _plusPoints, _losePoints, _loseLife;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        _plusPoints = Resources.Load<AudioClip>("plusPoints");
        _losePoints = Resources.Load<AudioClip>("losePoints");
        _loseLife = Resources.Load<AudioClip>("loseLife");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case"plusPoints":
                audioSrc.PlayOneShot(_plusPoints);
                break;
            case"losePoints":
                audioSrc.PlayOneShot(_losePoints);
                break;
            case "loseLife":
                audioSrc.PlayOneShot(_loseLife);
                break;

        }
    }
}
