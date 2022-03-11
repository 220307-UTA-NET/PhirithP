#!/user/bin/bash

#create  a list of ingredients for chicken fried rice 
#recipe="1.cold rice 2.cooked chicken 3.eggs 4.soy sauce 5.black and white pepper 6.salt 7.sugar 8.msg 9.green onion 10.bok choy" 
recipe=("cold rice" "cooked chicken" "eggs" "soy sauce" "black and white pepper" "salt" "sugar" "msg" "green onion" "bok choy")		# edited by Zhixin He
echo "My Recipe for Chicken Fried Rice are:"

#create a loop that will go through every item the list of for the recipe
#for r in $recipe
for index in ${!recipe[@]}		# edited by ZhixinHe
do

	sleep .5s

	#displays the recipe
	echo ${recipe[$index]}		# edited by ZhixinHe
	#echo $r 

done
	echo $recipe >> ./MyRecipe.txt

