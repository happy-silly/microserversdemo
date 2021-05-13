using Business.DTOs.CraftNodeLists;
using Business.Models.Craft;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.Craft
{
    /// <summary>
    /// 工艺节点
    /// </summary>
    public class CraftNodeListAppService:ApplicationService
    {
        private readonly IRepository<CraftNodeList, Guid> _craftNodeLists;
        private readonly IRepository<CraftNodeTextileProcessAssociation, Guid> _craftNodeTextileProcessAssociations;
        public CraftNodeListAppService(IRepository<CraftNodeList, Guid> craftNodeLists,
            IRepository<CraftNodeTextileProcessAssociation, Guid> craftNodeTextileProcessAssociations
            )
        {
            _craftNodeLists = craftNodeLists;
            _craftNodeTextileProcessAssociations = craftNodeTextileProcessAssociations;
        }
        //Task<TEntityDto> GetAsync(TKey id);
        //Task<PagedResultDto<TEntityDto>> GetListAsync(TGetListInput input);
        //Task<TEntityDto> CreateAsync(TCreateInput input);
        //Task<TEntityDto> UpdateAsync(TKey id, TUpdateInput input);
        //Task DeleteAsync(TKey id);
        /// <summary>
        /// 工艺节点查询
        /// </summary>
        /// <returns></returns>
        public async  Task<ActionResult<IEnumerable<CraftNodeList>>> GetAllAsync()
        {
            return await _craftNodeLists.GetListAsync();
        }
        
        //[EnableQuery]
        public async Task<CraftNodeList> CreateAsync(CreateCraftNodeListDto input)
        {
            try
            {
                var CraftInput = ObjectMapper.Map<CreateCraftNodeListDto, CraftNodeList>(input);
                await _craftNodeLists.InsertAsync(CraftInput);
                return CraftInput;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
