import { Point } from './Point';

describe('Point', () => {
    it('should move correctly', () => {
        const point = new Point(1, 1);
        point.move(2, 3);
        expect(point.x).toBe(3);
        expect(point.y).toBe(4);
    });

    it('should rotate correctly around the origin', () => {
        const point = new Point(1, 0);
        point.rotate(90);
        expect(point.x).toBeCloseTo(0);
        expect(point.y).toBeCloseTo(1);
    });

    it('should rotate correctly around another point', () => {
        const point = new Point(2, 1);
        const origin = new Point(1, 1);
        point.rotate(90, origin);
        expect(point.x).toBeCloseTo(1);
        expect(point.y).toBeCloseTo(2);
    });

    it('should scale correctly relative to the origin', () => {
        const point = new Point(2, 2);
        point.scale(0.5);
        expect(point.x).toBe(1);
        expect(point.y).toBe(1);
    });

    it('should scale correctly relative to another point', () => {
        const point = new Point(2, 2);
        const origin = new Point(1, 1);
        point.scale(2, origin);
        expect(point.x).toBe(3);
        expect(point.y).toBe(3);
    });
});
