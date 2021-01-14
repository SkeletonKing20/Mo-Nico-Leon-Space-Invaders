# Mo-Nico-Leon-Space-Invaders
Enemies (Invaders) (Nico)
> Move downwards,
 	kill the Player on collision/take away a life
	set number per level
> (no more enemies) win condition

Player (spaceship) (Mo)
> Only moves left and right, 
 	can fire bullets,
	health? 
> Defeat condition

Bullet (Leon)
Player bullet
> Destroys Enemies on collision,
Is fired upward from the players current Position (is spawned and only moves upward)

Enemy bullet
> Damages the base, 
kills the player, 
is randomly spawned and moves downward

Base 
 > if destroyed: Game Over
		Takes Damage, blocks bullet from both sides 
		(acts as cover and defeat condition)

