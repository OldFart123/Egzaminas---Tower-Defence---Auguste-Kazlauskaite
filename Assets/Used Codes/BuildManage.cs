using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManage : MonoBehaviour
{
    public static BuildManage main;
    [Header("References")]
    [SerializeField] private Tower[] towers;

    private int selectedTower = 0;

    private void Awake()
    {
        main = this;
    }
    public Tower GetSelectedTower()
    { 
        return towers[selectedTower];
    }
}
