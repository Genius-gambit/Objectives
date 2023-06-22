#include <stdlib.h>
#include <unistd.h>
#include <stdio.h>

/*
	** Give me a Diamond
*/

char *diamond (int n)
{
  char  *str
  if ((n % 2 == 0) || n <= 0)
    return (NULL);
  if (n == 1)
  {
    str = (char *)calloc(3, sizeof(char));
	str[0] = '*';
	str[1] = '\n';
	str[2] = 0;
	return(str);
  }
  else
  {
	int	stars = n + 1;

  }
// allocate a string on the heap, memory will be freed
	// return calloc(1, 1);
}
