package Geometry;

import Geometry.Interfaces.VolumeMeasurable;
import Geometry.Shapes.PlaneShape;
import Geometry.Shapes.PlaneShapes.Circle;
import Geometry.Shapes.PlaneShapes.Rectangle;
import Geometry.Shapes.PlaneShapes.Triangle;
import Geometry.Shapes.SpaceShapes.Cuboid;
import Geometry.Shapes.SpaceShapes.Sphere;
import Geometry.Shapes.SpaceShapes.SquarePyramid;
import Geometry.Vertices.Vertex2D;
import Geometry.Vertices.Vertex3D;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) throws Exception {
        ArrayList<Shape> shapes = new ArrayList<Shape>();
        shapes.add(new Circle(new Vertex2D(0, 2), 5));
        shapes.add(new Rectangle(new Vertex2D(0, 0), 2, 4));
        shapes.add(new Triangle(new Vertex2D(0, 1), new Vertex2D(2 , 1), new Vertex2D(1, 3)));
        shapes.add(new Cuboid(new Vertex3D(0, 0, 0), 2, 2, 3));
        shapes.add(new Sphere(new Vertex3D(0, 0, 0), 40));
        shapes.add(new SquarePyramid(new Vertex3D(0, 0, 0), 5, 3));

        System.out.println("All shapes: \n");
        shapes.forEach(shape -> System.out.println(shape.toString()));

        //VolumeMeasurables with volume > 40
        System.out.println("\n\n\nVolume measurables with volume > 40: \n");
        shapes.stream()
                .filter(shape -> shape instanceof VolumeMeasurable)
                .filter(shape -> ((VolumeMeasurable)shape).getVolume() > 40)
                .forEach(shape -> System.out.println(shape.toString()));

        //Planet shapes sorted by perimeter
        System.out.println("\n\n\nPlanet shapes sorted by perimeter: \n");
        shapes.stream()
                .filter(shape -> shape instanceof PlaneShape)
                .sorted((shapeOne, shapeTwo) ->
                        Double.compare(((PlaneShape) shapeOne).getPerimeter(), ((PlaneShape) shapeTwo).getPerimeter()))
            .forEach(shape -> System.out.println(shape.toString()));
    }
}
