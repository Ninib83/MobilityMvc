using MobilityMvc.Models;
using MobilityMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilityMvc.Controllers
{
    public class DataManager
    {
        private ProductContext _context;

        public DataManager(ProductContext context)
        {
            _context = context;

        }

        public Product GetById(int id)
        {
            Product product = _context.Products.Single(a => a.Id == id);

            return product;
        }

        public List<ListProductViewModel> ListProduct()
        {

            var viewModels = new List<ListProductViewModel>();

            foreach (var product in _context.Products)
            {
                var viewModel = new ListProductViewModel();

                viewModel.Id = product.Id;
                viewModel.ProductName = product.ProductName;
                viewModel.Description = product.Description;
                viewModel.Price = product.Price;
                viewModel.Image = product.Image;

                viewModels.Add(viewModel);
            }

            return viewModels;
        }
        public void Create(CreateProductViewModel createProduct)
        {

            var product = new Product
            {
                ProductName = createProduct.ProductName,
                Price = createProduct.Price,
                Description = createProduct.Description,
                Image = createProduct.Image,
                Id = createProduct.Id
            };

            _context.Products.Add(product);
            _context.SaveChangesAsync();
        }

        //public EditingArtistViewModel Edit(int id)
        //{

        //    Artist artist = _context.Artists.Where(a => a.Id == id).Single();

        //    return new EditingArtistViewModel
        //    {
        //        Description = artist.Description,
        //        EMail = artist.EMail,
        //        Name = artist.Name,
        //        Revenue = artist.Revenue,
        //        Id = artist.Id,

        //    };
        //}

        //public void Uppdate(EditingArtistViewModel editArtist)
        //{
        //    var artist = new Artist
        //    {
        //        Description = editArtist.Description,
        //        EMail = editArtist.EMail,
        //        Name = editArtist.Name,
        //        Revenue = editArtist.Revenue,
        //        Id = editArtist.Id

        //    };

        //    _context.Entry(artist).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    Artist artist = _context.Artists.Where(a => a.Id == id).SingleOrDefault();
        //    _context.Remove(artist);
        //    _context.SaveChanges();

        //}
    }
}
