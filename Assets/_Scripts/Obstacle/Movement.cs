using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }
}
