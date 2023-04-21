﻿namespace Domain.Entities
{
    public class CaracteristicaTransporte
    {
        public int CaracteristicaTransporteId { get; set; }
        public string Valor { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }

        public int CaracteristicaId { get; set; }
        public Caracteristica Caracteristica { get; set; }

    }
}
