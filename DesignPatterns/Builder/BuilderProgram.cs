using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public interface A
    {
        void M();
        void O();
    }

    public interface A1 : A
    {
        void NN();
    }

    public class ASD : A1
    {
        public void M()
        {
            throw new NotImplementedException();
        }

        public void NN()
        {
            throw new NotImplementedException();
        }

        public void O()
        {
            throw new NotImplementedException();
        }
    }

    public interface B
    {
        void M();
        void N();
    }
    public class C : A, B
    {
        public void M()
        {
            throw new NotImplementedException();
        }

        public void N()
        {
            throw new NotImplementedException();
        }

        public void O()
        {
            throw new NotImplementedException();
        }
    }

    class BuilderProgram
    {
        public static void MainMethod(string[] args)
        {
            builder<Car> carBuilder = new CarBuilder(new CarBuilderArgs());

            carBuilder.Build();

            var car = carBuilder.GetProduct();

            builder<Table> tableBuilder = new TableBuilder();

            tableBuilder.Build();

            var table = tableBuilder.GetProduct();

            //List<builder<object>> builders = new List<builder<object>>() { (builder<object>)b, (builder<object>)t };

        }
    }
}
