# Using Sine(x) to move an object

[UnityEngine.Mathf.Sin(x)](https://docs.unity3d.com/ScriptReference/Mathf.Sin.html) / [Unity.Mathematics.math.sin(x)](https://github.com/Unity-Technologies/Unity.Mathematics)

It is very common to use trigonometric functions as helpers to animate motion in our games. In this short article, we will see how to use the Sin(x) function (and similarly the sin(x) from the new Unity Mathematics library) to quickly animate an object moving.

<p align="center">
<img src="https://user-images.githubusercontent.com/263776/51221479-454e5780-18ff-11e9-991b-07e0223f83dc.gif" width="325" height="195">
</p>
In this example, imagine you have a hoverboard and you want to animate it using code, it’s movement is very simple as it just moves up and down (on it’s Y axis). For that, we can use Unity’s Mathf.Sin function. It receives as a parameter the angle in radians. 

The graph of the given motion looks something like this. The X axis will be time and the Y axis will be the Y position.

<p align="center">
  <img src="https://user-images.githubusercontent.com/263776/51295635-2377d200-19de-11e9-98ba-fa0511e8ea45.PNG" width="325" height="195">
</p>

This was plotted using Wolfram Alpha, and using just the function sin(x); I won’t go into a lot of detail here, but just remember that the sine function goes from -1 to 1. So, for every x value we enter, a value of y will go from -1, 1. 

So, if we go to Unity and code the function based on Time.time, we would end up with an animation like this.

<p align="center">
<img src= "https://user-images.githubusercontent.com/263776/51222960-86496a80-1905-11e9-8095-68280abf9fa9.gif" width="325" height="195">
</p>

###### transform.position = originalTransform + new Vector3(0, Mathf.Sin(Time.time), 0);

Of course, we don’t want an animation like that for our objects (at least not always), so we need to find a way to modify the movement description. And we will do it by changing the speed and the amplitude.

The speed (the rate at which the position changes) has to go as a product of the Mathf.Sin(Time.time * speed). If we assign the value of 5 to our speed variable, the motion looks like this. Moves faster but still goes from 1 to -1.

<p align="center">
<img src= "https://user-images.githubusercontent.com/263776/51222981-9d885800-1905-11e9-8105-08a358fabb09.gif" width="325" height="195">
</p>

###### transform.position = originalTransform + new Vector3(0, Mathf.Sin(Time.time * speed), 0);

Ok, now is time that we add another layer of customization so we allow our object to move farther away than it’s current limits [1, -1]. In my case, I want to scale the wave's amplitude, so the result of the sine will be multiplied by an amplitude variable.

Putting a value of 3, to the amplitude we went from a range of [-1, 1] to a range of [-3, 3].

The motion with the following code and speed = 5 and amplitude = 3 looks like this:

<p align="center">
<img src= "https://user-images.githubusercontent.com/263776/51222994-a9741a00-1905-11e9-8b46-8fd5ed65ff00.gif" width="325" height="195">
</p>

Hope this explanation is useful, and serves as a starting point to explore other functions to create more complex animations. If you have any question, you can reach me at [@ArturoNereu](https://twitter.com/arturonereu)

###### transform.position = originalTransform + new Vector3(0, Mathf.Sin(Time.time * speed) * amplitude, 0);

Sine, Cosine animation By LucasVB - Own work, Public Domain, https://commons.wikimedia.org/w/index.php?curid=31642523
