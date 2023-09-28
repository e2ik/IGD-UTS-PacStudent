using UnityEngine;

public class CenterCamera : MonoBehaviour
{
    private Vector3 setCamPos;
    private GameObject level;
    private LevelGenerator levelGenerator;
    private int numRows;
    private int numCols;
    private Camera cam;
    [SerializeField] private float padding;

    void Start()
    {
        cam = Camera.main;
        level = GameObject.Find("GenerateLevel");
        if (level != null) {
            levelGenerator = level.GetComponent<LevelGenerator>();

            if (levelGenerator != null) {
                numRows = levelGenerator.numRows;
                numCols = levelGenerator.numCols;
            }
        }
        Debug.Log(numRows + " " + numCols);
        Vector3 lvlPos = level.transform.position;
        float newX = (numCols + (numCols-1)) /2;
        float newY = (numRows + (numRows-2)) /2;
        setCamPos = new Vector3(lvlPos.x + newX, lvlPos.y - newY, lvlPos.z - 4);
        cam.transform.position = setCamPos;
        FitCameraToObjects();

    }
    private void FitCameraToObjects() {
        Bounds bounds = new Bounds(Vector3.zero, Vector3.zero);
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects) {
            if (obj.name.ToLower().Contains("wall")) { bounds.Encapsulate(obj.transform.position); }
        }
        float newSize = Mathf.Max(bounds.size.x, bounds.size.y) * 0.5f + 2.0f + padding;
        cam.orthographicSize = newSize;
    }
}