using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public GameObject player;
    public PlayerLocomotion playerLocomotion;
    public InputManager inputManager;
    public Rigidbody rigidBody;

    public float moveSpeed;
    public float rotSpeed;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        playerLocomotion = player.GetComponent<PlayerLocomotion>();
        inputManager = player.GetComponent<InputManager>();
        rigidBody = player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputManager.HandlesAllInput();
    }

    void FixedUpdate()
    {
        playerLocomotion.HandlesAllMovement();
    }
}
