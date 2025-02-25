using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class codi : MonoBehaviour
{

    private NavMeshSurface nav;
    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshSurface>();   
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Refreshmesh();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            nav.RemoveData();
        }
    }
    public void Refreshmesh()
    {
        nav.BuildNavMesh();
    }

}
