using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody _targetRb;
    private float _ySpawnPos, _xRange, _maxTorque, _maxSpeed, _minSpeed;
    private GameManager _gameManager;

    [SerializeField] private int pointValue;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _ySpawnPos = -6f;
        _xRange = 4f;
        _maxTorque = 10f;
        _maxSpeed = 16f;
        _minSpeed = 12f;
        
    }

    private void Start()
    {
        _targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        _targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-_maxSpeed, _maxTorque);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-_xRange, _xRange), _ySpawnPos);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        _gameManager.UpdateScore(pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
