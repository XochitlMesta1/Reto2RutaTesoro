# Reto2RutaTesoro
# Reto 2 — La Ruta del Tesoro Perdido

Implementación completa del reto: lista simplemente enlazada **construida desde cero**
en C# / .NET, con interfaz Windows Forms.

## Cómo abrirlo
1. Abre Visual Studio → **Abrir un proyecto o solución** → selecciona `Reto2RutaTesoro.csproj`.
   (También puedes crear una solución nueva vacía y agregar estos archivos a un proyecto
   WinForms en blanco si tu versión de Visual Studio lo requiere).
2. Verifica que el Target Framework del proyecto coincida con el .NET que tengas instalado
   (el `.csproj` apunta a `net10.0-windows`; cámbialo a `net8.0-windows` si aún no tienes
   el SDK de .NET 10 instalado).
3. Presiona **F5** para ejecutar.

## Estructura de archivos
```
Reto2RutaTesoro/
├── Nodo.cs                     -> representa cada ubicación (id, nombre, pista, peligro, Siguiente)
├── ListaSimple.cs               -> lista enlazada desde cero: Insertar, Buscar, Modificar, Eliminar, Recorrer
├── FrmRutaTesoro.cs              -> interacción del usuario; SOLO llama a métodos de ListaSimple
├── FrmRutaTesoro.Designer.cs     -> controles de WinForms generados por el diseñador
├── Program.cs                    -> punto de entrada de la aplicación
└── Reto2RutaTesoro.csproj
```

## Cómo cumple la restricción principal
- `ListaSimple` no usa `List<T>`, `LinkedList<T>`, `Queue<T>`, `Stack<T>`, `Dictionary<TKey,TValue>`
  ni arreglos como almacenamiento: la única estructura real es la cadena de objetos `Nodo`
  enlazados por la propiedad `Siguiente`, empezando en el campo privado `inicio`.
- El `DataGridView` se llena exclusivamente a través de `ListaSimple.Recorrer()`, que
  camina la lista desde `Inicio` hasta `NULL`. El grid nunca almacena datos por sí mismo:
  cada vez que se agrega, modifica o elimina un nodo, se vuelve a llamar `ActualizarGrid()`.
- Los eventos de los botones (`btnAgregar_Click`, `btnModificar_Click`, `btnEliminar_Click`,
  `btnBuscar_Click`) no contienen lógica de la estructura de datos: únicamente validan la
  entrada y delegan la operación real a los métodos de `ListaSimple`, tal como pide el reto:

  ```
  btnEliminar_Click
        ↓
  ListaSimple.Eliminar(id)
        ↓
  Manipulación de nodos
        ↓
  Actualizar DataGridView
  ```

## Funcionalidad incluida
- **Insertar**: agrega un nuevo nodo al final de la lista (valida ID único).
- **Buscar**: recorre la lista y muestra la pista y el peligro de la ubicación encontrada.
- **Modificar**: localiza el nodo por ID y actualiza sus datos in-place.
- **Eliminar**: religa los punteros correctamente, incluyendo el caso especial de eliminar
  el primer nodo (`Inicio`).
- **Recorrer**: usado internamente para refrescar el `DataGridView` tras cada operación.
- Datos de ejemplo precargados (Playa del Naufragio, Cueva del Kraken, Isla Calavera,
  Templo Perdido) para probar la app de inmediato.
- Al seleccionar una fila del grid, los campos del formulario se autocompletan para
  facilitar modificar o eliminar esa ubicación.

