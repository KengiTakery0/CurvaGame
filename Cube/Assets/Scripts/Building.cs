using UnityEngine;

public enum BuildingPriority
{
    Low,
    Medium,
    High
} 

public abstract class Building : MonoBehaviour
{
    [SerializeField] private BuildingPriority buildPriority;
    public BuildingPriority Priority { get { return buildPriority; } set { buildPriority = value; } }

    [SerializeField] private int cost;
    public int Cost { get { return cost; } set { cost = value; } }

    [SerializeField] private bool isLocked;
    public bool IsLocked { get {  return isLocked; } set {  isLocked = value; } }

    [SerializeField] private bool isEnabled;
    public bool IsEnabled { get { return isEnabled;} set { isEnabled = value; } }

    //WorkingBuildings!!
  /*  [SerializeField] int workerCount;
    public int WorkerCount { get {  return workerCount; } set {  workerCount = value; } }*/
    
   


}
