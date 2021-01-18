using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] private bool shouldRun;

    public int height = 500;
    public int width = 500;

    public int maxDepth = 20;
    public float scale = 20f;

    public int offsetX = 0;
    public int offsetY = 0;

    void Start()
    {
        if (shouldRun)
        {
            Terrain t = GetComponent<Terrain>();
            t.terrainData = GenerateTerrain(t.terrainData);
        }
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.size = new Vector3(width, maxDepth, height);
        terrainData.SetHeights(0, 0, GenerateHeights());

        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if ((x < 25 || y < 25) || (x >= width - 25 || y >= height - 25)) {
                    // farlands
                    heights[x, y] = 1.0f;
                } else {
                    // normal terrain
                    heights[x, y] = CalculateHeight(x, y);
                }
            }
        }

        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCoord = (float)x / width * scale + offsetX;
        float yCoord = (float)y / height * scale + offsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
