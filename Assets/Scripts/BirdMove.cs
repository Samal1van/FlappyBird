using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    public float maxRotationZ;
    public float minRotationZ;
    private Quaternion maxRotation;
    private Quaternion minRotation;
    public float rotationSpeed;
    private Animator animator;
    private List<Vector2> pos = new List<Vector2>();
    private bool isRevind = false;
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private GameObject _backGround;
    [SerializeField] private GameObject _bird;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        maxRotation=Quaternion.Euler(0,0,maxRotationZ);
        minRotation=Quaternion.Euler(0,0,minRotationZ);
        animator= GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(speed, 0);
            transform.rotation = maxRotation;
            rb.AddForce(Vector2.up * jumpForce);
            animator.SetTrigger("Jump");
        }
        transform.rotation = Quaternion.Lerp(transform.rotation,minRotation,rotationSpeed*Time.deltaTime);
        _backGround.transform.position = new Vector2(_bird.transform.position.x,_backGround.transform.position.y);
    }

    private void FixedUpdate()
    {
        if (isRevind == false)
        {
            pos.Add(transform.position);
        }

        if (pos.Count > 100)
        {
            pos.RemoveAt(0);
        }
    }

    private IEnumerator rewind()
    {
        _rigidbody2D.isKinematic = true;
        isRevind = true;
        for (int i = pos.Count -1; i > 0; i--)
        {
            while (ReferenceEquals(transform.position, pos[i]) == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos[i], 10 * Time.deltaTime);
                yield return null;
            }
            pos.RemoveAt(i);
        }

        isRevind = false;
        _rigidbody2D.isKinematic = false;
    }
}
