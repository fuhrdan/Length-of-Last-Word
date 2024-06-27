//*****************************************************************************
//** 58. Length of Last Word leetcode                                        **
//** Simple but effective approach to count the numbers in a word and save   **
//** the last word recorded.  It's a slower solution but works.  -Dan        **
//*****************************************************************************

int lengthOfLastWord(char* s) {
    int retNum = 0;
    int convert = 0;
    int lastword = 0;
    for(int i = 0; i < strlen(s); i++)
    {
        convert = s[i];
        printf("%d %d %d\n",convert,retNum,lastword);
        retNum++;
        if(convert == 32)
        {
            if(retNum > 1) lastword = retNum;
            retNum = 0;
        }
    }
    if(retNum > 0)
        return retNum;
    else
        return lastword-1;
}