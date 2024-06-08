import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarMultaComponent } from './cadastrar-multa.component';

describe('CadastrarMultaComponent', () => {
  let component: CadastrarMultaComponent;
  let fixture: ComponentFixture<CadastrarMultaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadastrarMultaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastrarMultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
