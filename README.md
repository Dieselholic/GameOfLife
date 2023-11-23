# GameOfLife

## Main Info
The **Game of Life**, also known simply as **Life**, is a cellular automaton devised by the British mathematician [John Horton Conway](https://en.wikipedia.org/wiki/John_Horton_Conway) in 1970.
It is a **zero-player game**, meaning that its evolution is determined by its initial state, requiring no further input.
One interacts with the Game of Life by **creating an initial configuration and observing how it evolves**.
It is [Turing complete](https://en.wikipedia.org/wiki/Turing_completeness) and can simulate a universal constructor or any other [Turing machine](https://en.wikipedia.org/wiki/Turing_machine). 

## Rules
The universe of the Game of Life is an **infinite, two-dimensional orthogonal grid of square cells**, each of which is in one of two possible states, **live or dead** (or populated and unpopulated, respectively).
Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.
At each step in time, the following transitions occur:
    
* Any live cell with *fewer than two live neighbours* **dies**, as if by underpopulation.
* Any live cell with *two or three live neighbours* **lives** on to the next generation.
* Any live cell with more than three live neighbours **dies**, as if by overpopulation.
* Any dead cell with *exactly three live neighbours* **becomes a live cell**, as if by reproduction

The initial pattern constitutes the seed of the system.
The first generation is created by applying the above rules simultaneously to every cell in the seed, live or dead.
Births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick.
Each generation is a pure function of the preceding one.
The rules continue to be applied repeatedly to create further generations. 

## Examples of patterns
Many different types of patterns occur in the Game of Life, which are classified according to their behaviour.
Common pattern types include:

<table class="multicol" role="presentation" style="border-collapse: collapse; padding: 0; border: 0; background:transparent; width:auto; margin:auto;">


<tbody><tr>
<td style="text-align: left; vertical-align: top;">
<table class="wikitable">

<tbody><tr>
<th colspan="2">Still lifes
</th></tr>
<tr>
<td>Block
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_block_with_border.svg" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/thumb/9/96/Game_of_life_block_with_border.svg/66px-Game_of_life_block_with_border.svg.png" decoding="async" width="66" height="66" class="mw-file-element" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/9/96/Game_of_life_block_with_border.svg/99px-Game_of_life_block_with_border.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/9/96/Game_of_life_block_with_border.svg/132px-Game_of_life_block_with_border.svg.png 2x" data-file-width="66" data-file-height="66"></a></span>
</td></tr>
<tr>
<td>Bee-<br>hive
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_beehive.svg" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/thumb/6/67/Game_of_life_beehive.svg/98px-Game_of_life_beehive.svg.png" decoding="async" width="98" height="82" class="mw-file-element" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/6/67/Game_of_life_beehive.svg/147px-Game_of_life_beehive.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/6/67/Game_of_life_beehive.svg/196px-Game_of_life_beehive.svg.png 2x" data-file-width="98" data-file-height="82"></a></span>
</td></tr>
<tr>
<td>Loaf
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_loaf.svg" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Game_of_life_loaf.svg/98px-Game_of_life_loaf.svg.png" decoding="async" width="98" height="98" class="mw-file-element" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Game_of_life_loaf.svg/147px-Game_of_life_loaf.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Game_of_life_loaf.svg/196px-Game_of_life_loaf.svg.png 2x" data-file-width="98" data-file-height="98"></a></span>
</td></tr>
<tr>
<td>Boat
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_boat.svg" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Game_of_life_boat.svg/82px-Game_of_life_boat.svg.png" decoding="async" width="82" height="82" class="mw-file-element" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Game_of_life_boat.svg/123px-Game_of_life_boat.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Game_of_life_boat.svg/164px-Game_of_life_boat.svg.png 2x" data-file-width="82" data-file-height="82"></a></span>
</td></tr>
<tr>
<td>Tub
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_flower.svg" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/thumb/3/31/Game_of_life_flower.svg/82px-Game_of_life_flower.svg.png" decoding="async" width="82" height="82" class="mw-file-element" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/3/31/Game_of_life_flower.svg/123px-Game_of_life_flower.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/31/Game_of_life_flower.svg/164px-Game_of_life_flower.svg.png 2x" data-file-width="82" data-file-height="82"></a></span>
</td></tr></tbody></table>
</td>
<td style="text-align: left; vertical-align: top; padding-left: 1em;">
<table class="wikitable">

<tbody><tr>
<th colspan="2">Oscillators
</th></tr>
<tr>
<td>Blinker<br>(period 2)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_blinker.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/9/95/Game_of_life_blinker.gif" decoding="async" width="82" height="82" class="mw-file-element" data-file-width="82" data-file-height="82"></a></span>
</td></tr>
<tr>
<td>Toad<br>(period 2)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_toad.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/1/12/Game_of_life_toad.gif" decoding="async" width="98" height="98" class="mw-file-element" data-file-width="98" data-file-height="98"></a></span>
</td></tr>
<tr>
<td>Beacon<br>(period 2)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_beacon.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/1/1c/Game_of_life_beacon.gif" decoding="async" width="98" height="98" class="mw-file-element" data-file-width="98" data-file-height="98"></a></span>
</td></tr>
<tr>
<td>Pulsar<br>(period 3)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_pulsar.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/0/07/Game_of_life_pulsar.gif" decoding="async" width="137" height="137" class="mw-file-element" data-file-width="137" data-file-height="137"></a></span>
</td></tr>
<tr>
<td>Penta-<br>decathlon<br>(period&nbsp;15)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:I-Column.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/f/fb/I-Column.gif" decoding="async" width="89" height="145" class="mw-file-element" data-file-width="89" data-file-height="145"></a></span>
</td></tr></tbody></table>
</td>
<td style="text-align: left; vertical-align: top; padding-left: 1em;">
<table class="wikitable">

<tbody><tr>
<th colspan="2">Spaceships
</th></tr>
<tr>
<td>Glider
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_animated_glider.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/f/f2/Game_of_life_animated_glider.gif" decoding="async" width="84" height="84" class="mw-file-element" data-file-width="84" data-file-height="84"></a></span>
</td></tr>
<tr>
<td>Light-<br>weight<br>spaceship<br>(LWSS)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Game_of_life_animated_LWSS.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/3/37/Game_of_life_animated_LWSS.gif" decoding="async" width="126" height="98" class="mw-file-element" data-file-width="126" data-file-height="98"></a></span>
</td></tr>
<tr>
<td>Middle-<br>weight<br>spaceship<br>(MWSS)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Animated_Mwss.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/4/4e/Animated_Mwss.gif" decoding="async" width="162" height="146" class="mw-file-element" data-file-width="162" data-file-height="146"></a></span>
</td></tr>
<tr>
<td>Heavy-<br>weight<br>spaceship<br>(HWSS)
</td>
<td><span class="mw-default-size" typeof="mw:File"><a href="/wiki/File:Animated_Hwss.gif" class="mw-file-description"><img src="//upload.wikimedia.org/wikipedia/commons/4/4f/Animated_Hwss.gif" decoding="async" width="178" height="146" class="mw-file-element" data-file-width="178" data-file-height="146"></a></span>
</td></tr></tbody></table>
<p> 
</p>
</td></tr></tbody></table>

## To Do List
List of things I plan to implement in this project:
    
- [ ] Implement basic algorythm with console output.
    - [x] Implement field generation.
    - [ ] Implement random seeding.
    - [ ] Implement the playing field as the surface of a torus.
- [ ] Implement basic graphics and start to draw field and cells.
- [ ] Implement buttons to control the game process and its speed.