using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Beverage
{
    public enum Size{
        Tall,
        Grande,
        Venti
    }

    protected Size size;

    public void SetSize(Size size){
        this.size = size;
    }

    public virtual Size GetSize(){
        return this.size;
    }

    protected string description = "unknown";    
   public virtual string GetDescription(){
       return description;
   }

   protected double cost = 0;

   public virtual double GetCost(){
       return cost;
   }
}


public abstract class CondimentDecorator : Beverage{
    protected Beverage beverage = null;

    public override string GetDescription(){
        return this.beverage.GetDescription() + " " + this.description;
    }

    public override double GetCost(){
        return this.beverage.GetCost() + this.cost;
    }

    public override Size GetSize(){
        return this.beverage.GetSize();
    }
    
}

public class Espresso : Beverage{
    public Espresso(){
        description = "Espresso";
        cost = 1.99;
    }
}

public class HouseBlend : Beverage{
    public HouseBlend(){
        description = "HouseBlend";
        cost = 0.89;
    }
}
public class DarkRoast : Beverage{
    public DarkRoast(){
        description = "DarkRoast";
        cost = 0.99;
    }
}

public class Decaf : Beverage{
    public Decaf(){
        description = "Decaf";
        cost = 1.05;
    }
}

public class Mocha : CondimentDecorator{
    public Mocha(Beverage beverage){
        this.description = "mocha";
        this.beverage = beverage;
        this.cost = 0.20;
    }
}
public class Soy : CondimentDecorator{
    public Soy(Beverage beverage){
        this.description = "Soy";
        this.beverage = beverage;
        // this.cost = 0.15;
    }

    public override double GetCost(){
        double cost = this.beverage.GetCost();

        Size sz = this.beverage.GetSize();
        switch(sz){
            case Size.Tall:
                cost += 0.1;
            break;

            case Size.Grande:
                cost += 0.15;
            break;

            case Size.Venti:
                cost +=0.2;
            break;
        }
        return cost;
    }
}
public class Whip : CondimentDecorator{
    public Whip(Beverage beverage){
        this.description = "Whip";
        this.beverage = beverage;
        this.cost = 0.10;
    }
}