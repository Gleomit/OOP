package Geometry.MathUtils;

import Geometry.Vertices.Vertex2D;

public class VertexDistanceCalculator {
    public static double Calc2DDistance(Vertex2D first, Vertex2D second){
        return Math.sqrt(Math.pow(first.getX() - second.getX(), 2) + Math.pow(first.getY() - second.getY(), 2));
    }
}
