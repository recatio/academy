using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //field

    // player's movement speed and rotation speed
    public float _speed, _rotSpeed = 0.0f;
    // player's rotate
    public float _rotY = 0.0f;

    // require raycast mask
    public LayerMask maskGrounds;

    private Rigidbody2D rb;
    private float rayDist = 0.0f;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _speed = 5.0f;

        // movement direction
        float posH = Input.GetAxis("Horizontal");
        float posV = Input.GetAxis("Vertical");

        // set raycast
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayDist = 1.0f, maskGrounds);
        
        // start raycast
        if (hit.collider != null)
        {
            float hitY = hit.point.y;
            Vector3 newPos = new Vector3(transform.position.x, hitY, transform.position.z);
            transform.position = newPos;
        }

        // start movement
        transform.Translate(posH, posV, 0.0f * _speed * Time.deltaTime);
    }
}
