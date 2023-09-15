using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    public GameObject goal;
    UnityEngine.AI.NavMeshSurface agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<UnityEngine.AI.NavMeshSurface>();
        agent.SetDestinantion(goal.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
