# BinaryPatternCreator

Very simple tool.

What it basically does is:

If you have the following Hexpattern ->

```
0F D7 C2 FF 00 94
```

and the next time it's slightly different (for example if you want to find a pattern with Cheat Engine)
you'll want to use wildcards. Some tools accept "??" as wildcards.

Next time you'll have 
```
0F D7 C2 FE 01 94
```

instead, for example.

Insert both lines, press a button, and the result should be

```
0F D7 C2 ?? ?? 94
```

Nothing more :)
