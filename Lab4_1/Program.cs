
using Lab4_1;

MyMatrix mat1 = new MyMatrix(5, 7, 0, 10);
MyMatrix mat2 = new MyMatrix(5, 7, 0, 10);

MyMatrix mat3 = new MyMatrix(2, 3, 0, 6);
MyMatrix mat4 = new MyMatrix(3, 4, 0, 6);

Console.WriteLine(mat2[1, 1]);

mat3.writting_matrix();

Console.WriteLine();

mat4.writting_matrix();

MyMatrix sum_mat = mat1 + mat2;
MyMatrix dif_mat = mat1 - mat2;

Console.WriteLine();

/*dif_mat.writting_matrix();*/

MyMatrix new_matrix = mat3 * mat4;

new_matrix.writting_matrix();





