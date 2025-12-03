# Minireto de acceso a datos
Es un programa para gestionar *videojuegos*, se pueden dar de alta, eliminar y guardarlos en un archivo txt.

## Datos sobre cada videojuego:
+ Titulo
+ Consola
+ Estudio
+ Tiempo de speedrun
+ Speedruner
+ Año de estreno
     
| Titulo | Consola | Estudio | Tiempo de speedrun | Speedruner |Año de estreno |  
| :----: | :----- | -----: | :-------: | :------ | ------: | 
| Pokemon | Nintendo | Gamefreak | 30000 |Jonathan| 2025 |  
  
  [AQUI TIENES EL ENLACE AL PROYECTO](https://github.com/xabidefuentes/MiniReto/edit/main/README.md)  

  ## IMAGEN 
  ![IMAGEN](https://occ-0-8407-2218.1.nflxso.net/dnm/api/v6/6AYY37jfdO6hpXcMjf9Yu5cnmO0/AAAABdUHPu2AmsdSwALVHPueZYcsNPLb_ULHcKprf8oHIA3LZhB4MyCIbygPM_Lb3qZGtMTCo0LxB25YuEhgnv-zumVhHpeLOywhF4SL.jpg?r=db8)  
  >> Esta es la imagen del videojuego Pokemon
---
## CÓDIGO
   ```basic
Public Sub anadirVideojuego(videojuego As Videojuego)
    ' Comprobar que no se supera el límite del array
    If cantidad >= listaVideojuegos.Length Then
        MessageBox.Show("No se pueden añadir más videojuegos (límite alcanzado).")
        Return
    End If

    ' Añadir el videojuego al array
    listaVideojuegos(cantidad) = videojuego
    cantidad += 1

    ' Actualizar la interfaz
    ActualizarListView()
End Sub
```

<Details open>
     <Summary>Videojuegos disponibles</Summary>

     ## VIDEOJUEGOS:

     + Minecraft
     + League of Legends
     + GTA5
</details>

**Creadores:**  ***Nekane Minguito, Xabier De Fuentes, Mikel Gonzalez, Maialen Perez***
