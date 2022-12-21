# Torres de Hanoi
Un programa sencillo creado en C# que enseña como resolver el puzle de las Torres de Hanoi.

¿Como funciona?
- Se selecciona el número de discos que se quieren (desde 2 hasta 9).
- Se selecciona la torre a la que se quiere mover los discos (en la segunda o tercera torre).
- Enseñará el resultado en formato texto.

Ejemplo: Se quiere mover tres discos desde la primera hasta la tercera torre.
- A: 1 2 3 - B: 0 0 0 - C: 0 0 0
- A: 0 2 3 - B: 0 0 0 - C: 1 0 0
- A: 0 0 3 - B: 0 2 0 - C: 1 0 0
- A: 0 0 3 - B: 1 2 0 - C: 0 0 0
- A: 0 0 0 - B: 1 2 0 - C: 0 0 3
- A: 1 0 0 - B: 0 2 0 - C: 0 0 3
- A: 1 0 0 - B: 0 0 0 - C: 0 2 3
- A: 0 0 0 - B: 0 0 0 - C: 1 2 3