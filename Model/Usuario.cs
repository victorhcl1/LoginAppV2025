﻿namespace LoginAppV2025.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }

}
