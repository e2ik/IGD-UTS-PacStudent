using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int state = 0;

    public float cycleTime = 3f;

    private void Start() {
        animator = GetComponent<Animator>();
        StartCoroutine(CycleStates());
    }

    private IEnumerator CycleStates() {
        while (true) {
            state = (state + 1) % 4;
            animator.SetBool("movingLeft", false);
            animator.SetBool("movingRight", false);
            animator.SetBool("movingDown", false);
            animator.SetBool("movingUp", false);

            switch (state) {
                case 0: animator.SetBool("movingLeft", true); break;
                case 1: animator.SetBool("movingDown", true); break;
                case 2: animator.SetBool("movingRight", true); break;
                case 3: animator.SetBool("movingUp", true); break;
            }
            yield return new WaitForSeconds(cycleTime);
        }
    }
}
