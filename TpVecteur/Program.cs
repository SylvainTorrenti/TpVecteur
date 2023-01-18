using TpVecteur;

#region Vector 2D
Vector2D Vector2D1 = new Vector2D(1, 2);
Vector2D Vector2D2 = new Vector2D(1, 2);
Console.WriteLine("             ****Vecteur 2D****");
Console.WriteLine();
Console.WriteLine($"Le vector 1 est : {Vector2D1.ToString()}");
Console.WriteLine($"La norme est : {Vector2D1.Norme()}");
Console.WriteLine("-----------");
Console.WriteLine($"Le vector 2 est : {Vector2D2.ToString()}");
Console.WriteLine($"La norme est : {Vector2D2.Norme()}");
Console.WriteLine("-----------");
Vector2D1.Equals2D(Vector2D2, Vector2D1);
Console.WriteLine("-----------");
Console.WriteLine();
#endregion
Console.WriteLine("             ****Vecteur 3D****");
Console.WriteLine();
Vector3D Vector3D1 = new Vector3D(1, 1, 1);
Vector3D Vector3D2 = new Vector3D(1, 2, 1);
Console.WriteLine($"Le vector 1 est : {Vector3D1.ToString()}");
Console.WriteLine($"La norme est : {Vector3D1.Norme()}");
Console.WriteLine("-----------");
Console.WriteLine($"Le vector 2 est : {Vector3D2.ToString()}");
Console.WriteLine($"La norme est : {Vector3D2.Norme()}");
Console.WriteLine("-----------");
Vector2D1.Equals2D(Vector3D2, Vector3D1);
Console.WriteLine("-----------");

