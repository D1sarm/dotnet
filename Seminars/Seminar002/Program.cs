// 22. Найти расстояние между двумя точками в пространстве 2D/3D

double GetValue(string text){
    System.Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double result){
    // string output = "|A(" + ax + ", "+ ay + "); B(" + bx + ", " + by + ")| = " + Math.Round(result, 2);
    string output = $"|A({ax}, {ay}); B({bx}, {by})| = {Math.Round(result, 2)}";
    Console.WriteLine(output);
}

double GetDisnatce(double ax, double ay, double bx, double by){
    double x = Math.Pow((ax - bx), 2);
    double y = Math.Pow((ay - by), 2);
    double result = Math.Sqrt(y + x);
    return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDisnatce(ax,ay,bx,by);
Print(ax,ay,bx,by,dis);
