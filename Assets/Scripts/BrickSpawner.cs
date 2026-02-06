using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject[] brickPrefabs;
    public Vector2 brickSize;
    public float maxZOffset;
    public int rowCount;
    public int columnCount;  

    void Start()
    {        
        
        float z = transform.position.z; // Will not change
        float y = transform.position.y; // Will change for every row of bricks
        for (int row = 0; row < rowCount; row++)
        {            
            float x = transform.position.x; // Will change for every brick in a row
            for (int col = 0; col < columnCount; col++)
            {
                GameObject brick;
                if (row == 0)
                {
                    brick = brickPrefabs[brickPrefabs.Length -1];
                }
                else
                {
                    int randomIndex = Random.Range(0, brickPrefabs.Length -1);
                    brick = brickPrefabs[randomIndex];
                }
                float randomZOffset = Random.Range(0f, maxZOffset);
                Instantiate(brick, new Vector3(x, y, z + randomZOffset), brick.transform.rotation);
                x += brickSize.x;
            }            
            y += brickSize.y;
        }
    }
}
                
