using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    private bool slowMo = false;
    [SerializeField] Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           animator.SetInteger("Status", (animator.GetInteger("Status") + 1) % 4);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            slowMo = !slowMo;

            if (slowMo)
            {
                animator.speed = 0.5f;
            }
            else
            {
                animator.speed = 1f;
            }
        }
    }
}
