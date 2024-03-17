using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private Vector2 inputVector;

    [Header("Movement Settings")]

    [SerializeField] private float walkSpeed = 1f;
    [SerializeField] private float runSpeed = 2f;
    [SerializeField] private float jumpForce = 10f;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
}
