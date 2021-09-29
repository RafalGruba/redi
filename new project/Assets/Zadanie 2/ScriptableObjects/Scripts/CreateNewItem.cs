using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Create New Item")]
public class CreateNewItem : ScriptableObject
{

    [SerializeField] int index;
    [SerializeField] string nazwa;
    [SerializeField] Texture2D ikona;
    [SerializeField] GameObject prefab;

    public GameObject GetPrefab() { return prefab; }
    public string GetName() { return nazwa; }
    public int GetIndex() { return index; }
    public Texture2D GetIcon() { return ikona; }
}