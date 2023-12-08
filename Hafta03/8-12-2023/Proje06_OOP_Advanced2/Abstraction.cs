namespace Proje06_OOP_Advanced2
{
    internal class Abstraction
    {

    }

    #region FirstSample
    //public abstract class BaseClass
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public abstract bool IsActive { get; set; }
    //}
    //public class Product : BaseClass
    //{
    //    public double Price { get; set; }
    //    public string Color { get; set; }
    //    public override bool IsActive { get; set; } = true;
    //}
    //public class Category : BaseClass
    //{
    //    public int ParentCategoryID { get; set; }
    //    public override bool IsActive { get; set; } = false;
    //}
    #endregion



    public abstract class MyClass1
    {
        public int Price { get; set; }
        public abstract int Calculate();
    }
    public class A : MyClass1
    {
        public override int Calculate()
        {
            return Price * 2;
        }
    }
    public class B : MyClass1
    {
        public override int Calculate()
        {
            return Price * 3;
        }
    }

    public interface IBase
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public interface IBaseOther
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
    public class Product : IBase, IBaseOther
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
    public class Category : IBase, IBaseOther
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
    public class Order : IBase
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
    }


}
