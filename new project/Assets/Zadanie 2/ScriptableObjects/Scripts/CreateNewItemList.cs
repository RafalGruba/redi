using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Create New Item List")]
public class CreateNewItemList : ScriptableObject
{
    [SerializeField] List<CreateNewItem> items;

    public List<CreateNewItem> GetEnemyPrefab() { return items; }
}
