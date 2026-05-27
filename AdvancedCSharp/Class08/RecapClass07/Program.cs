//public class Solution
//{
//    public bool CanJump(int[] nums)
//    {
//        int maxReach = 0;

//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (i > maxReach)
//            {
//                return false;
//            }
//            maxReach = Math.Max(maxReach, i + nums[i]);
//            if (maxReach >= nums.Length - 1)
//            {
//                return true;
//            }
//        }
//        return true;
//    }
//}


//tip na metoda se delegatite
//tip za metoda se delegatite
//sto go delegira toj tip 
//return value parametrite i sto vrakja

//OVA SE DLEGETI

//Nashi delegati
//delegate isto kako da definirame signature na metoda so
//public delegate (return tyope (double)) CalculateDelagete(int num1, int num2);

//private double Calculate(int num1, int num2, CalculateDelegate operation)
//{ 
//    return operation (num1, num2);
//}


//mora da imame event
//i delegat za kakvi porcesi mozat da se subnat
//
//metodata e od koj tip PromotionHendler
//deka eventot e od tip PromotionHendler
//moze da se prifati promocijata sto kje sluci

//event gi cuva metodite
//mozat da se subnat i unsubsribnat


//tip na metoda DELEGATI
//events 

