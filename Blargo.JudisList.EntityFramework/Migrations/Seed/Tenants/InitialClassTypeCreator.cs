using Blargo.JudisList.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blargo.JudisList.Migrations.Seed.Tenants
{
    public class InitialClassTypeCreator
    {

        private readonly JudisListDbContext _context;

        public InitialClassTypeCreator(JudisListDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var dm = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Dance Mixx");
            if (dm == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Dance Mixx"
                    });
            }

            var ex = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Express");
            if (ex == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Express"
                    });
            }

            var ff = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Flip Fusion");
            if (ff == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Flip Fusion"
                    });
            }

            var f = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Fusion");
            if (f == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Fusion"
                    });
            }

            var idm = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Interval Dance Mixx");
            if (idm == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Interval Dance Mixx"
                    });
            }

            var iff = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Interval Fusion");
            if (iff == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Interval Fusion"
                    });
            }

            var lo = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Lo");
            if (lo == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Lo"
                    });
            }

            var s30 = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Strength 30");
            if (s30 == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Strength 30"
                    });
            }

            var s45 = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Strength 45");
            if (s45 == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Strength 45"
                    });
            }

            var s60 = _context.ClassTypes.FirstOrDefault(p => p.ClassTypeName == "Strength 60");
            if (s60 == null)
            {
                _context.ClassTypes.Add(
                    new ClassType
                    {
                        ClassTypeName = "Strength 60"
                    });
            }

        }


    }
}
