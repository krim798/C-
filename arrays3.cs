// Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
string[] id = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach(string i in id)
{
    if(i.StartsWith("B"))
    {
        Console.WriteLine(i);
    }
    
}
  
