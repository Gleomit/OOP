package Geometry.Shapes.PlaneShapes;

import Geometry.Shapes.PlaneShape;
import Geometry.Vertices.Vertex2D;

public class Rectangle extends PlaneShape{
    private double width;
    private double height;

    public Rectangle(Vertex2D topLeft, double width, double height){
        this.vertices.add(topLeft);
        this.setWidth(width);
        this.setHeight(height);
    }

    public void setWidth(double width){
        this.width = width;
    }

    public double getWidth(){
        return this.width;
    }

    public void setHeight(double height){
        this.height = height;
    }

    public double getHeight(){
        return this.height;
    }

    @Override
    public double getArea() {
        return this.getWidth() * this.getHeight();
    }

    @Override
    public double getPerimeter() {
        return 2 * (this.getWidth() + this.getHeight());
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Rectangle")
                .append("\nWidth: " + this.getWidth())
                .append("\nHeight: " + this.getHeight())
                .toString();
    }
}
