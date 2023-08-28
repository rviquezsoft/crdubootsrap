using System;
namespace CRUDBLAZOR.Services
{
    public class FillMockData : IFillMockData
    {
        int rows = 5;
        private readonly List<Elemento> _list;
        public FillMockData(List<Elemento> list)
        {
            _list = list;
        }
        public async Task<List<Elemento>> FillData()
        {
            for (int i = 1; i <= rows; i++)
            {
                await Task.Delay(10);
                Elemento elemento = new Elemento
                {
                    id = i,
                    descripcion = $"Descripción {i}",
                    activo = i % 2 == 0,
                    fecha = DateTime.Now.AddDays(i)
                };

                _list.Add(elemento);
            }
            return _list;
        }
    }
}

