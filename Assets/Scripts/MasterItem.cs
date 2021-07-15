using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using anogamelib;

public class MasterItemParam : CsvDataParam
{
    public int itemId;
    public string itemName;
}
public class MasterItem : CsvData<MasterItemParam>
{
   
}
