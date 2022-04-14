﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public static class CadastroUsuario
    {
        private static Usuario[] usuarios = 
        {
            new Usuario(){ Nome = "Bruno", Senha = "abc123" },
            new Usuario(){ Nome = "Vivian", Senha = "123abc" },
            new Usuario(){ Nome = "Vinicius", Senha = "abcd" }
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
