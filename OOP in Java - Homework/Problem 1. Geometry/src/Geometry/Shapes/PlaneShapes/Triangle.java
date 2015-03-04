package Geometry.Shapes.PlaneShapes;

import Geometry.MathUtils.VertexDistanceCalculator;
import Geometry.Shapes.PlaneShape;
import Geometry.Vertices.Vertex2D;

public class Triangle extends PlaneShape {

    public Triangle(Vertex2D a, Vertex2D b, Vertex2D c) throws Exception {
        this.vertices.add(a);
        this.vertices.add(b);
        this.vertices.add(c);

        if(!(this.getA() + this.getB() > this.getC()
                && this.getA() + this.getC() > this.getB()
                && this.getB() + this.getC() > this.getA()))
        {
            throw new Exception("This is not valid triangle");
        }
    }

    @Override
    public double getArea() {
        double halfPerimeter = this.getPerimeter() / 2;
        return Math.sqrt(halfPerimeter * (halfPerimeter - this.getA()) * (halfPerimeter - this.getB()) * (halfPerimeter - this.getC()));
    }

    private double getA(){
        return VertexDistanceCalculator.Calc2DDistance(this.vertices.get(1), this.vertices.get(2));
    }

    private double getB(){
        return VertexDistanceCalculator.Calc2DDistance(this.vertices.get(0), this.vertices.get(2));
    }

    private double getC(){
        return VertexDistanceCalculator.Calc2DDistance(this.vertices.get(0), this.vertices.get(1));
    }

    @Override
    public double getPerimeter() {
        return this.getA() + this.getB() + this.getC();
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Triangle")
                .toString();
    }
}
