using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsEmmitter : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] [Range(0, 5)] private int _minCoins = 1;
    [SerializeField] [Range(1, 25)] private int _maxCoins = 5;
    [SerializeField] private float _spawnHeight = 2f;

    void Start()
    {
        var size = GetComponent<MeshFilter>().sharedMesh.bounds.size.x * transform.localScale.x;
        var coins = Random.Range(_minCoins, _maxCoins + 1);
        var step = size / coins;

        for (int i = 1; i < coins; i++)
        {
            Instantiate(_coin, transform.position + new Vector3(step * i - size / 2f, _spawnHeight), Quaternion.identity);
        }
    }

}
