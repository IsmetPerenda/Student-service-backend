using AutoMapper;
using Database;
using Microsoft.EntityFrameworkCore;
using StudentService.Entities;
using StudentService.Interfaces;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Services
{
    public class KursService : IKursService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public KursService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<int> AddKurs(AddKursDTO kurs)
        {
            var AddKurs = new Kurs
            {
                NazivKursa = kurs.NazivKursa,
                Studenti = kurs.Studenti

            };

            await _context.Kursevi.AddAsync(AddKurs);
            await _context.SaveChangesAsync();

            return AddKurs.KursId;
        }

        public async Task<int> DeleteKurs(int id)
        {
            if (id <= 0)
            {
                return 1;
            }
            Kurs k = await _context.Kursevi.FirstOrDefaultAsync(x => x.KursId == id);

            _context.Remove(k);
            await _context.SaveChangesAsync();

            return 0;
        }

        public async Task<int> EditKurs(EditKursDTO kurs, int id)
        {
            Kurs k = _context.Kursevi.Find(id);


            k.NazivKursa = kurs.NazivKursa;
            k.Studenti = kurs.Studenti;

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<GetKursDTO> GetKursAsync(int id)
        {
            var x = await _context.Kursevi.FirstOrDefaultAsync(x => x.KursId == id);

            var kurs = _mapper.Map<GetKursDTO>(x);

            return kurs;
        }

        public async Task<List<GetKursDTO>> GetAllAsync()
        {
            return await _context.Kursevi.Select(x => _mapper.Map<GetKursDTO>(x)).ToListAsync();
        }


    }
}
