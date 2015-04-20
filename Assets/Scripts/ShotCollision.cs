using UnityEngine;

public class ShotCollision : MonoBehaviour
{
    public ParticleSystem emitter;
    private Collider _planetCollider;
    // Use this for initialization
    void Start()
    {
        var planet = GameObject.FindGameObjectWithTag("Planet");
        _planetCollider = planet.GetComponent<SphereCollider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        var hit = GetPointOnMesh();
        var rotation = Quaternion.FromToRotation(new Vector3(0, 0, -1), hit.point.normalized);

        Instantiate(emitter, transform.position.normalized * 1.05f, rotation);
        Destroy(gameObject);
    }

    RaycastHit GetPointOnMesh()
    {
        var length = 100.0f;
        var direction = transform.position - Vector3.zero;
        var ray = new Ray(transform.position + direction * length, -direction);

        RaycastHit hit;
        _planetCollider.Raycast(ray, out hit, length * 2);
        return hit;
    }
}
