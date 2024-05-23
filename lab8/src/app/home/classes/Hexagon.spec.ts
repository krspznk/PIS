import { Point } from './Point';
import { Hexagon } from './Hexagon';

describe('Hexagon', () => {
    it('should calculate area correctly', () => {
        const vertices = [
            new Point(1, 0), new Point(0.5, Math.sqrt(3) / 2),
            new Point(-0.5, Math.sqrt(3) / 2), new Point(-1, 0),
            new Point(-0.5, -Math.sqrt(3) / 2), new Point(0.5, -Math.sqrt(3) / 2)
        ];
        const hexagon = new Hexagon(vertices);
        expect(hexagon.area()).toBeCloseTo((3 * Math.sqrt(3) / 2), 5);
    });

    it('should calculate perimeter correctly', () => {
        const vertices = [
            new Point(1, 0), new Point(0.5, Math.sqrt(3) / 2),
            new Point(-0.5, Math.sqrt(3) / 2), new Point(-1, 0),
            new Point(-0.5, -Math.sqrt(3) / 2), new Point(0.5, -Math.sqrt(3) / 2)
        ];
        const hexagon = new Hexagon(vertices);
        expect(hexagon.perimeter()).toBeCloseTo(6);
    });

    it('should move correctly', () => {
        const vertices = [
            new Point(1, 0), new Point(0.5, Math.sqrt(3) / 2),
            new Point(-0.5, Math.sqrt(3) / 2), new Point(-1, 0),
            new Point(-0.5, -Math.sqrt(3) / 2), new Point(0.5, -Math.sqrt(3) / 2)
        ];
        const hexagon = new Hexagon(vertices);
        hexagon.move(1, 1);
        const movedVertices = hexagon.getVertices();
        expect(movedVertices[0].x).toBe(2);
        expect(movedVertices[0].y).toBe(1);
    });

    it('should rotate correctly', () => {
        const vertices = [
            new Point(1, 0), new Point(0.5, Math.sqrt(3) / 2),
            new Point(-0.5, Math.sqrt(3) / 2), new Point(-1, 0),
            new Point(-0.5, -Math.sqrt(3) / 2), new Point(0.5, -Math.sqrt(3) / 2)
        ];
        const hexagon = new Hexagon(vertices);
        hexagon.rotate(90);
        const rotatedVertices = hexagon.getVertices();
        expect(rotatedVertices[0].x).toBeCloseTo(0);
        expect(rotatedVertices[0].y).toBeCloseTo(1);
    });

    it('should resize correctly', () => {
        const vertices = [
            new Point(1, 0), new Point(0.5, Math.sqrt(3) / 2),
            new Point(-0.5, Math.sqrt(3) / 2), new Point(-1, 0),
            new Point(-0.5, -Math.sqrt(3) / 2), new Point(0.5, -Math.sqrt(3) / 2)
        ];
        const hexagon = new Hexagon(vertices);
        hexagon.resize(0.5);
        const resizedVertices = hexagon.getVertices();
        expect(resizedVertices[0].x).toBeCloseTo(0.5);
        expect(resizedVertices[0].y).toBeCloseTo(0);
    });
});
