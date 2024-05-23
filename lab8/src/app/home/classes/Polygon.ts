import { Point } from './Point';

abstract class Polygon {
    protected vertices: Point[];

    constructor(vertices: Point[]) {
        this.vertices = vertices;
    }

    abstract area(): number;
    abstract perimeter(): number;

    move(dx: number, dy: number): void {
        this.vertices.forEach(vertex => vertex.move(dx, dy));
    }

    rotate(angle: number, origin: Point = new Point(0, 0)): void {
        this.vertices.forEach(vertex => vertex.rotate(angle, origin));
    }

    resize(factor: number, origin: Point = new Point(0, 0)): void {
        this.vertices.forEach(vertex => vertex.scale(factor, origin));
    }

    getVertices(): Point[] {
        return this.vertices;
    }
}

export { Polygon };
