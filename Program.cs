using System;

namespace Matrix
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            while(exit != "y")
            {
                Console.WriteLine("1.Matrix\n2.Square matrix\n3.Vector\nExit - 0\n\nEnter num");
                string type = Convert.ToString(Console.ReadLine());

                Console.Clear();

                if (type == "0") break;

                switch(type)
                {
                    case "1":
                        while(exit != "0")
                        {
                            Console.WriteLine("1 or 2 matrix");
                            string numOfMatrix = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            switch (numOfMatrix)
                            {
                                case "1":
                                    Console.WriteLine("Enter num of row");
                                    int row = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter num of column");
                                    int column = Convert.ToInt32(Console.ReadLine());

                                    Matrix matrix = new Matrix(row, column);

                                    Console.Clear();

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling = Convert.ToString(Console.ReadLine());
                                    Console.Clear();

                                    switch (filling)
                                    {
                                        case "1":
                                            matrix.ManualInput(matrix);

                                            Console.Clear();

                                            Console.WriteLine("Your matrix");
                                            matrix.ShowMatrix(matrix);

                                            Console.WriteLine("\nBack - 0");
                                            exit = Convert.ToString(Console.ReadLine());

                                            Console.Clear();
                                            break;

                                        case "2":
                                            matrix.Random(matrix);

                                            Console.WriteLine("Your matrix");
                                            matrix.ShowMatrix(matrix);

                                            Console.WriteLine("\nBack - 0");
                                            exit = Convert.ToString(Console.ReadLine());

                                            Console.Clear();
                                            break;
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Enter num of row 1 matrix");
                                    int row1 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter num of column 1 matrix");
                                    int column1 = Convert.ToInt32(Console.ReadLine());

                                    Console.Clear();

                                    Console.WriteLine("Enter num of row 2 matrix");
                                    int row2 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter num of column 1 matrix");
                                    int column2 = Convert.ToInt32(Console.ReadLine());

                                    Console.Clear();

                                    Matrix matrix1 = new Matrix(row1, column1);
                                    Matrix matrix2 = new Matrix(row2, column2);

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling1 = Convert.ToString(Console.ReadLine());

                                    switch(filling1)
                                    {
                                        case "1":
                                            matrix1.ManualInput(matrix1);

                                            Console.Clear();

                                            matrix2.ManualInput(matrix2);

                                            Console.Clear();

                                            Console.WriteLine("Your 1 matrix");
                                            matrix1.ShowMatrix(matrix1);
                                            Console.WriteLine("Your 2 matrix");
                                            matrix2.ShowMatrix(matrix2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet = "";

                                            while(repet != "0")
                                            {
                                                Console.WriteLine("What operation to perform?(+, -, *)");
                                                string operator1 = Convert.ToString(Console.ReadLine());

                                                switch (operator1)
                                                {
                                                    case "+":
                                                        Matrix matrix3 = matrix1 + matrix2;
                                                        matrix3.ShowMatrix(matrix3);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        break;

                                                    case "-":
                                                        Matrix matrix4 = matrix1 - matrix2;
                                                        matrix4.ShowMatrix(matrix4);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        break;
                                                    case "*":
                                                        Matrix matrix5 = matrix1 * matrix2;
                                                        matrix5.ShowMatrix(matrix5);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        break;
                                                }
                                            }

                                            Console.Clear();
                                            break;

                                        case "2":
                                            matrix1.Random(matrix1);
                                            matrix2.Random(matrix2);

                                            Console.WriteLine("Your 1 matrix");
                                            matrix1.ShowMatrix(matrix1);
                                            Console.WriteLine("Your 2 matrix");
                                            matrix2.ShowMatrix(matrix2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet1 = "";

                                            while(repet1 != "0")
                                            {
                                                Console.WriteLine("What operation to perform?(+, -, *)");
                                                string operator2 = Convert.ToString(Console.ReadLine());

                                                switch (operator2)
                                                {
                                                    case "+":
                                                        Matrix matrix3 = matrix1 + matrix2;
                                                        matrix3.ShowMatrix(matrix3);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        break;

                                                    case "-":
                                                        Matrix matrix4 = matrix1 - matrix2;
                                                        matrix4.ShowMatrix(matrix4);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        break;
                                                    case "*":
                                                        Matrix matrix5 = matrix1 * matrix2;
                                                        matrix5.ShowMatrix(matrix5);

                                                        Console.ReadKey();
                                                        Console.Clear();

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        break;
                                                }
                                            }
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;

                    case "2":
                        while(exit != "0")
                        {
                            Console.WriteLine("1 or 2 matrix");
                            string numOfMatrix = Convert.ToString(Console.ReadLine());
                            Console.Clear();

                            switch(numOfMatrix)
                            {
                                case "1":
                                    Console.WriteLine("Enter rank matrix");
                                    int rank = Convert.ToInt32(Console.ReadLine());

                                    SquareMatrix squareMatrix = new SquareMatrix(rank);

                                    Console.Clear();

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling = Convert.ToString(Console.ReadLine());
                                    Console.Clear();

                                    switch(filling)
                                    {
                                        case "1":
                                            squareMatrix.ManualInput(squareMatrix);

                                            Console.Clear();

                                            Console.WriteLine("Your matrix");
                                            squareMatrix.ShowMatrix(squareMatrix);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string operation = "";

                                            while(operation != "0")
                                            {
                                                Console.WriteLine("1.Track\n2.Determinant\n3.Inverse\nBack - 0\n\nEnter num");
                                                operation = Convert.ToString(Console.ReadLine());

                                                if (operation == "0") exit = "0";

                                                switch(operation)
                                                {
                                                    case "1":
                                                        squareMatrix.Track(squareMatrix);
                                                        break;

                                                    case "2":
                                                        Console.WriteLine(squareMatrix.Determinant(squareMatrix));
                                                        break;

                                                    case "3":
                                                        Console.WriteLine(squareMatrix.InverseMatrix(squareMatrix));
                                                        break;
                                                }
                                                Console.Clear();
                                            }

                                            Console.Clear();

                                            break;

                                        case "2":
                                            squareMatrix.Random(squareMatrix);

                                            Console.Clear();

                                            Console.WriteLine("Your matrix");
                                            squareMatrix.ShowMatrix(squareMatrix);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string operation1 = "";

                                            while (operation1 != "0")
                                            {
                                                Console.WriteLine("1.Track\n2.Determinant\n3.Inverse\nBack - 0\n\nEnter num");
                                                operation1 = Convert.ToString(Console.ReadLine());

                                                if (operation1 == "0") exit = "0";

                                                switch (operation1)
                                                {
                                                    case "1":
                                                        squareMatrix.Track(squareMatrix);
                                                        Console.ReadKey();
                                                        break;

                                                    case "2":
                                                        Console.WriteLine(squareMatrix.Determinant(squareMatrix));
                                                        Console.ReadKey();
                                                        break;

                                                    case "3":
                                                        SquareMatrix inverse = squareMatrix.InverseMatrix(squareMatrix);
                                                        inverse.ShowMatrix(inverse);
                                                        Console.ReadKey();
                                                        break;
                                                }
                                                Console.Clear();
                                            }

                                            Console.Clear();
                                            break;
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Enter rank 1 matrix");
                                    int rank1 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter rank 2 matrix");
                                    int rank2 = Convert.ToInt32(Console.ReadLine());

                                    SquareMatrix squareMatrix1 = new SquareMatrix(rank1);
                                    SquareMatrix squareMatrix2 = new SquareMatrix(rank2);

                                    Console.Clear();

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling1 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();

                                    switch(filling1)
                                    {
                                        case "1":
                                            squareMatrix1.ManualInput(squareMatrix1);
                                            Console.Clear();
                                            squareMatrix2.ManualInput(squareMatrix2);
                                            Console.Clear();

                                            Console.WriteLine("Your 1 matrix");
                                            squareMatrix1.ShowMatrix(squareMatrix1);
                                            Console.WriteLine("Your 2 matrix");
                                            squareMatrix2.ShowMatrix(squareMatrix2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet = "";

                                            while(repet != "0")
                                            {
                                                Console.WriteLine("What operation to perform?(+, -, *)");
                                                string operator1 = Convert.ToString(Console.ReadLine());

                                                Console.Clear();

                                                switch(operator1)
                                                {
                                                    case "+":
                                                        SquareMatrix squareMatrix3 = squareMatrix1 + squareMatrix2;
                                                        squareMatrix3.ShowMatrix(squareMatrix3);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        Console.Clear();

                                                        break;

                                                    case "-":
                                                        SquareMatrix squareMatrix4 = squareMatrix1 - squareMatrix2;
                                                        squareMatrix4.ShowMatrix(squareMatrix4);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        Console.Clear();

                                                        break;

                                                    case "*":
                                                        SquareMatrix squareMatrix5 = squareMatrix1 * squareMatrix2;
                                                        squareMatrix5.ShowMatrix(squareMatrix5);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        Console.Clear();

                                                        break;
                                                }
                                            }
                                            break;

                                        case "2":
                                            squareMatrix1.Random(squareMatrix1);
                                            squareMatrix2.Random(squareMatrix2);

                                            Console.WriteLine("Your 1 matrix");
                                            squareMatrix1.ShowMatrix(squareMatrix1);
                                            Console.WriteLine("Your 2 matrix");
                                            squareMatrix2.ShowMatrix(squareMatrix2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet1 = "";

                                            while (repet1 != "0")
                                            {
                                                Console.WriteLine("What operation to perform?(+, -, *)");
                                                string operator1 = Convert.ToString(Console.ReadLine());

                                                Console.Clear();

                                                switch (operator1)
                                                {
                                                    case "+":
                                                        SquareMatrix squareMatrix3 = squareMatrix1 + squareMatrix2;
                                                        squareMatrix3.ShowMatrix(squareMatrix3);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        Console.Clear();

                                                        break;

                                                    case "-":
                                                        SquareMatrix squareMatrix4 = squareMatrix1 - squareMatrix2;
                                                        squareMatrix4.ShowMatrix(squareMatrix4);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        Console.Clear();

                                                        break;

                                                    case "*":
                                                        SquareMatrix squareMatrix5 = squareMatrix1 * squareMatrix2;
                                                        squareMatrix5.ShowMatrix(squareMatrix5);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        if (repet1 == "0") exit = "0";

                                                        Console.Clear();

                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;

                    case "3":
                        while(exit != "0")
                        {
                            Console.WriteLine("1 or 2 vector");
                            string numOfVector = Convert.ToString(Console.ReadLine());
                            Console.Clear();

                            switch(numOfVector)
                            {
                                case "1":
                                    Vector vector = new Vector();

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling = Convert.ToString(Console.ReadLine());
                                    Console.Clear();

                                    switch(filling)
                                    {
                                        case "1":
                                            vector.ManualInput(vector);
                                            Console.Clear();

                                            Console.WriteLine("Your vector");
                                            vector.ShowMatrix(vector);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string operation = "";

                                            while(operation != "0")
                                            {
                                                Console.WriteLine("1.Module\nBack - 0\n\nEnter num");
                                                operation = Convert.ToString(Console.ReadLine());

                                                Console.Clear();

                                                if (operation == "0") exit = "0";

                                                switch(operation)
                                                {
                                                    case "1":
                                                        Console.WriteLine(vector.Module(vector));

                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                }
                                            }
                                            break;

                                        case "2":
                                            vector.Random(vector);

                                            Console.WriteLine("Your vector");
                                            vector.ShowMatrix(vector);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string operation1 = "";

                                            while (operation1 != "0")
                                            {
                                                Console.WriteLine("1.Module\nBack - 0\n\nEnter num");
                                                operation1 = Convert.ToString(Console.ReadLine());

                                                Console.Clear();

                                                if (operation1 == "0") exit = "0";

                                                switch (operation1)
                                                {
                                                    case "1":
                                                        Console.WriteLine(vector.Module(vector));

                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "2":
                                    Vector vector1 = new Vector();
                                    Vector vector2 = new Vector();

                                    Console.WriteLine("Manual(1) or random(2) filling");
                                    string filling1 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();

                                    switch(filling1)
                                    {
                                        case "1":
                                            vector1.ManualInput(vector1);
                                            Console.Clear();
                                            vector2.ManualInput(vector2);
                                            Console.Clear();

                                            Console.WriteLine("Your 1 vector");
                                            vector1.ShowMatrix(vector1);
                                            Console.WriteLine("Your 2 vector");
                                            vector1.ShowMatrix(vector2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet = "";

                                            while(repet != "0")
                                            {
                                                Console.WriteLine("1.+\n2.-\n3.*\n4.Scalar\n\nEnter num");
                                                string operation = Convert.ToString(Console.ReadLine());

                                                switch(operation)
                                                {
                                                    case "1":
                                                        Vector vector3 = vector1 + vector2;
                                                        vector3.ShowMatrix(vector3);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";

                                                        break;

                                                    case "2":
                                                        Vector vector4 = vector1 - vector2;
                                                        vector4.ShowMatrix(vector4);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";
                                                        break;

                                                    case "3":
                                                        Vector vector5 = vector1 * vector2;
                                                        vector5.ShowMatrix(vector5);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";
                                                        break;

                                                    case "4":
                                                        Console.WriteLine(vector1.Scalar(vector1, vector2));

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet = Convert.ToString(Console.ReadLine());

                                                        if (repet == "0") exit = "0";
                                                        break;
                                                }
                                            }
                                            break;

                                        case "2":
                                            vector1.Random(vector1);
                                            vector2.Random(vector2);

                                            Console.WriteLine("Your 1 vector");
                                            vector1.ShowMatrix(vector1);
                                            Console.WriteLine("Your 2 vector");
                                            vector1.ShowMatrix(vector2);

                                            Console.ReadKey();
                                            Console.Clear();

                                            string repet1 = "";

                                            while (repet1 != "0")
                                            {
                                                Console.WriteLine("1.+\n2.-\n3.*\n4.Scalar\n\nEnter num");
                                                string operation = Convert.ToString(Console.ReadLine());

                                                Console.Clear();

                                                switch (operation)
                                                {
                                                    case "1":
                                                        Vector vector3 = vector1 + vector2;
                                                        vector3.ShowMatrix(vector3);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        Console.Clear();

                                                        if (repet1 == "0") exit = "0";

                                                        break;

                                                    case "2":
                                                        Vector vector4 = vector1 - vector2;
                                                        vector4.ShowMatrix(vector4);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        Console.Clear();

                                                        if (repet1 == "0") exit = "0";

                                                        break;

                                                    case "3":
                                                        Vector vector5 = vector1 * vector2;
                                                        vector5.ShowMatrix(vector5);

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        Console.Clear();

                                                        if (repet1 == "0") exit = "0";

                                                        break;

                                                    case "4":
                                                        Console.WriteLine(vector1.Scalar(vector1, vector2));

                                                        Console.WriteLine("Back - any key, menu - 0");
                                                        repet1 = Convert.ToString(Console.ReadLine());

                                                        Console.Clear();

                                                        if (repet1 == "0") exit = "0";

                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
