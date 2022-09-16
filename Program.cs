// SNACK 1


//Console.WriteLine("Inserisci il primo numero..");
//int numFirst = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Inserisci il secondo numero..");
//int numSecond = Convert.ToInt32(Console.ReadLine());

//Console.Clear();
//Console.WriteLine("Il numero più grande è: ");
//if(numFirst < numSecond)
//{

//    Console.WriteLine(numSecond);
//}
//else
//{
//    Console.WriteLine(numFirst);
//}

// fine snack 1



// SNACK 2


//Console.WriteLine("Inserisci la prima parola..");
//string wordFirst = Console.ReadLine();
//Console.WriteLine("Inserisci la seconda parola..");
//string wordSecond = Console.ReadLine();

//Console.Clear();
//Console.WriteLine("Il numero più grande è: ");
//if (wordFirst.Length < wordSecond.Length)
//{

//    Console.WriteLine("La parola piu lunga è {0} mentre la piu corta è {1}", wordSecond, wordFirst);
//}
//else
//{
//    Console.WriteLine("La parola piu lunga è {0} mentre la piu corta è {1}", wordFirst, wordSecond);
//}


//// fine snack 2





// SNACK 3


//int sum = 0;

//int[] numbers = new int[10];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());

//    sum += numbers[i];
//}
//Console.Clear();
//Console.WriteLine("La somma dei numeri inseriti è {0}",sum);

// fine snack 3



// SNACK 4

//int sum = 0, avg = 0;
//for (int i = 2; i < 11; i++)
//{
//    sum += i;
//    avg = sum / 9;
//}
//Console.WriteLine("La somma dei numeri da 2 a 10 è {0} e la media è {1}", sum,avg);

// fine snack 4




// SNACK 5

//int num = 0;
//Console.WriteLine("Inserisci un numero");
//num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.Clear();
//    Console.WriteLine(num);
//}
//else
//{
//    Console.Clear();
//    Console.WriteLine(num + 1);
//}



// fine snack 5


//SNACK 6


//string[] guests = { "mario", "paolo", "luca" };
//Console.WriteLine("Scrivi il tuo nome per verificare se sei stato invitato");
//string input = Console.ReadLine();
//input = input.ToLower();
//bool invited = false;

//for (int i = 0; i < guests.Length; i++)
//{
//    if(guests[i] == input)
//    {
//        invited = true;
//    }

//}
//if (invited)
//{
//    Console.WriteLine("Sei invitato!!");
//}
//else
//{
//    Console.WriteLine("Non sei invitato!!");

//}


// fine snack 6


//SNACK 7

//int[] numbers = new int[6];
//int input;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    input = Convert.ToInt32(Console.ReadLine());
//    if(input % 2 != 0)
//    {
//        numbers[i] = input;
//    }
//}

//foreach (int i in numbers)
//{
//    if(i != 0)
//    {
//        Console.WriteLine(i);

//    }
//}

// fine snack 7


// SNACK 8

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if(i % 2 != 0)
//    {
//       sum += numbers[i] ;
//        Console.WriteLine(i);
//    }
//}
//Console.WriteLine(sum);

// fine snack 8


// SNACK 9


int sum = 0;
int[] numbers = new int[50];


    for (int i = 0; i < numbers.Length; i++)
    {
        while(sum < 50)
        {
            Console.Clear();
            Console.WriteLine("Inserisci un numero");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }
    }  
    Console.WriteLine("La somma dei numeri è uguale o superiore a 50 attualmente siamo a {0}", sum);


//  fine snack 9
