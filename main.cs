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

        //Create a Array for Sum
        int[,] sumArray = new int[lineCount,lineCount];
        
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
        
        //Define a variables for check max deep line
        int checkMaxLine = 0;
        bool checkMaxLineTmp = false;

        //Find the maximum sum of the numbers according to given rules
        for (int i = 1; i < lineCount; i++) {
			for (int j = 0; j <= i; j++) {
			    if(IsThisPrimeNumber(variableArray[i,j])){
			        variableArray[i,j]=0;
			    }else{
			        variableArray[i,j] = Math.Max(variableArray[i-1, j] + variableArray[i, j], variableArray[i,j] + variableArray[i-1, j+1]);
                    checkMaxLineTmp=True;
			    }
			}

            if(checkMaxLineTmp==true){
                checkMaxLine = checkMaxLine+1;
                checkMaxLineTmp = false;
            }else{
                break;
            }
		}

        //Find the max sum in deep row
        int max = variableArray[checkMaxLine][0];
        for (int i = 1; j < checkMaxLine; i++)
        {
            if (A[checkMaxLine][i] > max)
            {
            max = A[checkMaxLine][i];
            }
        }

		//Print result on the screen
		Console.WriteLine (max);
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
