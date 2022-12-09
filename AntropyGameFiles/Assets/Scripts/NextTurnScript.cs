using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnScript : MonoBehaviour
{
  
  public float ant_growth_rate;
  public float tile_resource_rate;
  public float event_rate;
  public float weather_rate;

  /// <summary>
  /// Turn Sequence, bind this to a button
  /// </summary>
  public void NextTurn() 
  {
    AntTurn();
    MapTurn();
    WeatherTurn();
    EventTurn();
    SeasonTurn();
    MessageTurn();
  }

  void AntTurn() 
  {
    //Insert Ant Turn
  }

  void MapTurn() 
  {
    //Insert Map Turn

    //change the tile object
    TileScript[,] game_map = MapScript.map_instance.GameMap;//game_resources.map_instance.GameMap;

    for (int i = 0; i < MapScript.map_instance.rows; i++)
    {
      for (int j = 0; j < MapScript.map_instance.columns; j++)
      {
        //constant growth +
        game_map[i, j].CalculateNewResourceAmount(tile_resource_rate);

        //check if the growth if we reached a threshhold to update the tile mesh
        MapScript.map_instance.TileErrosionCheck(game_map[i, j]);

        //Debug.Log(name + ": [" + i + "," + j + "]" + game_map[i, j].ResourceAmount);
      }
    }
  }

  void WeatherTurn()
  {
    //Insert Weather Turn
  }

  void EventTurn() 
  {
    //Insert Event Turn
  }

  void MessageTurn() 
  {
    //Insert Message Turn
  }

  void SeasonTurn() 
  {
    //Insert Season Turn
  }
}