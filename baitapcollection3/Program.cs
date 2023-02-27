using baitapcollection3;
//Bai lam cua Pham Duc Minh
List<Student> students = new List<Student>();
Console.Write("Nhap so sinh vien: ");
int n = int.Parse(Console.ReadLine());
for(int i = 0;i < n; i++)
{
    Console.WriteLine($"=== Nhap du lieu sinh vien {i+1} ===");
    Student student = new Student();
    Console.Write("Nhap ID sinh vien: ");
    student.ID = int.Parse(Console.ReadLine());
    Console.Write("Nhap ten sinh vien: ");
    student.Name = Console.ReadLine();
    Console.Write("Nhap tuoi sinh vien: ");
    student.Age = int.Parse(Console.ReadLine());
    students.Add(student);
}
Console.WriteLine("-------------SAP XEP------------");
Console.WriteLine("Sap xep theo ID:");
students.Sort();
foreach(Student student in students) student.Show();