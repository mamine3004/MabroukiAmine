using coreLayer;
using DaoLayer.Posts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPost _postservice;

        public PostController(IPost postservice)
        {
            _postservice = postservice;
        }

        // GET: api/<PostController>
        [HttpGet]
        public IEnumerable<Post>? GetAllPost()
        {
            List<Post> posts =  _postservice.getAllPosts();
            return posts;
        }

        // GET api/<PostController>/5
        [HttpGet("User/{id}")]
        public IEnumerable<Post>? Get(int id)
        {
            List<Post> posts = _postservice.getAllPostsByUser(id);
            return posts;
        }

        // POST api/<PostController>
        [HttpPost("User/{id}")]
        public int AddPost(int id,[FromBody] Post post)
        {
            return _postservice.addPost(id, post);
        }

        //// PUT api/<PostController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PostController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
