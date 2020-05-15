using Builder;
using Factory;
using NUnit.Framework;
using Prototype;
using System;
using Facade;
using Adaptaer;
using Decorator;
using Composite;
using Strategy;

namespace Dominio.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Factory()
        {
            Animal animal = Fabrica.Factory(Fabrica.ANIMAL.PERRO);
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => animal.HacerRuido());

            Assert.Pass(ex.Message, "Guaaauu Guaauuu");
        }

        [Test]
        public void singleton()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => Singleton.Singleton.GetSingleton());

            Assert.Pass(ex.Message, "El objeto ha sido creado");

        }
        [Test]
        public void singleton2()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => Singleton.Singleton.GetSingleton());
            InvalidOperationException e = Assert.Throws<InvalidOperationException>(() => Singleton.Singleton.GetSingleton());

            Assert.Pass(e.Message, "Ya existe el objeto");

        }

        [Test]
        public void Builder()
        {
            Inmobiliaria inmobiliaria = new Inmobiliaria();
            ConstruirCasa construir;
           

            construir = new Construir2piso();
            inmobiliaria.establecerConstructor(construir);
            
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => inmobiliaria.construirCasa());

            Casa producto = inmobiliaria.obtenerCasa();


            Assert.Pass(ex.Message, "Casa Construida");
        }

        [Test]
        public void Prototype()
        {

            Documento documento = new Documento { Pagina = 2, Texto = "Hola Mundo" };
            Documento Documentoclone = documento.Clone() as Documento;
            Documentoclone.Texto = "Hola Amigo";
            Assert.Pass("Hola Mundo", documento.Texto);
            Assert.Pass("Hola Amigo", Documentoclone.Texto);
        }

        [Test]
        public void Adapter()
        {
            int resultado = 0;
            
            Itarget calcu = new Ccalcu();
            
            resultado = calcu.Multiplicar(4, 4);
            Assert.AreEqual(resultado, 16);
        }

        [Test]
        public void Facade()
        {
           Facade.Facade fachada1 = new Facade.Facade("Texto3");
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => fachada1.imprimir());

            Assert.Pass(ex.Message, "Imprimiendo:Texto3,color:True,tipo:PDF,hoja :A4");
        }

        [Test]
        public void Decorator()
        {
            Computador gammerPC = new ComputadorBase();

            gammerPC = new FastSSD(gammerPC);
            gammerPC = new ProcesadorGrande(gammerPC);

            var cost = gammerPC.CalcularCosto();
            Assert.AreEqual(cost,375.20);

        }
        [Test]
        public void Composite()
        {
            Ingrediente Ingrediente1 = new Ingrediente("carne", 200, 20, "kilos");
            Ingrediente Ingrediente2 = new Ingrediente("tortillas bimbo", 20, 2, "");

            TacosComposite Tacos = new TacosComposite("Tacos De Carne");
            Tacos.Add(Ingrediente1);
            Tacos.Add(Ingrediente2);
            Assert.AreEqual(Tacos.CostoTotal,220);
        }

        [Test]
        public void Strategy()
        {
            ContextoEstrategiaDelBorracho borracho = new ContextoEstrategiaDelBorracho();
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => borracho.conquistar(ContextoEstrategiaDelBorracho.Comportamiento.HacerOjitos));

            Assert.Pass(ex.Message , "Le Hago Ojitos A La Muchacha");
        }

    }
}