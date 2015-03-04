package Geometry.Shapes.SpaceShapes;

import Geometry.Shapes.SpaceShape;
import Geometry.Vertices.Vertex3D;

public class Cuboid extends SpaceShape {
    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertex3D topLeftForward, double width, double height, double depth){
        this.vertices.add(topLeftForward);
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
    }
    @Override
    public double getArea() {
        return 2 * (this.getWidth() + this.getHeight() + this.getDepth());
    }

    @Override
    public double getVolume() {
        return this.getWidth() * this.getHeight() * this.getDepth();
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Cuboid")
                .append("\nWidth: " + this.getWidth())
                .append("\nHeight: " + this.getHeight())
                .append("\nDepth: " + this.getDepth())
                .toString();
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        this.depth = depth;
    }
}
