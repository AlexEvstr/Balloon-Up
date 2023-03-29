using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            _gameOverPanel.SetActive(true);
        }    
    }
}
