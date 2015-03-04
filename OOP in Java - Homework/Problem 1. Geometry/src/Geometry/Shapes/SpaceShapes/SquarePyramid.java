package Geometry.Shapes.SpaceShapes;

import Geometry.Shapes.SpaceShape;
import Geometry.Vertices.Vertex3D;

public class SquarePyramid extends SpaceShape {
    private double baseWidth;
    private double pyramidHeight;

    public SquarePyramid(Vertex3D baseCenter, double baseWidth, double pyramidHeight){
        this.vertices.add(baseCenter);
        this.setBaseWidth(baseWidth);
        this.setPyramidHeight(pyramidHeight);
    }

    @Override
    public double getArea() {
        return Math.pow(this.getBaseWidth(), 2) + this.getBaseWidth()
                * Math.sqrt(Math.pow(this.getBaseWidth(), 2) + Math.pow(2 * this.getPyramidHeight(), 2));
    }

    @Override
    public double getVolume() {
        return 1 / 3 * Math.pow(this.getBaseWidth(), 2) * this.getPyramidHeight();
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Square pyramid")
                .append("\nBase Width: " + this.getBaseWidth())
                .append("\nPyramid Height: " + this.getPyramidHeight())
                .toString();
    }

    public double getBaseWidth() {
        return baseWidth;
    }

    public void setBaseWidth(double baseWidth) {
        this.baseWidth = baseWidth;
    }

    public double getPyramidHeight() {
        return pyramidHeight;
    }

    public void setPyramidHeight(double pyramidHeight) {
        this.pyramidHeight = pyramidHeight;
    }
}
