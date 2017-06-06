#!/bin/bash

# inicializacion
echo -n > ciudades.sql
printf "INSERT INTO Ciudad VALUES(" >> ciudades.sql;
c=1;

# procesar las 238 lineas del archivo ciudades_departamento_py.csv
for ((i=1;i<=238;i++)); do
	line=$(head -n $i ciudades_departamento_py.csv | tail -n1)
       	IFS=','
	for field in $line; do
		if [ $c -eq 1 ]; then
			let c=$c+1
		       	continue;
	       	elif [ $c -lt 4 ]; then
		        field=$(echo -n "$field" | sed "s/'/''/g")
		       	printf "$field," >> ciudades.sql
			let c=$c+1
		else 
			printf "'$field');\r\n" >> ciudades.sql;
		       	c=1;
		       	if [ $i -lt 238 ]; then
			       	printf "INSERT INTO Ciudad VALUES(" >> ciudades.sql
			fi
		fi
	done
	IFS=' '
done
