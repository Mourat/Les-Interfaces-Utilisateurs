using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody _targetRb;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        _targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4, 4), -6);
    }
}
