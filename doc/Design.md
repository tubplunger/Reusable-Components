# Reuse

This simple Unity project is to demostrate some reusable scripts and components that can be used for your own purposes and demonstrate how they work.

1. Object Pooling:

Object Pooling is pretty simple to set up. For the basics you only need the ObjectPool and PooledObject script in the same place. ObjectPool is placed on an empty game object that acts as the pool and PooledObject is placed on any object you make that needs to be pooled. In the case for this demo: a default Unity cube.

The two PoolDemo scripts are to just show that everything works by spawning the pooled objects and then returning them to the pool. If you want to use these scripts simply added PoolDemoAutoReturn to your prefab, and for PoolDemoSpawner make another empty game object and put the script in there, having it reference the Object Pool. With all this set up you should see the prefab object spawn repeatedly in a small area before disappearing after 2 seconds, though this is them being readded to the pool before being reused again.

2. Weapon Systems:

Weapons are harder to set up, but it still shouldn't take very long. What is needed immediatley is an empty object with the WeaponController script and WeaponDemoInput script, along with a prefab Projectile with the Projectile script. Also, the Weapon object will need an empty child object to be the fire point.

Assign everything and then you can create the weapons through data. You can create as many as you want and assign their names and separate data for them, just make sure the Projectile prefab is on all of them and are referenced in the WeaponController index. From there, it should fire properly!