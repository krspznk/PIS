import { Point } from './Point';
import { Polygon } from './Polygon';

class TestPolygon extends Polygon {
    area(): number {
        return 0;
    }

    perimeter(): number {
        return 0;
    }
}

describe('Polygon', () => {
    it('should move all vertices correctly', () => {
        const vertices = [new Point(1, 1), new Point(2, 2)];
        const polygon = new TestPolygon(vertices);
        polygon.move(1, 1);
        const movedVertices = polygon.getVertices();
        expect(movedVertices[0].x).toBe(2);
        expect(movedVertices[0].y).toBe(2);
        expect(movedVertices[1].x).toBe(3);
        expect(movedVertices[1].y).toBe(3);
    });

    it('should rotate all vertices correctly', () => {
        const vertices = [new Point(1, 0), new Point(0, 1)];
        const polygon = new TestPolygon(vertices);
        polygon.rotate(90);
        const rotatedVertices = polygon.getVertices();
        expect(rotatedVertices[0].x).toBeCloseTo(0);
        expect(rotatedVertices[0].y).toBeCloseTo(1);
        expect(rotatedVertices[1].x).toBeCloseTo(-1);
        expect(rotatedVertices[1].y).toBeCloseTo(0);
    });

    it('should resize all vertices correctly', () => {
        const vertices = [new Point(2, 2), new Point(4, 4)];
        const polygon = new TestPolygon(vertices);
        polygon.resize(0.5);
        const resizedVertices = polygon.getVertices();
        expect(resizedVertices[0].x).toBe(1);
        expect(resizedVertices[0].y).toBe(1);
        expect(resizedVertices[1].x).toBe(2);
        expect(resizedVertices[1].y).toBe(2);
    });
});
