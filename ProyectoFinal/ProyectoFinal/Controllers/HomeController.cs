using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;


namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        // Método para obtener el carrito desde la sesión
        private List<CarritoItem> ObtenerCarrito()
        {
            if (Session["Carrito"] == null)
            {
                Session["Carrito"] = new List<CarritoItem>();
            }
            return (List<CarritoItem>)Session["Carrito"];
        }

        // Métodos de navegación
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuienesSomos()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult Carrito()
        {
            var carrito = ObtenerCarrito();
            return View(carrito);
        }

        // Agregar al carrito
        [HttpPost]
        public ActionResult AgregarAlCarrito(int productoID, string nombre, decimal precio)
        {
            // Inicializa el carrito si no existe
            if (Session["Carrito"] == null)
            {
                Session["Carrito"] = new List<CarritoItem>();
            }

            var carrito = (List<CarritoItem>)Session["Carrito"];

            // Verifica si el producto ya está en el carrito
            var itemExistente = carrito.FirstOrDefault(c => c.ProductoID == productoID);
            if (itemExistente != null)
            {
                // Si el producto ya está, solo incrementamos la cantidad
                itemExistente.Cantidad++;
            }
            else
            {
                // Si el producto no está en el carrito, lo agregamos
                carrito.Add(new CarritoItem
                {
                    ProductoID = productoID,
                    Nombre = nombre,
                    Precio = precio,
                    Cantidad = 1
                });
            }

            // Actualiza la sesión con el nuevo carrito
            Session["Carrito"] = carrito;

            // Retorna un estado de éxito
            return Json(new { success = true });
        }


        // Método para enviar el mensaje de contacto
        [HttpPost]
        public ActionResult EnviarMensaje(string Nombre, string Email, string Mensaje)
        {
            try
            {
                MailMessage correo = new MailMessage
                {
                    From = new MailAddress("tuemail@example.com"),
                    Subject = $"Nuevo mensaje de {Nombre}",
                    Body = $"Nombre: {Nombre}\nCorreo: {Email}\nMensaje:\n{Mensaje}",
                    IsBodyHtml = false
                };
                correo.To.Add("destinatario@example.com");

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",  // Cambia esto según tu proveedor
                    Port = 587,  // Usa 587 en lugar de 465 para SMTP con StartTLS
                    Credentials = new NetworkCredential("tuemail@example.com", "tucontraseña"),
                    EnableSsl = true
                };

                smtp.Send(correo);
                ViewBag.Mensaje = "Mensaje enviado con éxito.";
            }
            catch (SmtpException ex)
            {
                ViewBag.Mensaje = $"Error al enviar el mensaje: {ex.Message}";
            }
            return View("Contacto");
        }

        public ActionResult EliminarDelCarrito(int productoID)
        {
            // Obtén el carrito de la sesión (o crea uno si no existe)
            var carrito = (List<CarritoItem>)Session["Carrito"];

            if (carrito != null)
            {
                // Busca el producto en el carrito
                var item = carrito.FirstOrDefault(c => c.ProductoID == productoID);

                if (item != null)
                {
                    // Elimina el producto
                    carrito.Remove(item);
                    Session["Carrito"] = carrito;
                }
            }

            return RedirectToAction("Carrito");
        }

    }
}

