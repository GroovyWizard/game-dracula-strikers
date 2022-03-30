using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyCounterHelper 
{

   public static int EnemyCounter() {
        GameObject[] _enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        int _enemyCount = _enemyList.Length;

        return _enemyCount;

   }
}
