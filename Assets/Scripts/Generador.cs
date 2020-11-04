using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Generador : MonoBehaviour
{
    [Header("Referências")]
    public Tilemap MapaDeLosetas;
    public TileBase Loseta;

    [Header("Dimenssões")]
    public int Ancho = 60;
    public int Alto = 34;

    public void GenerarMapa()
    {
        int[,] mapa = Metodos.GenerarArray(Ancho, Alto, false);
        Metodos.GenerarMapa(mapa, MapaDeLosetas, Loseta);
    }

    public void LimpiarMapa()
    {
        MapaDeLosetas.ClearAllTiles();
    }
}