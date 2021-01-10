﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : Move
{
    new bool processing = false;
    /*public MoveHorizontal(EnemyScript _enemy, BattlefieldScript _bfs, Animator _anim, PlayerScript _player, EnemyAI _ai) : base(_enemy, _bfs, _anim, _player, _ai)
    {
        name = STATE.MOVE;
    }*/


    public override void Enter()
    {
        base.Enter();
        Debug.Log("Moving Horizontally");
        entity.IsMoving = true;
    }

    public override void Tick()
    {
        if (entity.IsMoving == true && processing == false)
        {
            if (entity.currentGridPosition.y < bfs.playerPosition.y || entity.currentGridPosition.y > bfs.playerPosition.y)
            {
                float _randomVal = Random.value;
                Debug.Log(_randomVal);
                if (_randomVal > 0.5f)
                {
                    /*if (entity.TileCheck(1, 0))
                    {
                        processing = true;
                        //entity.SetTileInfo(1, 0);
                        //entity.GetComponent<ICombatMove>().Move();

                    }
                    else if(entity.TileCheck(-1, 0))
                    {
                        processing = true;
                        //entity.SetTileInfo(-1, 0);
                        //entity.GetComponent<ICombatMove>().Move();

                    }
                    else
                    {
                        Cooldown();
                    }*/

                }
                else
                { 
                    /*if (entity.TileCheck(-1, 0))
                    {
                        processing = true;
                        //entity.SetTileInfo(-1, 0);
                        //entity.GetComponent<IEnemyCombatMove>().Move();

                    }
                    else if(entity.TileCheck(1, 0))
                    {
                        processing = true;
                        //entity.SetTileInfo(1, 0);
                        //entity.GetComponent<IEnemyCombatMove>().Move();

                    }
                    else
                    {
                        Cooldown();
                    }*/
                }
                
            }
            else
            {
                Cooldown();
            }
        }
        else
        {
            Cooldown();
        }
        //base.Update();
    }
}
