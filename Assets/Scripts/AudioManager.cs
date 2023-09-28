using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;

using UnityEngine;

public class StartMusicThenGhost : MonoBehaviour
{
    [SerializeField] private AudioClip intro;
    [SerializeField] private AudioClip ghostMusic;
    public UnityEvent onGhostStart;
    private AudioSource clips;
    void Start()
    {
        clips = GetComponent<AudioSource>();
        StartCoroutine(delayAfterStart());
    }

    private IEnumerator delayAfterStart() {

        clips.clip = intro;
        clips.Play();

        yield return new WaitForSeconds(1.5f);

        clips.clip = ghostMusic;
        clips.loop = true;
        clips.Play();
        onGhostStart.Invoke();
    }
}
