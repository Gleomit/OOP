package Geometry.Vertices;

public class Vertex2D {
    private int x;
    private int y;

    public Vertex2D(int x, int y){
        this.setX(x);
        this.setY(y);
    }

    public Vertex2D(int value){
        this(value, value);
    }

    public int getX(){
        return this.x;
    }

    public void setX(int x){
        this.x = x;
    }

    public int getY(){
        return this.y;
    }

    public void setY(int y){
        this.y = y;
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append("(" + this.getX() + ", " + this.getY() + ")")
                .toString();
    }
}
