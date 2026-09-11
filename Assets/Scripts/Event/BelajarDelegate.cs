using System;
using UnityEngine;

// PELAJARAN 1 — Delegate
public class BelajarDelegate : MonoBehaviour
{
    // Kita buat tipe baru: method yang tidak mengembalikan nilai, dan tidak butuh parameter.
    delegate void AksiSederhana();

    void Start()
    {
        ContohAction1();
        ContohAction2();
        ContohAction3();
    }

    void Langkah1_SimpanSatuMethod()
    {
        AksiSederhana kotak = TulisHalo;
        kotak();
    }

    void Langkah2_BeberapaMethodSekaligus()
    {
        AksiSederhana kotak = TulisHalo;
        kotak += TulisDunia;
        kotak();
    }

    void Langkah3_ActionSiapPakai()
    {
        // Action sudah disediakan C#. Sama seperti delegate void ...() di atas.
        Action kotak = TulisHalo;
        kotak += TulisDunia;
        kotak();
    }

    void TulisHalo()
    {
        Debug.Log("Halo");
    }

    void TulisDunia()
    {
        Debug.Log("Dunia");
    }

    void ContohAction1()
    {
        AksiSederhana aksi = TulisHalo;
        aksi();
    }

    void ContohAction2()
    {
        AksiSederhana aksi = TulisHalo;
        aksi += TulisDunia;
        aksi();
    }

    void ContohAction3()
    {
       Action aksi = TulisHalo;
         aksi += TulisDunia;
          aksi();
          
    }
}