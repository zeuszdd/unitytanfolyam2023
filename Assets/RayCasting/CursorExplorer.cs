using UnityEngine;

class CursorExplorer : MonoBehaviour
{
    [SerializeField] GameObject cursor3D;
    [SerializeField] float range = 10;
    [SerializeField] float maxForce = 100;
    [SerializeField] new ParticleSystem particleSystem;
    [SerializeField] LayerMask clickMask;

    void Update()
    {
        Vector3 cursorScreenPos = Input.mousePosition;  // Pixel

        Camera camera = Camera.main;
        Ray ray = camera.ScreenPointToRay(cursorScreenPos);

        bool isHit = Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, clickMask);

        if (isHit)
        {
            cursor3D.transform.position = hit.point;

            if (Input.GetMouseButtonDown(0))
            {
                Explode(hit.point);
            }
        }

        //cursor3D.SetActive(isHit);
        cursor3D.GetComponent<MeshRenderer>().enabled = isHit;
    }

    void Explode(Vector3 position)
    {
        particleSystem.Play();

        Rigidbody[] allRigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in allRigidbodies)
        {
            Push(rb, position);
        }
    }

    void Push(Rigidbody rb, Vector3 position)
    {
        float distance = Vector3.Distance(position, rb.position);

        if(distance >= range) return;

        float force = (1 - (distance / range)) * maxForce;
        Vector3 direction = (rb.position- position).normalized;

        Vector3 explosionForce = force * direction;

        rb.velocity += explosionForce;
    }
}