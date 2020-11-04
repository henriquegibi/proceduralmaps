using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Metodos
{
    /// <summary>
    /// Gera uma matriz, um array bidimencional
    /// </summary>
    /// <param name="ancho">Largura do mapa 2D</param>
    /// <param name="alto">Altura do Mapa 2D</param>
    /// <param name="vacio">Verdadeiro para inicializá-lo vazio, se não, todo cheio</param>
    /// <returns>Mapa gerado</returns>
    public static int[,] GenerarArray(int ancho, int alto, bool vacio)
    {
        int[,] mapa = new int[ancho, alto];

        for (int x=0; x<ancho; x++)
        {
            for (int y=0; y<alto; y++)
            {
                mapa[x, y] = vacio ? 0 : 1;
            }
        }

        return mapa;
    }

    /// <summary>
    /// Gera o mapa de tiles com a informação indicada em "mapa"
    /// </summary>
    /// <param name="mapa">Informação que se utilizará para gerar o tileset. 1 = há chão, 0 = não há chão</param>
    /// <param name="mapaDeLosetas">Referencia ao mapa de tiles onde se gerarão os tiles</param>
    /// <param name="loseta">Tile que será utilizado pata pintar o solo no mapa</param>
    public static void GenerarMapa(int[,] mapa, Tilemap mapaDeLosetas, TileBase loseta)
    {
        //Limpamos o mapa para começar com um vazio
        mapaDeLosetas.ClearAllTiles();


        for(int x = 0; x < mapa.GetUpperBound(0); x++)
        {
            for (int y = 0; y < mapa.GetUpperBound(1); y++)
            {
                // 1 = tem chão, 0 = não tem chão
                if(mapa[x,y] == 1)
                {
                    mapaDeLosetas.SetTile(new Vector3Int(x, y, 0), loseta);
                }
            }
        }
    }
}
