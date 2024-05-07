using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();   
    }

    private void Start()
    {
        _rb.velocity = transform.up * _speed;

        Destroy(gameObject, 2f);
    }
}
