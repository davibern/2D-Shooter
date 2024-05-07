using UnityEngine;

public class Shoting : MonoBehaviour
{
    [SerializeField] private GameObject _crosshair;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _shootPosition;
    private Vector3 _mousePosition;
    private Vector2 _direction;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _crosshair.transform.position = new Vector3(_mousePosition.x, _mousePosition.y, 0);

        _direction = _mousePosition - transform.position;
        transform.up = _direction;

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(_bullet, _shootPosition.position, transform.rotation);
    }
}
