using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour
{
    public Collider PlanetCollider;
    public GameObject ObjectToSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            var hit = GetPointOnMesh();
            var rotation = Quaternion.FromToRotation(new Vector3(0, 0, 1), hit.point.normalized);

            GameObject go = GameObject.Instantiate(ObjectToSpawn, hit.point, rotation) as GameObject;
            go.transform.parent = this.transform;
        }
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
