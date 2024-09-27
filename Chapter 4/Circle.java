public class Circle {

    static double radius;
    static double diameter;
    static double area;
    
    public Circle(double radius) {
        setRadius(radius);
    }

    public static void setRadius(double rad) {
        radius = rad;
        diameter = 2 * radius;
        area = 3.1415926535897932 * (radius * radius);
    }

    public static double getRadius() {
        return radius;
    }

    public static double getDiameter() {
        return diameter;
    }

    public static double getArea() {
        return area;
    }
}
