using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float kecepatan = 5f;
    public int skor = 0;

    private Vector2 arahGerak;
    private GameManager gameManager;

    // Dipanggil otomatis oleh Player Input
    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }

     void Start()
  { 
    gameManager = FindFirstObjectByType<GameManager>();
  }
    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Coin"))
    {
        Destroy(other.gameObject);

        skor++;

        Debug.Log("Skor : " + skor);

        gameManager.AmbilKoin();
    }
    }
}