import { Point } from './Point';
import { Rectangle } from './Rectangle';

describe('Rectangle', () => {
    it('should calculate area correctly', () => {
        const rectangle = new Rectangle(new Point(0, 0), 2, 3);
        expect(rectangle.area()).toBe(6);
    });

    it('should calculate perimeter correctly', () => {
        const rectangle = new Rectangle(new Point(0, 0), 2, 3);
        expect(rectangle.perimeter()).toBe(10);
    });

    it('should move correctly', () => {
        const rectangle = new Rectangle(new Point(0, 0), 2, 3);
        rectangle.move(1, 1);
        const movedVertices = rectangle.getVertices();
        expect(movedVertices[0].x).toBe(1);
        expect(movedVertices[0].y).toBe(1);
    });

    it('should rotate correctly', () => {
        const rectangle = new Rectangle(new Point(0, 0), 2, 3);
        rectangle.rotate(90);
        const rotatedVertices = rectangle.getVertices();
        expect(rotatedVertices[0].x).toBeCloseTo(0);
        expect(rotatedVertices[0].y).toBeCloseTo(0);
        expect(rotatedVertices[1].x).toBeCloseTo(0);
        expect(rotatedVertices[1].y).toBeCloseTo(2);
        expect(rotatedVertices[2].x).toBeCloseTo(-3);
        expect(rotatedVertices[2].y).toBeCloseTo(2);
        expect(rotatedVertices[3].x).toBeCloseTo(-3);
        expect(rotatedVertices[3].y).toBeCloseTo(0);
    });

    it('should resize correctly', () => {
        const rectangle = new Rectangle(new Point(0, 0), 2, 3);
        rectangle.resize(0.5);
        const resizedVertices = rectangle.getVertices();
        expect(resizedVertices[1].x).toBeCloseTo(1);
        expect(resizedVertices[1].y).toBeCloseTo(0);
        expect(resizedVertices[2].x).toBeCloseTo(1);
        expect(resizedVertices[2].y).toBeCloseTo(1.5);
        expect(resizedVertices[3].x).toBeCloseTo(0);
        expect(resizedVertices[3].y).toBeCloseTo(1.5);
    });
});
