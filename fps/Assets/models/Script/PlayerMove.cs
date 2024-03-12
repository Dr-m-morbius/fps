using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
public float moveSpeed = 1f;
public float mouseSensitivity = 1f;
public float jumpForce = 10;
public float gravityModifier = 1; 
public Transform groundCheckpoint;
public LayerMask whatIsGround;
public Transform theCamera;
private bool _canPlayerJump;
private Vector3 _moveInput;

private CharacterController _characterController;

// Start is called before the first frame update
void Start()
{
_characterController = GetComponent<CharacterController>();
}

// Update is called once per frame
void Update()
{

    float yVelocty =_moveInput.y;

    _moveInput.y = yVelocty;

    _moveInput.y += Physics.gravity.y * gravityModifier * Time.deltaTime;
    //check if player contorller is on ground
    if(_characterController.isGrounded)
    {
        _moveInput.y = Physics.gravity.y * gravityModifier * Time.deltaTime;
    }

    _canPlayerJump = Physics.OverlapSphere(groundCheckpoint.position, 0.5f, whatIsGround).Length >0;

    if(Input.GetKey(KeyCode.Space) && _canPlayerJump)
    {
        _moveInput.y = jumpForce;
    }
//Player movement
//_moveInput.x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
//_moveInput.z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

Vector3 forwardDirection = transform.forward * Input.GetAxis("Vertical");
Vector3 horizontalDirection = transform.right * Input.GetAxis("Horizontal");

_moveInput = (forwardDirection +horizontalDirection).normalized;
_moveInput *= moveSpeed;
_characterController.Move(_moveInput * Time.deltaTime);


_characterController.Move(_moveInput);

//Camera rotation
Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);

theCamera.rotation = Quaternion.Euler(theCamera.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));
}
}