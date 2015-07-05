#ifdef __EMSCRIPTEN__
#include <emscripten.h>
#define export(T) extern "C" T EMSCRIPTEN_KEEPALIVE 
#else
#define export(T) extern "C" __declspec(dllexport) T
#endif

export(int) Add(int a, int b) {
    return a + b;
}