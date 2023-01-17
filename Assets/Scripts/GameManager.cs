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
        _score = 0;
        scoreText.text = "Score: " + _score;
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
}
