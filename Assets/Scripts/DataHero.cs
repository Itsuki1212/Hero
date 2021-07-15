using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using anogamelib;

public class DataHeroParam : CsvDataParam
{
    public int heroId;
    public int heroSerial;
    public int hp;
    public int hpMAX;
    public int atk;
    public int def;
    public int cop;
    public int spd;
}

public class DataHero : CsvData<DataHeroParam>
{
    
}
