
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Adventure 1980 v2020.11.16
//
// created 2020.11.16
//


public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 3f;

    private float h;
    private float v;


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        KeyboardController();

        MovePlayer();
    }


    private void KeyboardController()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }


    private void MovePlayer()
    {
        transform.Translate(new Vector2(h, v) * playerSpeed * Time.deltaTime);
    }


} // end of class
