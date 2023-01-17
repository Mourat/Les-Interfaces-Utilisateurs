using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> targets;
    private float _spawnRate;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int _score;

    private void Awake()
    {
        _spawnRate = 1f;
        UpdateScore(0);

    }

    private void Start()
    {
        StartCoroutine(SpawnTarget());
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnRate);
            var index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        scoreText.text = "Score: " + _score;
    }
}
