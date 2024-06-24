using UnityEngine;

/// <summary>
/// Controll a blend tree
/// </summary>
public class SimpleBlendTreeController : MonoBehaviour
{
    // Defines how fast the character will move
    public float MaxMovementSpeed = 10;

    public float locomotionParameterDamping = 0.1f;

    // Animator playing animations
    private Animator _animator;

    // Hash speed parameter
    private int _speedParameterHash;

    // Hash speed parameter
    private int _isWalkingParameterHash;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _speedParameterHash = Animator.StringToHash("speed");
        _isWalkingParameterHash = Animator.StringToHash("isMoving");
    }



    // Update is called once per frame
    void Update()
    {
        // Stores inputs
        float verticalInput = Input.GetAxis("Vertical");

        bool shouldWalk = Input.GetKey(KeyCode.LeftShift)  || Input.GetKey(KeyCode.RightShift);

        float speed = shouldWalk ? verticalInput / 2 : verticalInput;

        _animator.SetFloat(_speedParameterHash, speed, locomotionParameterDamping, Time.deltaTime);

        // Move the go along z-axis
        //transform.Translate(Vector3.forward * MaxMovementSpeed * verticalInput * Time.deltaTime);

        if(verticalInput != 0)
        {
            _animator.SetBool("isMoving", true);
        }

        else
        {
            _animator.SetBool("isMoving", false);
        }
    }
}
