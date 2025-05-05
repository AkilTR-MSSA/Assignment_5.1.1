IsIntPalindrome(121);
IsIntPalindrome(-121);
IsIntPalindrome(123);
IsIntPalindrome(1331);

bool IsIntPalindrome(int x)
{
    int n = x;
    int reverse = 0;
    if (x < 0)
    {
        return false;
    }
    if (x >= 0 && x <= 9)
    {
        return true;
    }
    while (x > 0)
    {
        int digit  = x % 10;
        reverse = reverse * 10 + digit;
        x /= 10;
    }
    Console.WriteLine($"Input: x = {n}");
    Console.WriteLine($"Output: {n == reverse}");
    return n == reverse;

}