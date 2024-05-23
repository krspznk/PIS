import { Point } from "./Point";
import { Polygon } from "./Polygon";

export class Pentagon extends Polygon {
    constructor(vertices: Point[]) {
        if (vertices.length !== 5) {
            throw new Error('Pentagon must have 5 vertices');
        }
        super(vertices);
    }

    area(): number {
        const a = this.sideLength();
        return (5 * a * a) / (4 * Math.tan(Math.PI / 5));
    }

    perimeter(): number {
        return this.sideLength() * 5;
    }

    private sideLength(): number {
        return Math.sqrt(Math.pow(this.vertices[0].x - this.vertices[1].x, 2) +
                         Math.pow(this.vertices[0].y - this.vertices[1].y, 2));
    }
}
