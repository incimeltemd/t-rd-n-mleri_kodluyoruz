﻿////

//implicit tür dönüşümleri
byte a = 5;
int b = a;

string c = "meltem";
object d = c;

//explicit tür dönüşümleri
int e = 45;
byte f = (byte)e;

string g = e.ToString();

string h = "6";
int j = Convert.ToInt32(h);

string k = "27";
int l = Int32.Parse(k);