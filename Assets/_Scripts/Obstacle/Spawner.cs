using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    private float _xPosition;
    private float _yPosition = 6.0f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
       while (true)
        {
            _xPosition = Random.Range(-2, 2);
            var obstacle = Instantiate(_obstaclePrefab);
            obstacle.transform.position = new Vector2(_xPosition, _yPosition);
            yield return new WaitForSeconds(1);
        }
    }
}
