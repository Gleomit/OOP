package Geometry.Vertices;

public class Vertex3D {
    private int x;
    private int y;
    private int z;

    public Vertex3D(int x, int y, int z){
        this.setX(x);
        this.setY(y);
        this.setZ(z);
    }

    public Vertex3D(int value){
        this(value, value, value);
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

    public int getZ(){
        return this.z;
    }

    public void setZ(int z){
        this.z = z;
    }

    @Override
    public String toString(){
        return (new StringBuilder())
                .append("(" + this.getX() + ", " + this.getY() + ", " + this.getZ() + ")")
                .toString();
    }
}
