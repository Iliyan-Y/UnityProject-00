using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;  
    private float movementX;
    
    private Rigidbody2D myBody;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private string WALK_ANIMATION = "Walk";

     private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
    }

    void PlayerMoveKeyboard() {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer() {

        if (movementX > 0) {
            animator.SetBool(WALK_ANIMATION,true);
            spriteRenderer.flipX = false; 
        } else if (movementX < 0) {
            animator.SetBool(WALK_ANIMATION,true);
            spriteRenderer.flipX = true; 
        } else {
            animator.SetBool(WALK_ANIMATION, false);
        }
    }

}
