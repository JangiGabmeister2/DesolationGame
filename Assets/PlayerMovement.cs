using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 8f;

    private float _speed = 0f;
    private Vector3 _moveDir = Vector3.zero;

    private float Horizontal => Input.GetAxis("Horizontal");
    private float Vertical => Input.GetAxis("Vertical");
    private Rigidbody RB => GetComponent<Rigidbody>();

    private void Start()
    {
        _speed = _moveSpeed * 100f;
    }

    private void Update()
    {
        _moveDir = transform.forward * Horizontal + transform.right * -Vertical;
    }

    private void FixedUpdate()
    {
        RB.velocity = _moveDir.normalized * _speed * Time.deltaTime;
    }
}
