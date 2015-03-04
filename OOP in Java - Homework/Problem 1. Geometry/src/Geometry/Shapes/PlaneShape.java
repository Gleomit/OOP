package Geometry.Shapes;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.PerimeterMeasurable;
import Geometry.Shape;
import Geometry.Vertices.Vertex2D;
import com.sun.deploy.util.StringUtils;

import java.util.LinkedList;

public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable{
    protected LinkedList<Vertex2D> vertices;

    public PlaneShape(){
        this.vertices = new LinkedList<Vertex2D>();
    }

    public abstract double getArea();
    public abstract double getPerimeter();

    @Override
    public String toString(){
        return (new StringBuilder())
                .append("\nType - Planet shape")
                .append("\nPerimeter: " + this.getPerimeter())
                .append("\nArea: " + this.getArea())
                .append("\nVertices: " + this.vertices)
                .toString();
    }
}
