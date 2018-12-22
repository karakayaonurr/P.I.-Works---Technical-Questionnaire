# P.I.-Works-Technical-Questionnaire

## Question

You will have a ORTHOGONAL TRIANGLE input from a file and you need to find the maximum sum of the numbers according to given rules below;

1. You will start from the top and move downwards to an adjacent number as in below.
2. You are only allowed to walk downwards and diagonally.
3. You can only walk over NON PRIME NUMBERS.
4. You have to reach at the end of the pyramid as much as possible.

According to above rules the maximum sum of the numbers from top to bottom in below example is 24.

      *1
     *8 4
    2 *6 9
   8 5 *9 3

As you can see this has several paths that fits the rule of NOT PRIME NUMBERS; 1>8>6>9, 1>4>6>9, 1>4>9>9
1 + 8 + 6 + 9 = 24.  As you see 1, 8, 6, 9 are all NOT PRIME NUMBERS and walking over these yields the maximum sum.

### Answer

![1](https://user-images.githubusercontent.com/39087452/50376954-faa22e00-0625-11e9-8b9e-8eab169bb357.png)

![2](https://user-images.githubusercontent.com/39087452/50376955-faa22e00-0625-11e9-9433-a7a076e7de01.png)

![3](https://user-images.githubusercontent.com/39087452/50376956-faa22e00-0625-11e9-88c3-f1daec339745.png)
