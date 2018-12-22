/*Onur Karakaya // P.I. Works - Technical Questionnaire - Junior Front End SW Developer*/

using System;
using System.Collections.Generic;
using System.IO;

class TechnicalQuestionnaire
{
    static void Main ()
    {
        //Read the File and find the count of lines
        var lineCount = File.ReadAllLines ("inputs.txt").Length;
        
        //Create a Array with lineCount
        int[,] variableArray = new int[lineCount,lineCount];
        
        //Read the File and set the variableArray with inputs
        using (var readFile = new StreamReader("inputs.txt"))
        {
            int row = 1;
            
            while (!readFile.EndOfStream)
            {
                var line = readFile.ReadLine().Trim();
                var values = line.Split(' ');
                
                for(int i = 0; i<row; i++){
                    variableArray[(row-1),i]=Int32.Parse(values.GetValue(i).ToString());
                }
                row++;
            }
        }
        
        //Find the maximum sum of the numbers according to given rules
        for (int i = (lineCount-2); i >= 0; i--) {
			for (int j = 0; j < (lineCount-1); j++) {
			    if(IsThisPrimeNumber(variableArray[i,j])){
			        variableArray[i,j]=0;
			    }else{
			        variableArray[i,j] = Math.Max(variableArray[i, j] + variableArray[i+1, j], variableArray[i,j] + variableArray[i+1, j+1]);
			    }
			}
		}
		
		//Print result on the screen
		Console.WriteLine (variableArray [0, 0]);
    }
    
    //Prime number check function
    public static bool IsThisPrimeNumber(int number)
    {
        for (int i=2; i<number; i++)
        {
            if (number %i == 0){
                return false;
            }
        }
        if(number == 1 || number == 0){
            return false;
        }
        return true;
    }
}