import { Point } from "./Point";
import { Polygon } from "./Polygon";

export class Rectangle extends Polygon {
    constructor(bottomLeft: Point, width: number, height: number) {
        super([
            bottomLeft,
            new Point(bottomLeft.x + width, bottomLeft.y),
            new Point(bottomLeft.x + width, bottomLeft.y + height),
            new Point(bottomLeft.x, bottomLeft.y + height)
        ]);
    }

    area(): number {
        const width = this.vertices[1].x - this.vertices[0].x;
        const height = this.vertices[2].y - this.vertices[1].y;
        return width * height;
    }

    perimeter(): number {
        const width = this.vertices[1].x - this.vertices[0].x;
        const height = this.vertices[2].y - this.vertices[1].y;
        return 2 * (width + height);
    }
}
