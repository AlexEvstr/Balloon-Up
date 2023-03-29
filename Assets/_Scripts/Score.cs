using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float _score;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _startPanel;

    private void Start()
    {
        StartCoroutine(ScoreCount());
    }

    private IEnumerator ScoreCount()
    {
        while(true)
        {
            if (_startPanel.activeInHierarchy)
            {
                yield return new WaitForSeconds(0);
            }
            else
            {
                _score++;
                _scoreText.text = _score.ToString();
                yield return new WaitForSeconds(0.5f);
            }
        }

    }
}
