using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;

    [SerializeField] private int skor = 6;

    void onEnable()
    {
        Enemy.OnZombieMati += TambahSkorSaatZombieMati;
    }

    void onDisable()
    {
        Enemy.OnZombieMati -= TambahSkorSaatZombieMati;
    }

    void TambahSkorSaatZombieMati(Enemy zombie)
    {
        skor += 10;
        Debug.Log("Skor: " + skor);
    }

    void Start()
    {
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;

        if (koinTerkumpul == totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        Debug.Log("Horeeeeee Game menangggggg !");
    }
}