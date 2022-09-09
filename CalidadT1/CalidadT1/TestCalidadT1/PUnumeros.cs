using CalidadT1;

namespace TestCalidadT1;
public class PUnumeros
{

    [Test]
    public void PruebaValidacion_1()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(750);
        Assert.AreEqual("DCCL", validar);
    }
    [Test]
    public void PruebaValidacion_2()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(58);
        Assert.AreEqual("LVIII", validar);
    }
    [Test]
    public void PruebaValidacion_3()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(452);
        Assert.AreEqual("CCCCLII", validar);
    }
    [Test]
    public void PruebaValidacion_4()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(674);
        Assert.AreEqual("DCCL", validar);
        
    }
    [Test]
    public void PruebaValidacion_5()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(346);
        Assert.AreEqual("CCCXXXXVI", validar);
        
    }
    [Test]
    public void PruebaValidacion_6()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(731);
        Assert.AreEqual("DCCXXXI", validar);
        
    }
    [Test]
    public void PruebaValidacion_7()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(750);
        Assert.AreEqual("DCCL", validar);
    }
    [Test]
    public void PruebaValidacion_8()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(423);
        Assert.AreEqual("CCCCXXIII", validar);
    }
    [Test]
    public void PruebaValidacion_9()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(750);
        Assert.AreEqual("DCCL", validar);
        
    }
    [Test]
    public void PruebaValidacion_10()
    {
        //XCV
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(95);
        Assert.AreEqual("LXXXXV", validar);
    }
   
    [Test]
    public void PruebaValidacion_11()
    {
        //validar que stá mal
        //CCXXXIV
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(234);
        Assert.AreEqual("CCXXXIIII", validar);
        
    }
    [Test]
    public void PruebaValidacion_12()
    {
        //VALIDAR
        //DCXXXXI
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(641);
        Assert.AreEqual("DCXLI", validar);
        }
    [Test]
    public void PruebaValidacion_13()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(4000);
        Assert.AreEqual("numero mayor a mil", validar);
    }
    [Test]
    public void PruebaValidacion_14()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(-423);
        Assert.AreEqual("error", validar);
    }
    [Test]
    public void PruebaValidacion_15()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(1000);
        Assert.AreEqual("numero mayor a mil", validar);
    }
    [Test]
    public void PruebaValidacion_16()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(-5232432);
        Assert.AreEqual("error", validar);
    }
    [Test]
    public void PruebaValidacion_17()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(42334);
        Assert.AreEqual("numero mayor a mil", validar);
    }

    [Test]
    public void PruebaValidacion_18()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(-4);
        Assert.AreEqual("error", validar);
    }

    [Test]
    public void PruebaValidacion_19()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(1);
        Assert.AreEqual("I", validar);
    }
    [Test]
    public void PruebaValidacion_20()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(2);
        Assert.AreEqual("II", validar);
    }
    [Test]
    public void PruebaValidacion_21()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(3);
        Assert.AreEqual("III", validar);
    }
    [Test]
    public void PruebaValidacion_22()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(4);
        Assert.AreEqual("IV", validar);
    }
    [Test]
    public void PruebaValidacion_23()
    {
        var numerosRomanos = new RomanoGenerator();
        var validar = numerosRomanos.GetRomano(10);
        Assert.AreEqual("X", validar);
    }
}