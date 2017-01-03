using UnityEngine;

public class Main : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        var ry = Resources.Load<Sprite>("Charactors/ry");
        var chara = new GameObject { name = "ry" };
        var ren = chara.AddComponent<SpriteRenderer>();
        ren.sprite = ry;
        ren.sortingOrder = 1;
        //chara.transform.localScale = new Vector3(0.4f, 0.4f, 0.0f);

        chara.transform.position = MapToView(3, 5, 0.02f);
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
