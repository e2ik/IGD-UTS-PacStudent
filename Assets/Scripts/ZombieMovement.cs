using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
    private Animator animator;
    private AudioSource audioSource;
    private Vector3 startPos;
    private Vector3 rightEndPos;
    private Vector3 downEndPos;
    private Vector3 leftEndPos;
    private Vector3 upEndPos;
    private Vector3 currentPos;
    public float moveSpeed;
    private float moveLength;
    private float moveStartTime;

    void Start() {
        moveSpeed = 3.0f;
        animator = GetComponent<Animator>();
        animator.SetBool("movingRight", true);
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayAudio());
        startPos = transform.position;
        rightEndPos = startPos + Vector3.right * 5.0f;
        downEndPos = rightEndPos + Vector3.down * 4.0f;
        leftEndPos = downEndPos + Vector3.left * 5.0f;
        upEndPos = leftEndPos + Vector3.up * 4.0f;
        moveSpeed = 3.0f;

        currentPos = rightEndPos;
        moveLength = Vector3.Distance(startPos, currentPos);
        moveStartTime = Time.time;
    }

    void Update() {
        float moveDistance = (Time.time - moveStartTime) * moveSpeed;

        if (moveDistance >= moveLength) {
            moveStartTime = Time.time;
            startPos = transform.position;

            if (currentPos == rightEndPos) {
                currentPos = downEndPos;
                animator.SetBool("movingRight", false);
                animator.SetBool("movingDown", true);
            }
            else if (currentPos == downEndPos) {
                currentPos = leftEndPos;
                animator.SetBool("movingDown", false);
                animator.SetBool("movingLeft", true);
            }
            else if (currentPos == leftEndPos) {
                currentPos = upEndPos;
                animator.SetBool("movingLeft", false);
                animator.SetBool("movingUp", true);
            }
            else if (currentPos == upEndPos) {
                currentPos = rightEndPos;
                animator.SetBool("movingUp", false);
                animator.SetBool("movingRight", true);
            }
            moveLength = Vector3.Distance(startPos, currentPos);
        }
        else {
            float lerpFraction = moveDistance / moveLength;
            transform.position = Vector3.Lerp(startPos, currentPos, lerpFraction);
        }
    }
    private IEnumerator PlayAudio() {
        yield return new WaitForSeconds(0.0f);
        if (audioSource != null) {
            audioSource.Play();
        }
    }
    
}
