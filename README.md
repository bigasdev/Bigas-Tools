![Bigas-Tools](res/logo.png)

[![Made for Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=plastic&logo=unity)](https://unity3d.com)
![Stars](https://img.shields.io/github/stars/bigasdev/Bigas-Tools.svg?style=plastic)

The tools i usually use for all of my game development with unity.

[![Changelog](https://img.shields.io/badge/✨%20Changelog-3a3b3c?style=plastic)](Assets/CHANGELOG.md)

[![Discord](https://img.shields.io/badge/Discord-7789FF?style=plastic&logo=Discord)](https://discordapp.com/users/413483007492751370)  


# Features
 - A powerful timer class
 - Controllers for audio and resources
 - A powerful state controller
 - Tag system 
 - A pool system

# Doc
 ## Timer class
A non-monobehaviour class that you can use to create a timer inside any script. You can add a function for when its completed and choose if it loops or not.
```
A base syntax for the timer looks like this:

Timer myTimer;

private void Start(){
    myTimer = new Timer(5, true);
    myTimer.OnComplete += TimerFinish;
}
private void Update(){
    myTimer.Update();
}
```
# Controllers
 ## State Controller
This script will be able to manage the state you game are in, you can add new enums to better control it.
```
The state controller has a static reference (StateController.Instance) and you can use:

StateController.ChangeState(States.YOUR_STATE)

To change the state you are in, it's useful for pauses and/or update checks.
```

# Pool System
The pool system comes with a powerful way of instantiating and "destroying" objects without using too much performance, you can set as many pools as you want and use ids to reference them. So in the end you are able to get an enemy like this:
```
PoolsManager.Instance.GetPool("Enemy")?.GetFromPool(this.transform.position);
```
