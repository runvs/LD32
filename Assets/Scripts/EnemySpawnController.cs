using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class EnemySpawnController : MonoBehaviour
{
    public Collider PlanetCollider;
    public GameObject ObjectToSpawn;

    private float _enemySpawnTimer = 1.5f;
    private int progressionLevel = 1;

    private float MaxEnemies = 5;

    // Update is called once per frame
    void Update()
    {

        _enemySpawnTimer += Time.deltaTime;
        if (_enemySpawnTimer >= GetSpawnTime())
        {
            int spawnNumber = 1 + ((Random.Range(0.0f, 10.0f) < progressionLevel) ? 1 : 0) + ((Random.Range(0.0f, 10.0f) < progressionLevel) ? 1 : 0) + ((Random.Range(0.0f, 20.0f) < progressionLevel) ? 1 : 0) + ((Random.Range(0.0f, 30.0f) < progressionLevel) ? 1 : 0);
            SpawnEnemyBundle(spawnNumber);
            _enemySpawnTimer = 0;
        }
    }

    private void SpawnSingleEnemy()
    {
        var hit = GetPointOnMesh();
        var rotation = Quaternion.FromToRotation(new Vector3(0, 0, -1), hit.point.normalized);

        GameObject go = GameObject.Instantiate(ObjectToSpawn, hit.point * 1.05f, rotation) as GameObject;
        go.transform.parent = this.transform;
    }

    private void SpawnEnemyBundle(int spawnNumber)
    {
        Debug.Log("Spawn");
        for (int i = 0; i != spawnNumber; i++)
        {
            SpawnSingleEnemy();
        }
    }


    private float GetSpawnTime()
    {

        float currentEnemies = this.transform.childCount;
        float exponent = GameProperties.EnemySpawnerExponent;
        float ret = (float)(Math.Pow(currentEnemies / MaxEnemies, exponent)) * GameProperties.EnemySpawnerMaxTime;
        return ret;
    }

    RaycastHit GetPointOnMesh()
    {
        var length = 100.0f;
        var direction = Random.onUnitSphere;
        var ray = new Ray(transform.position + direction * length, -direction);

        RaycastHit hit;
        PlanetCollider.Raycast(ray, out hit, length * 2);
        return hit;
    }
}
