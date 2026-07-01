using UnityEngine;

public class CubeAnimController : MonoBehaviour
{

    private Animator cubeAnimator;

    private void Awake()
    {
        cubeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cubeAnimator.SetInteger("PlayerScore", 13);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            cubeAnimator.SetBool("isReady", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            cubeAnimator.SetBool("isReady", false);
        }

        if( Input.GetKeyDown(KeyCode.D))
        {
            cubeAnimator.SetTrigger("activate");
        }
    }
}
