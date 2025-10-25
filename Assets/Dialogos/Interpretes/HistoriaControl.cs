using UnityEngine;
using Ging1991.Dialogos;
using Ging1991.Persistencia.Lectores.Demandas;
using Ging1991.Persistencia.Direcciones;
using System.Globalization;
using Ging1991.Persistencia.Lectores;
using Ging1991.Relojes;

namespace Bounds.Historia {

	public class HistoriaControl : MonoBehaviour {
		/*
				public GameObject personajeClaseOBJ;
				public Dialogo dialogoOBJ;
				public GameObject personajesOBJ;

				private ProveedorImagenPersonaje proveedorPersonaje;
				private ProveedorImagenPersonaje proveedorMiniatura;
				public LectorHistoriaLaunix lector;
				private Configuracion configuracion;
				private bool mostrandotexto;

				public PantallaTactil pantallaTactil;

				void Start() {
					proveedorPersonaje = new ProveedorImagenPersonaje(new DireccionRecursos("PERSONAJES"));
					proveedorMiniatura = new ProveedorImagenPersonaje(new DireccionRecursos("MINIATURAS"));
					dialogoOBJ.Inicializar(proveedorMiniatura);
					configuracion = new Configuracion();
					lector = new LectorHistoriaLaunix(configuracion.LeerCapituloHistoria());
					pantallaTactil.Inicializar(this);
					mostrandotexto = false;
				}


				void FixedUpdate() {
					if (Input.GetKeyUp(KeyCode.Space))
						BotonSiguiente();
				}


				private void CrearPersonaje(string nombre) {
					GameObject instancia = Instantiate(personajeClaseOBJ);
					instancia.name = nombre;
					instancia.transform.SetParent(personajesOBJ.transform);
					instancia.transform.localPosition = new Vector3(0, 0, 0);
					instancia.transform.localScale = new Vector3(1, 1, 1);
					instancia.GetComponent<Ging1991.Dialogos.Personaje>().Inicializar(proveedorPersonaje);
				}


				private void SetMiniatura(string nombre) {
					dialogoOBJ.miniaturaOBJ.SetImagen(nombre);
				}


				private void SetImagen(string nombre, string imagen) {
					TraerPersonaje(nombre).SetImagen(imagen);
				}


				private void SetPosicion(string nombre, string posX, string posY) {
					TraerPersonaje(nombre).SetPosicion(int.Parse(posX), int.Parse(posY));
				}


				private Ging1991.Dialogos.Personaje TraerPersonaje(string nombre) {
					return GameObject.Find(nombre).GetComponent<Ging1991.Dialogos.Personaje>();
				}


				private void SetEscala(string nombre, string escala) {
					float escalaValor = float.Parse(escala, CultureInfo.InvariantCulture);
					TraerPersonaje(nombre).gameObject.transform.localScale = new Vector3(escalaValor, escalaValor, 1);
				}


				public void BotonSiguiente() {
					string comando = lector.Siguiente();
					if (comando != null) {
						if (comando == "CREAR_PERSONAJE") {
							CrearPersonaje(lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_IMG") {
							SetImagen(lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_POSICION") {
							SetPosicion(lector.Siguiente(), lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_MINIATURA") {
							SetMiniatura(lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_ESCALA") {
							SetEscala(lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "DUELO") {
							JugarDuelo(lector.Siguiente(), lector.Siguiente(), lector.Siguiente(), lector.Siguiente(),
									lector.Siguiente(), lector.Siguiente(), lector.Siguiente(), lector.Siguiente());
						}

						if (comando == "FINAL") {
							configuracion.GuardarCapituloHistoria(1);
							ControlEscena.GetInstancia().CambiarEscena_menu();
						}
						mostrandotexto = true;
						dialogoOBJ.textoOBJ.SetTexto(comando);
					}
				}


				public void JugarDuelo(string nombre1, string miniatura1, string LP1, string nombreMazo1,
						string nombre2, string miniatura2, string LP2, string nombreMazo2) {

					GlobalDuelo parametros = GlobalDuelo.GetInstancia();
					parametros.modo = "HISTORIA";
					parametros.dueloModo = DueloConstantes.Modo.HISTORIA;
					parametros.jugadorLP1 = int.Parse(LP1);
					parametros.jugadorLP2 = int.Parse(LP2);
					parametros.jugadorNombre1 = nombre1;
					parametros.jugadorNombre2 = nombre2;
					parametros.jugadorMiniatura1 = miniatura1;
					parametros.jugadorMiniatura2 = miniatura2;

					Global.Mazo mazo1 = new MazoHistoria(nombreMazo1);
					Global.Mazo mazo2 = new MazoHistoria(nombreMazo2);

					parametros.mazo1 = mazo1.cartas;
					parametros.mazo2 = mazo2.cartas;
					parametros.mazoVacio1 = mazo1.principalVacio;
					parametros.mazoVacio2 = mazo2.principalVacio;
					parametros.protector1 = mazo1.protector;
					parametros.protector2 = mazo2.protector;

					ControlEscena escena = ControlEscena.GetInstancia();
					escena.CambiarEscena_duelo();
				}

				public void BotonVolver() {
					ControlEscena escena = ControlEscena.GetInstancia();
					escena.CambiarEscena_menu();
				}


				public void Ejecutar() {
					if (mostrandotexto) {
						dialogoOBJ.textoOBJ.MostrarTextoCompleto();
						mostrandotexto = false;
					}
					else
						BotonSiguiente();
				}


				private class ProveedorImagenPersonaje : LectorPorDemandaImagen, IProveedorImagen {

					public ProveedorImagenPersonaje(Direccion direccionCarpeta) : base(direccionCarpeta, TipoLector.RECURSOS) { }

					public Sprite GetImagen(string nombre) {
						return Leer(nombre);
					}

				}

		*/
	}

}