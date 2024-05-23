export class Point {
    constructor(public x: number, public y: number) {}

    move(dx: number, dy: number): void {
        this.x += dx;
        this.y += dy;
    }

    rotate(angle: number, origin: Point = new Point(0, 0)): void {
        const radians = angle * (Math.PI / 180);
        const cos = Math.cos(radians);
        const sin = Math.sin(radians);
        const translatedX = this.x - origin.x;
        const translatedY = this.y - origin.y;
        const rotatedX = translatedX * cos - translatedY * sin;
        const rotatedY = translatedX * sin + translatedY * cos;
        this.x = rotatedX + origin.x;
        this.y = rotatedY + origin.y;
    }

    scale(factor: number, origin: Point = new Point(0, 0)): void {
        this.x = origin.x + factor * (this.x - origin.x);
        this.y = origin.y + factor * (this.y - origin.y);
    }
}
