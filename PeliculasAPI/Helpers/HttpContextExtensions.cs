﻿using Microsoft.EntityFrameworkCore;

namespace PeliculasAPI.Helpers
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacion<T>(this HttpContext context, IQueryable<T> queryable, int cantidadRegistrosPorPagina)
        {
            double cantidad = await queryable.CountAsync();
            double cantidadPaginas = Math.Ceiling(cantidad / cantidadRegistrosPorPagina);

            context.Response.Headers.Add("cantidadPaginas",cantidadPaginas.ToString());
        }
    }
}
