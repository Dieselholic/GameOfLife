# GameOfLife

## Main Info
The **Game of Life**, also known simply as **Life**, is a cellular automaton devised by the British mathematician [John Horton Conway](https://en.wikipedia.org/wiki/John_Horton_Conway) in 1970.
It is a **zero-player game**, meaning that its evolution is determined by its initial state, requiring no further input.
One interacts with the Game of Life by **creating an initial configuration and observing how it evolves**.
It is [Turing complete](https://en.wikipedia.org/wiki/Turing_completeness) and can simulate a universal constructor or any other [Turing machine](https://en.wikipedia.org/wiki/Turing_machine). 

## Rules
The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells, each of which is in one of two possible states, live or dead (or populated and unpopulated, respectively).
Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.
At each step in time, the following transitions occur:
    
    * Any live cell with *fewer than two live neighbours* **dies**, as if by underpopulation.
    * Any live cell with *two or three live neighbours* **lives on to the next generation**.
    * Any live cell with *more than three live neighbours* **dies**, as if by overpopulation.
    * Any dead cell with *exactly three live neighbours* becomes a **live** cell, as if by reproduction

The initial pattern constitutes the seed of the system.
The first generation is created by applying the above rules simultaneously to every cell in the seed, live or dead.
Births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick.
Each generation is a pure function of the preceding one.
The rules continue to be applied repeatedly to create further generations. 

## Examples of patterns
Many different types of patterns occur in the Game of Life, which are classified according to their behaviour.
Common pattern types include:
    
    * **Still lifes**, which do not change from one generation to the next.
        ![still lifes example](https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Game_of_life_block_with_border.svg/1024px-Game_of_life_block_with_border.svg.png)
    * **Oscillators**, which return to their initial state after a finite number of generations.
        ![oscillator example](https://upload.wikimedia.org/wikipedia/commons/9/95/Game_of_life_blinker.gif)
    * **Spaceships**, which translate themselves across the grid. 
        ![spaceship example](https://upload.wikimedia.org/wikipedia/commons/f/f2/Game_of_life_animated_glider.gif)

## To Do List
List of things I plan to implement in this project:
    
    - [ ] Implement basic algorythm with console output.
        - [x] Implement field generation.
        - [ ] Implement random seeding.
        - [ ] Implement the playing field as the surface of a torus.
    - [ ] Implement basic graphics and start to draw field and cells.
    - [ ] Implement buttons to control the game process and its speed.