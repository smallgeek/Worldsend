using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int MapX;
    public int MapY;

    // Use this for initialization
    void Start()
    {
        gameObject.name = string.Format("Tile ({0} {1})", MapX, MapY);

        GetComponent<SpriteRenderer>().sprite = (MapX == 4 || MapY == 4)
            ? Resources.Load<Sprite>("Tiles/Stone/ISO_Tile_Stone_03")
            : Resources.Load<Sprite>("Tiles/Grass/ISO_Tile_Dirt_01_Grass_01");
            
        transform.position = MapToView(MapX, MapY);
    }

    private static Vector3 MapToView(int mapX, int mapY, float offset = 0.0f)
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
