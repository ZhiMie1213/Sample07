using SampleCode07;
using System.Linq;


public class Program
{
    private static readonly double[] array = 
    {
        980.0969548024685,
        448.7701170278722,
        476.8396994574119,
        323.87896643249525,
        137.9586537219506,
        183.8177389107478,
        568.6475922417197,
        540.5221554309112,
        60.486847789444134,
        280.0067951846643,
        327.41532924796326,
        916.0709759441389,
        923.7515600275211,
        817.6131103197356,
        396.07448778419587,
        413.5932681191092,
        846.7432663558135,
        90.293040240928,
        822.429870469622,
        475.30153544624557
    };

    private static readonly Human[] HumanArray = new Human[]
    {
        new Human("axopsfbq", 1.4241812080699776, 39.66258910689785),
        new Human("wywrsukr", 1.2052437379520782, 83.93623749576344),
        new Human("cyntttwv", 1.9233342479290094, 57.97235027865729),
        new Human("qavgascd", 1.3566616822293107, 69.13378534206977),
        new Human("nypjkvwk", 1.887598519532068, 92.43284091147487),
        new Human("jcrjiiml", 1.4693704478477736, 60.72979826101077),
        new Human("sorellyt", 1.0057702959349735, 99.3024453788609),
        new Human("tvudrkyv", 1.766958370836046, 99.49177615184219),
        new Human("cnkikcbb", 1.6736161567862977, 30.9501596766266),
        new Human("zezprsyr", 1.98824201049539, 48.02352261158504),
        new Human("silksowh", 1.6217407754409803, 57.66213483635231),
        new Human("kxmajtpp", 1.4466943897667885, 73.3490690474544),
        new Human("zzzdwkif", 1.908807492402414, 70.02617647730594),
        new Human("atymzqiw", 1.1806285575660156, 85.1172960519118),
        new Human("nonhgank", 1.7718513626068861, 47.5456878872771),
        new Human("rnmyqgjc", 1.4246976358382506, 81.748281877708),
        new Human("hfpsvimp", 1.0411190058158288, 51.86910790233108),
        new Human("kqqtanzz", 1.4611379552457313, 32.014714783138345),
        new Human("tmjndmih", 1.7806940892375738, 80.29353141931182),
        new Human("amfxecev", 1.5377742775981906, 89.19415528168523),
    };

    public static void Main(string[] args)
    {
        Handson07();
    }

    private static void GenerateRandomHumanArrayCode()
    {
        string code = "";
        for (int i = 0; i < 20; i++)
        {
            var human = Human.GenerateRandom();
            code += "new Human(";
            code += "\"" + human.Name + "\", " + human.Height + ", " + human.Weight;
            code += "),\n";
        }
        Console.WriteLine(code);
    }

    private static void Handson01()
    {
        RepresentativeValueCalculator calclator =
            new RepresentativeValueCalculator(new Median());




        //↑とは別の場所に書かれている想定
        double rValue = calclator.GetRepresentativeValue(array);
        Console.WriteLine("代表値:" + rValue);


        /*
        //ランダムdouble配列をソースコードとして得る
        double[] array = CreateRandomDoubleArray(20);
        Console.WriteLine(GetArrayCode(array));
        */
    }

    //ランダムなdouble配列を作る
    private static double[] CreateRandomDoubleArray(int length)
    {
        Random random = new Random();
        double[] ret = new double[length];

        //0～1000までの範囲でランダムにdouble配列を作る
        for (int i = 0; i < length; i++)
        {
            ret[i] = random.NextDouble() * 1000.0;
        }
        return ret;
    }

    private static string GetArrayCode(double[] array)
    {
        string ret = "{\n" + array[0].ToString();
        for (int i = 1;i < array.Length;i++)
        {
            ret += ",\n" + array[i].ToString();
        }
        ret += "}";
        return ret;
    }

    public static void Handson03()
    {
        Func<int, int, string> func = DelegateFunctions.Power;

        string result = func.Invoke(15, 4);
        Console.WriteLine(result);
    }

    public static void Handson04()
    {
        //ラムダ
        var sum = (int a, int b) => (a + b).ToString();
        //Func<int, int, int> multiply = (a, b) => a * b;

        string result = sum.Invoke(15, 4);
        Console.WriteLine(result);
    }

    public static void Handson05()
    {
        Func<double[], double> getRepresentativeValue = array =>
        {
            //平均値を出す
            double sum = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        };


        //↑とは別の場所に書かれている想定
        double rValue = getRepresentativeValue.Invoke(array);
        Console.WriteLine("代表値:" + rValue);
    }

    public static void Handson06()
    {
        int number = 0;

        Console.WriteLine("1:" + number);

        Action action = () => number++;

        Console.WriteLine("2:" + number);

        action.Invoke();

        Console.WriteLine("3:" + number);

        action.Invoke();
        action.Invoke();

        Console.WriteLine("4:" + number);
    }


    public static void VarUsage()
    {
        //varの使い方
        //Average avg = new Average();
        var avg = new Average();
    }


    public static void LinqUsage()
    {
        //LINQの使い方
        int[] elements = new int[]
        { 1, 5, 786, 453, 8, 15, 3, 78, 4, 8, 78, 97, 6, 345 };

        //where句
        var even = elements.Where(x => x % 2 == 0);
        foreach (var element in even)
        {
            //Console.WriteLine(element);
        }

        //select句
        var doubled = elements.Select(x => x * 2);
        var stringfy = elements.Select(x => x.ToString());
        foreach (var element in doubled)
        {
            //Console.WriteLine(element);
        }

        //orderby句
        var sorted = elements.OrderBy(x => x);
        foreach (var element in sorted)
        {
            Console.WriteLine(element);
        }
    }

    public static void Handson07()
    {
        //身長1.5m以上の人間だけを抜き出す
        var humanHigherThan150cm = HumanArray.Where(human => human.Height > 1.5);
        foreach (var human in humanHigherThan150cm)
        {
            //Console.WriteLine(human.Name);
        }

        //BMIが15-25の人間だけを抜き出す
        var humanBMI = HumanArray.Where(human =>
        {
            double bmi = human.Weight / (human.Height * human.Height);
            return bmi > 15.0 && bmi < 25.0;
        });
        foreach (var human in humanBMI)
        {
            Console.WriteLine(human.Name);
        }
    }
}