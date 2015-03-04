package Geometry.Shapes;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.VolumeMeasurable;
import Geometry.Shape;
import Geometry.Vertices.Vertex3D;

import java.util.LinkedList;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {
    protected LinkedList<Vertex3D> vertices;

    public SpaceShape(){
        this.vertices = new LinkedList<Vertex3D>();
    }

    public abstract double getArea();
    public abstract double getVolume();

    @Override
    public String toString(){
        return (new StringBuilder())
                .append("\nType - Space shape")
                .append("\nVolume: " + this.getVolume())
                .append("\nArea: " + this.getArea())
                .append("\nVertices: " + this.vertices)
                .toString();
    }
}
