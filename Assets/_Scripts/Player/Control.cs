using UnityEngine;

public class Control : MonoBehaviour
{
    private Touch _touch;
    private float _speed = 0.005f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + _touch.deltaPosition.x * _speed, transform.position.y);
            }
        }
            
    }
}
