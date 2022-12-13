using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherScript : MonoBehaviour
{
  /// [0]Spring, [1]Summer, [2]Autumn, [3]Winter
  /// [0]sun, [1]rain, [2]overcast, [3]fog, [4] snow

  private GameManager gameManagerInstance;

  private void Awake()
  {
    gameManagerInstance = GameObject.Find("Game Manager").GetComponent<GameManager>();
  }
    /// <summary>
    /// Updates the current Weather
    /// </summary>
    /// <param name="currentSeason"> [0]Spring, [1]Summer, [2]Autumn, [3]Winter</param>
   public void UpdateWeather(int currentSeason) 
   {
     switch (currentSeason)
     {
        case 0:
          //higher probability of rain and sun
          //Basic Implementation for the Prototype
          int weather = Random.Range(0, 2);
          gameManagerInstance.currentWeather = weather;
          WeatherMultiplierUpdate(weather);
          break;

        case 1:
          //higher probability of sun
          break;

        case 2:
          //higher probability of rain and fog
          break;

        case 3:
          //DEATH
          break;

        default:
          Debug.Log("Error with season assignment in  While Updating");
          break;
    }
  }

  /// <summary>
  /// Updates the current active multiplier
  /// </summary>
  /// <param name="weather"></param>
  public void WeatherMultiplierUpdate(int weather)
  {
    if (weather == 0)
    {
      gameManagerInstance.weatherAcessMultiplier = gameManagerInstance.sunAccess;
      gameManagerInstance.weatherRegrowMultiplier = gameManagerInstance.sunRegrow;
    }
    else if (weather == 1)
    {
      gameManagerInstance.weatherAcessMultiplier = gameManagerInstance.rainAccess;
      gameManagerInstance.weatherRegrowMultiplier = gameManagerInstance.rainRegrow;
    }
    else if (weather == 2)
    {
      gameManagerInstance.weatherAcessMultiplier = gameManagerInstance.overcastAccess;
      gameManagerInstance.weatherRegrowMultiplier = gameManagerInstance.overcastRegrow;
    }
    else if (weather == 3)
    {
      gameManagerInstance.weatherAcessMultiplier = gameManagerInstance.fogAccess;
      gameManagerInstance.weatherRegrowMultiplier = gameManagerInstance.fogRegrow;
    }
    else if (weather == 4)
    {
      gameManagerInstance.weatherAcessMultiplier = gameManagerInstance.snowAccess;
      gameManagerInstance.weatherRegrowMultiplier = gameManagerInstance.snowRegrow;
    }
  }

  /// <summary>
  /// Returns the type integer to string name
  /// </summary>
  /// <param name="weatherType">[0]sun, [1]rain, [2]overcast, [3]fog, [4] snow</param>
  /// <returns></returns>
  public string WeatherName(int weatherType) 
  {
    switch (weatherType)
    {
      case 0:
        return "Sun";
      case 1:
        return "Rain";
      case 2:
        return "Overcast";
      case 3:
        return "Fog";
      case 4:
        return "Snow";

      default:
        return "InvalidWeather";
    }
  }

}
