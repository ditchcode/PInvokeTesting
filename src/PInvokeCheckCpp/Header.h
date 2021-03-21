#define DLL_API __declspec(dllexport)

struct Struct4Byte
{
	int x1;
	Struct4Byte() { x1 = 0; }
};

struct Struct12Byte
{
	int x1;
	int x2;
	int x3;
	Struct12Byte() { x1 = 0; x2 = 1; x3 = 2; }
};

#ifdef __cplusplus
extern "C" {
#endif
	DLL_API void Function4Byte(Struct4Byte* s, int x);
	DLL_API void Function12Byte(Struct12Byte* s, int x);
#ifdef __cplusplus
}
#endif

