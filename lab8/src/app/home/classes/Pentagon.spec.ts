import { Point } from './Point';
import { Pentagon } from './Pentagon';

describe('Pentagon', () => {
    it('should calculate area correctly', () => {
        const vertices = [
            new Point(0, 0),
            new Point(1, 0),
            new Point(1.5, Math.sqrt(3) / 2),
            new Point(0.5, Math.sqrt(3)),
            new Point(-0.5, Math.sqrt(3) / 2)
        ];
        const pentagon = new Pentagon(vertices);
        expect(pentagon.area()).toBeCloseTo(1.720, 3);
    });

    it('should calculate perimeter correctly', () => {
        const vertices = [
            new Point(0, 0),
            new Point(1, 0),
            new Point(1.5, Math.sqrt(3) / 2),
            new Point(0.5, Math.sqrt(3)),
            new Point(-0.5, Math.sqrt(3) / 2)
        ];
        const pentagon = new Pentagon(vertices);
        expect(pentagon.perimeter()).toBeCloseTo(5, 1);
    });

    it('should move correctly', () => {
        const vertices = [
            new Point(0, 0), new Point(1, 0.5),
            new Point(0.75, 1.5), new Point(0.25, 1.75),
            new Point(0, 1.25)
        ];
        const pentagon = new Pentagon(vertices);
        pentagon.move(1, 1);
        const movedVertices = pentagon.getVertices();
        expect(movedVertices[0].x).toBe(1);
        expect(movedVertices[0].y).toBe(1);
    });

    it('should rotate correctly', () => {
        const vertices = [
            new Point(0, 0), new Point(1, 0.5),
            new Point(0.75, 1.5), new Point(0.25, 1.75),
            new Point(0, 1.25)
        ];
        const pentagon = new Pentagon(vertices);
        pentagon.rotate(90);
        const rotatedVertices = pentagon.getVertices();
        expect(rotatedVertices[0].x).toBeCloseTo(0);
        expect(rotatedVertices[0].y).toBeCloseTo(0);
    });

    it('should resize correctly', () => {
        const vertices = [
            new Point(0, 0), new Point(1, 0.5),
            new Point(0.75, 1.5), new Point(0.25, 1.75),
            new Point(0, 1.25)
        ];
        const pentagon = new Pentagon(vertices);
        pentagon.resize(0.5);
        const resizedVertices = pentagon.getVertices();
        expect(resizedVertices[1].x).toBeCloseTo(0.5);
        expect(resizedVertices[1].y).toBeCloseTo(0.25);
    });
});
