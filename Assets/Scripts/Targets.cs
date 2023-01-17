using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody _targetRb;
    private float _ySpawnPos, _xRange, _maxTorque, _maxSpeed, _minSpeed;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>();
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
}
