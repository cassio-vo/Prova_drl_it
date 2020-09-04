import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CreateArvoreComponent } from './arvore/create-arvore.component';
import { ListArvoresComponent } from './arvore/list-arvores.component';
import { CreateColheitaComponent } from './colheita/create-colheita.component';
import { ListColheitasComponent } from './colheita/list-colheitas.component';
import { CreateEspecieComponent } from './especie/create-especie.component';
import { ListEspeciesComponent } from './especie/list-especies.component';
import { CreateGrupoArvoreComponent } from './grupoArvore/create-grupo-arvore.component';
import { ListGruposArvoreComponent } from './grupoArvore/list-grupos-arvore.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateArvoreComponent,
    ListArvoresComponent,
    CreateColheitaComponent,
    ListColheitasComponent,
    CreateEspecieComponent,
    ListEspeciesComponent,
    CreateGrupoArvoreComponent,
    ListGruposArvoreComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
