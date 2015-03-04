package Geometry.Shapes.SpaceShapes;

import Geometry.Shapes.SpaceShape;
import Geometry.Vertices.Vertex3D;

public class Sphere extends SpaceShape {
    private double radius;

    public Sphere(Vertex3D centerPoint, double radius) throws Exception {
        this.vertices.add(centerPoint);
        this.setRadius(radius);
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * Math.pow(this.getRadius(), 2);
    }

    @Override
    public double getVolume() {
        return 4 / 3 * Math.PI * Math.pow(this.getRadius(), 3);
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Sphere")
                .append("\nRadius: " + this.getRadius())
                .toString();
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) throws Exception {
        if(radius < 0) {
            throw new Exception("Radius cannot be negative number.");
        }
        this.radius = radius;
    }
}
