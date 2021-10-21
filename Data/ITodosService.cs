using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_web_api.Models;

namespace DNP_web_api.Data {
    public interface ITodosService {
        Task<IList<Todo>> GetTodosAsync();
        Task<Todo>   AddTodoAsync(Todo todo);
        Task   RemoveTodoAsync(int todoId);
        Task<Todo>   UpdateAsync(Todo todo);
    }
}