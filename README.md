# flock_off 🪿

A silly fighter jet game where you pilot through an endless sky full of Canada's most fearless birds. Avoid the geese. They will not avoid you.

## About

Built in Unity using imported 3D assets — a fighter jet model (Raptor3D), goose mesh, and 3D skybox environments. Behaviour scripts are attached to the game objects to handle plane movement, goose spawning, and a collision system that tracks player health. Hit a goose, lose health. Hit too many geese, game over.

## Assets

- **Fighter Jet** — Raptor3D FA_N26 model with multiple LODs and camo variants
- **Goose** — 3D goose mesh used as the obstacle prefab
- **Skybox** — 3D Skybox (Swiss Freebies) and 8K Skybox Pack for the environments

## Scripts

- `planeController.cs` — handles player movement and input
- `planeCollider.cs` — detects collisions with geese
- `planeHealth.cs` — tracks and manages player health
- `gooseEnemy.cs` — controls goose behaviour and spawning

video demo coming soon

<img width="1596" height="1010" alt="image" src="https://github.com/user-attachments/assets/34ae652d-f304-48e7-94ae-457c8eb1d362" />
