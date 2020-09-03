import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateArvoreComponent } from './arvore/create-arvore.component';
import { ListArvoresComponent } from './arvore/list-arvores.component';
import { CreateColheitaComponent } from './colheita/create-colheita.component';
import { ListColheitasComponent } from './colheita/list-colheitas.component';
import { CreateEspecieComponent } from './especie/create-especie.component';
import { ListEspeciesComponent } from './especie/list-especies.component';
import { CreateGrupoArvoreComponent } from './grupoArvore/create-grupo-arvore.component';
import { ListGruposArvoreComponent } from './grupoArvore/list-grupos-arvore.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: 'createArvore', component: CreateArvoreComponent },
  {path: 'listArvores', component: ListArvoresComponent },

  {path: 'createColheita', component: CreateColheitaComponent },
  {path: 'listColheitas', component: ListColheitasComponent },

  {path: 'createEspecie', component: CreateEspecieComponent },
  {path: 'listEspecies', component: ListEspeciesComponent },

  {path: 'createGrupoArvore', component: CreateGrupoArvoreComponent },
  {path: 'listGruposArvore', component: ListGruposArvoreComponent },
  
  {path: 'home', component: HomeComponent },
  {path: '', component: HomeComponent }
];

@NgModule({

  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
