using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    [SerializeField] private Unit unit;
    private GridSystem gridSystem;
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GridSystemVisual.Instance.HideAllGridPositions();
            //GridSystemVisual.Instance.ShowGridPositionList(unit.GetMoveAction().GetValidActionGridPositionList());
        }
    }
}
