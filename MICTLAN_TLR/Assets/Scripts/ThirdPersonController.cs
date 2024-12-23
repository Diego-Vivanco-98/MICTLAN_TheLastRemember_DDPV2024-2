using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private Animator playerPegaso;

    // Start is called before the first frame update
    void Start()
    {
        playerPegaso = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPegaso.SetFloat("speed", Input.GetAxis("Vertical"));
        playerPegaso.SetFloat("direction", Input.GetAxis("Horizontal"));

    }
}
