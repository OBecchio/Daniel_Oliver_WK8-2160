using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    private PlayerInputs playerInput;
    private InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        playerInput = new PlayerInputs();
        moveAction = playerInput.Movement.walk;
    }

    void OnEnable()
    {
        moveAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = moveAction.ReadValue<Vector3>();

        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
