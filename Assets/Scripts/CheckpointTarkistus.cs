using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{
    public int checkpointCount = 3;

    public bool[] visited;
    private int visitedCount;

    void Awake()
    {
        ResetLap();
    }

    void ResetLap()
    {
        visited = new bool[checkpointCount];
    }

    public void MarkVisited(int index)
    {
        if (!visited[index])
        {
            visited[index] = true;
            visitedCount++;
        }
       
        MarkVisited(0);
    }

    public bool CanWin()
    {
        if (checkpointCount == visitedCount)
        {
            return true;
        }
        return false;
    }

}
