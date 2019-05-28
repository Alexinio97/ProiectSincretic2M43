import { Component, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  @ViewChild('left') left: ElementRef;
  @ViewChild('right') right: ElementRef;

  ngOnInit() {
    TweenMax.to(this.left.nativeElement, 1, {
      attr: {
        points: '125,30 125,30 125,30 31.9,30 31.9,230 125,230 125,230 125,230 203.9,186.3 218.1,63.2'
      },
      repeat: -1,
      yoyo: true,
      ease: Cubic.easeInOut
    });
    TweenMax.to(this.right.nativeElement, 1, {
      attr: {
        points: '125,30 125,52.2 125,52.1 125,153.4 125,153.4 125,230 125,230 218.1,230 218.1,30 125,30'
      },
      repeat: -1,
      yoyo: true,
      ease: Cubic.easeInOut
    });
  }
}
