#include "Header.h"

void Function4Byte(Struct4Byte* output, int x)
{	
	output->x1 = 1 + x;
}

void Function12Byte(Struct12Byte* output, int x)
{	
	output->x1 = 1 + x;
	output->x2 = 2 + x;
	output->x3 = 3 + x;
}
