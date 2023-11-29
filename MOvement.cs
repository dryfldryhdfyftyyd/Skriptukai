using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MOvement : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;

    Rigidbody2D rb;
    SpriteRenderer renderer;

    [Header("Normal")]
    public Sprite normalSprite;
    public float normalmass = 2;

    [Header("Light")]
    public Sprite lightSprite;
    public float lightmass = 0.5f;

    [Header("Heavy")]
    public Sprite heavySprite;
    public float heavymass = 15;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = rb.GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        Move();
        ChangeState();
    }
    void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            renderer.sprite = lightSprite;
            rb.mass = lightmass;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            renderer.sprite = normalSprite;
            rb.mass = normalmass;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            renderer.sprite = heavySprite;
            rb.mass = heavymass;
        }
    }
    // Update is called once per frame
    void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(x * speed, rb.velocity.y );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);



        }
    }
    

}
