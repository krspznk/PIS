import { Point } from "./Point";
import { Polygon } from "./Polygon";

export class Hexagon extends Polygon {
    constructor(vertices: Point[]) {
        if (vertices.length !== 6) {
            throw new Error('Hexagon must have 6 vertices');
        }
        super(vertices);
    }

    area(): number {
        const a = this.sideLength();
        return (3 * Math.sqrt(3) * a * a) / 2;
    }

    perimeter(): number {
        return this.sideLength() * 6;
    }

    private sideLength(): number {
        return Math.sqrt(Math.pow(this.vertices[0].x - this.vertices[1].x, 2) +
                         Math.pow(this.vertices[0].y - this.vertices[1].y, 2));
    }
}
