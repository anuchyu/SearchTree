using SearchTree;

var tree = new Tree<int>();

tree.Add(5);
tree.Add(4);
tree.Add(9);
tree.Add(3);
tree.Add(8);
tree.Add(15);
tree.Add(1);
tree.Add(6);
tree.Add(10);
tree.Add(7);

Console.Write("CLR: верно. ");
foreach (var item in tree.CLR())
{
    Console.Write( item + ", ");
}

Console.Write("\nRCL: неверно..");
foreach (var item in tree.RCL())
{
    Console.Write(item + ", ");
}

Console.ReadLine();

