# SoftwareDesignPrinciplesDemo
Example project for the presentation about software design principles applied to a simple videogame

**Link To Presentation:** https://drive.google.com/open?id=1rJc6eNa_xk1c0MGsuWa24puLA90E0jykwz6-7dwonls

**Example 1**

We implement the main logic for the player.

We create a base class for characters, so we can implement later the AI respecting the Open Close and Liskov Subsitution Principles
The base character logic is splitted in different components with one simple task (Single Responsability Principle)

**Example 2**

We create a class to manage the board of the level.
The board uses a Factory to get the elements that make it up. The factory es created from an interface so we meet the Liskov Substitution Principle.

**Example 3**

Characters now can move over the board. 
The movement component needs the board to know where the obstacles are, so we use the Dependendency Injection Pattern to mantain the component decoupled from the rest of the architecture.

**Example 4**

Implemented collision detection on player as new component (Single Responsability Principle).
We create a Coin item that inherits from a base colliding class (Open/Closed Principle)
The player interacts with any colliding element that hits through an interface (Dependency Inversion Principle)
Implemented simple HUD. UI and Gameplay decoupled using o variation of the Observer Pattern.

**Example 5**

Enemies implementation. All enemies inherits from a base enemy class (Liskov & OCP).
Player interacts with enemies as CollidingElements (Dependency Inversion Principle).
Player refactored to extract Input to another class (SRP, Liskov & OCP). 