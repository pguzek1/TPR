﻿using System;
using System.Collections.Generic;

namespace Zadanie1.Data
{
    public interface IDataRepository
    {
        void AddKlient(Klient klient);
        Klient GetKlient(int id);
        IEnumerable<Klient> GetAllKlient();
        void UpdateKlient(int id, string imie, string nazwisko);
        void DeleteKlient(Klient klient);

        void AddKsiazka(Ksiazka ksiazka);
        Ksiazka GetKsiazka(int id);
        IEnumerable<Ksiazka> GetAllKsiazka();
        void UpdateKsiazka(int id, string tytul, string autor);
        void DeleteKsiazka(Ksiazka ksiazka);

        void AddStan(Stan stan);
        Stan GetStan(int id);
        IEnumerable<Stan> GetAllStan();
        void UpdateStan(int id, Ksiazka ksiazka, string opis, bool czyWypozyczona, DateTime dataZakupu);
        void DeleteStan(Stan stan);

        void AddZdarzenie(Zdarzenie zdarzenie);
        Zdarzenie GetZdarzenie(int id);
        IEnumerable<Zdarzenie> GetAllZdarzenie();
        void UpdateZdarzenie(int id, Zdarzenie zdarzenie);
        void DeleteZdarzenie(Zdarzenie zdarzenie);
    }
}
