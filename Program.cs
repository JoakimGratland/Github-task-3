/* ---------------------------------------------------------------------------------------------
    
    Task A: 
    Define a variable for your favourit fruit and instiansiate it with the correct data.

 ---------------------------------------------------------------------------------------------*/


string favouritFruit = "Pear";  





/* ---------------------------------------------------------------------------------------------
    
    Task B: 
    Define a variable for number of fruit (anny) consumed in the last week statring from today
    instiansiate it with the correct data.

 ---------------------------------------------------------------------------------------------*/


int numberOfFruitInBag = new Random().Next(0, 2);



/* ---------------------------------------------------------------------------------------------

   Task C: 
   Define a variable that tells us if fruits have been consumed within the last week.
   Instanciate with the correct value. 

   Bonus: Instanciate it using a logical statment.

---------------------------------------------------------------------------------------------*/


bool eatenFruitLastWeek = numberOfFruitInBag > 0; 




/* ---------------------------------------------------------------------------------------------
    
    Task D: 
    Define a variable to hold a listing of your favourit fruit (minimum 3 fruits)
    instiansiate it with the correct data.

    Hint: The type of your variable should be string[]

 ---------------------------------------------------------------------------------------------*/

string[] listOfFruits = new string[] { "Kiwis", "Apples", "Oranges" };
List<string> fruitList = new List<string>(listOfFruits);





/* ---------------------------------------------------------------------------------------------
    
    Task D: 
    Using your previously decleard variables write out a text conforming to this pattern if fruit have been eaten:
    My name is xxxx, and my absolute favourit fruit is xxxx. But i also like xxxx,xxx,xxx. In the last week I have eaten xx fruit in the previous week.
    If no fruits have been eaten the output should be:
    My name is xxxx, and my absolute favourit fruit is xxxx. But i also like xxxx,xxx,xxx. No fruit for me the last week.

    NB! your code must be able to deal with both scenarios.

 ---------------------------------------------------------------------------------------------*/
  if (eatenFruitLastWeek)
        {
            Console.WriteLine($"My name is Joakim, and my absolute favourit fruit is {favouritFruit}. But I also like {string.Join(", ", fruitList)}. In the last week, I have eaten {numberOfFruitInBag} fruits in the previous week.");
        }
        else
        {
            Console.WriteLine($"My name is Joakim, and my absolute favourit fruit is {favouritFruit}. But I also like {string.Join(", ", fruitList)}. No fruit for me the last week.");
        }