repeat="true" Milk="4" Water="2" Bread="1" Candy="2" Juice="3"
total="0"
while [ "$repeat" == "true" ]
do
echo "Welcome to our store!"
echo "Please enter what you would like to purchase"
echo "Milk, Water, Bread, Candy, Juice"
echo "To leave please enter Checkout"

read answer
if [ "$answer" == "Milk" ]
then
	echo "Milk is $Milk"
	total=$(($total+$Milk))
	echo "your total is $total"
elif [ "$answer" == "Water" ]
then
	echo "Water is $Water"
	total=$(($total+$Water))
	echo "your total is $total"
elif [ "$answer" == "Bread" ]
then
	echo "Bread is $Bread"
	total=$(($total+$Bread))
	echo "your total is $total"
elif [ "$answer" == "Candy" ]
then
	echo "Candy is $Candy"
	total=$(($total+$Candy))
	echo "your total is $total"

elif [ "$answer" == "Juice" ]
then
	echo "Juice is $Juice"
	total=$(($total+$Juice))
	echo "your total is $total"
elif [ "$answer" == "Checkout" ]
	echo "This is your total $total"
then
	repeat="false"
else
	echo "Please choose a correct option"
fi

done
