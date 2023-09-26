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
        animator.Play("MoveRightAnim");
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayAudio());
        startPos = transform.position;
        rightEndPos = startPos + Vector3.right * 5.0f;
        downEndPos = rightEndPos + Vector3.down * 4.0f;
        leftEndPos = downEndPos + Vector3.left * 5.0f;
        upEndPos = leftEndPos + Vector3.up * 4.0f;

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
                animator.Play("MoveDownAnim");
            }
            else if (currentPos == downEndPos) {
                currentPos = leftEndPos;
                animator.Play("MoveLeftAnim");
            }
            else if (currentPos == leftEndPos) {
                currentPos = upEndPos;
                animator.Play("MoveUpAnim");
            }
            else if (currentPos == upEndPos) {
                currentPos = rightEndPos;
                animator.Play("MoveRightAnim");
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
