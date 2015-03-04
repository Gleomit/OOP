package Geometry.Shapes.PlaneShapes;

import Geometry.Shapes.PlaneShape;
import Geometry.Vertices.Vertex2D;

public class Circle extends PlaneShape {
    private double radius;

    public Circle(Vertex2D centerPoint, double radius) throws Exception {
        this.setRadius(radius);
        this.vertices.add(centerPoint);
    }

    public void setRadius(double radius) throws Exception {
        if(radius < 0){
            throw new Exception("Radius cannot be negative number");
        }
        this.radius = radius;
    }

    public double getRadius(){
        return this.radius;
    }

    @Override
    public double getArea() {
        return Math.PI * Math.pow(this.getRadius(), 2);
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * this.getRadius();
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Circle")
                .append("\nRadius: " + this.getRadius())
                .toString();
    }
}
