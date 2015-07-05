del clib.js
del /q bin\JSIL\*
call emcc -s EXPORT_FUNCTION_TABLES=1 -s MODULARIZE=1 -s RESERVED_FUNCTION_POINTERS=8  -s EXPORTED_FUNCTIONS="['_Add']" clib.cpp -o clib.js
call ..\JSIL\bin\JSILc MinimalPInvoke.sln --out=bin/JSIL/