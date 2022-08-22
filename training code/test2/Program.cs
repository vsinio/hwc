string text1 =
    "— Погляди в стекло, Герда, — сказал он"
    + "Каждая снежинка казалась под стеклом куда больше, чем была на самом деле, "
    + "и походила на роскошный цветок или десятиугольную звезду. Это было так красиво!"
    + "— Видишь, как хитро сделано! — сказал Кай. — Гораздо интереснее настоящих цветов!"
    + " И какая точность! Ни единой неправильной линии! Ах, если б только они не таяли!";

string Sreplace(string text, char oldSymb, char newSymb)
{   int length = text.Length;
    string result = String.Empty;
        for (int i = 0; i < length; i++)
        {
            if(text[i]==oldSymb) result = result + $"{newSymb}"; // $"{newSymb}"
            else result = result + $"{text[i]}";
        
        }
        return result;


}

string rep = Sreplace(text1, ' ', '_');
Console.WriteLine(rep);
rep = Sreplace(rep, 'с', 'S');
Console.WriteLine(rep);
rep = Sreplace(rep, 'о','О');
Console.WriteLine(rep);