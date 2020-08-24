# PokemonBack
Api REST para una aplicaciond e Pokedex, hecha en .net Core 2.2 El contexto de datos fue hecho con Entity framework 2.2, 
para crear la base de datos se debe modificar el connection string de nombre "pokemonDb",que esta en el archivo "appsettings.json" 
del proyecto del web Api,una vez modificado el connection string se debe abrir la consola de administrador de paquetes apuntando al proyecto de 
PokemonData y una vez ahi ejecutar el comando "update-database -migration security", despues el comando "update-database -migration security". 
Proyecto hecho con visual studio 2019 community y .net Core 2.2
