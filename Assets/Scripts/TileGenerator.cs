using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public GameObject tilePrefab;

    // Use this for initialization
    void Start()
    {

        var grass = Resources.Load<Sprite>("Tiles/Grass/ISO_Tile_Dirt_01_Grass_01");
        var stone = Resources.Load<Sprite>("Tiles/Stone/ISO_Tile_Stone_03");

        for (var mapY = 0; mapY <= 8; mapY++)
        {
            for (var mapX = 8; 0 <= mapX; mapX--)
            {
                var go = Instantiate(tilePrefab);
                var tile = go.AddComponent<Tile>();
                tile.MapX = mapX;
                tile.MapY = mapY;
            }
        }
    }

    private Vector3 MapToView(int mapX, int mapY, float offset = 0.0f)
    {
        var viewX = (mapX + mapY) * 0.5f;
        var viewY = (12 - mapX + mapY) * (0.36f + offset);

        return new Vector3(viewX, viewY, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
