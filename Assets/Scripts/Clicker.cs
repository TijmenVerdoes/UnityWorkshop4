using UnityEngine;

public class Clicker : MonoBehaviour
{
    public Puzzle puzzel;
    public int id;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            puzzel.Add(id);
        }
    }
}
