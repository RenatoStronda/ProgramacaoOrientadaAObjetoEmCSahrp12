// See https://aka.ms/new-console-template for more information
using System;

namespace heranca{
    class Program{
    static void Main(string[] args){
    Sedan virtus = new Sedan(100000, "Multimidia, porta malas 510 lts, rodas de liga leve 17pol");
    virtus.GetValor();
    virtus.GetDesc();
    Console.ReadLine();
  }
}

public abstract class Carro
{
  private float valor;
  private string descricao;

  public Carro(float valor, string descricao)
  {
    this.valor = valor;
    this.descricao = descricao;
  }

  public virtual void GetValor()
  {
    Console.WriteLine($"Valor: {valor}");
  }
  
  public virtual void GetDesc()
  {
    Console.WriteLine($"Descrição: {descricao}");
  }
}

public class Sedan : Carro
{
  public Sedan(float v, string d) : base(v, d)
  {

  }
  public override void GetValor()
  {
    base.GetValor();
  }
  
  public override void GetDesc()
  {
    base.GetDesc();
  }

}

public class Suv : Carro
{
  public Suv(float v, string d) : base(v, d)
  {

  }
}

public class Motor
{
  private Carro c;
  private bool turbo;
  private int potencia;

  public Motor(Carro c, bool turbo, int potencia)
  {
    this.c = c;
    this.turbo = turbo;
    this.potencia = potencia;
  }
}
}