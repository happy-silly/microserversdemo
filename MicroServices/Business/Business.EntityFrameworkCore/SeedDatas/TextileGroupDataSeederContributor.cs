using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Business.Models;

namespace Business.SeedDatas
{
    public class TextileGroupDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<TextileGroup, Guid> _textileGroups;

        public TextileGroupDataSeederContributor(IRepository<TextileGroup, Guid> textileGroups)
        {
            _textileGroups = textileGroups;
        }

        public async Task SeedAsync(DataSeedContext dataSeedContext)
        {
            if (await _textileGroups.GetCountAsync() <= 0)
            {
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "武汉裕大华纺织服装集团有限公司",
                        WebSite = "http://www.yudahua.com.cn",
                        Address = "湖北省武汉市青山区工业四路5号",
                        Slogan = "经纬编织，跨越百年。创造价值，分享成果。"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "夏邑恒天永安新织造有限公司",
                        WebSite = "http://www.xiayihengtianyongan.com/index.html",
                        Address = "河南省商丘市夏邑县长寿大道与腾飞大道交叉口东北角夏邑产业集聚区科技孵化园内",
                        Slogan = ""
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "河南永安纺织有限公司",
                        WebSite = "",
                        Address = "夏邑县产业集聚区跨越大道东段南侧",
                        Slogan = "军魂育人，孝道造心，人本诚信，学习创新"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "无锡经纬纺织科技试验有限公司",
                        WebSite = "http://wxjw.jwgf.com/",
                        Address = "江苏无锡滨湖区马山梅梁西路42号",
                        Slogan = ""
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "江苏联发纺织股份有限公司",
                        WebSite = "http://www.lianfa.cn/",
                        Address = "中国江苏省南通市海安县恒联路88号",
                        Slogan = "编织梦想，传承文明"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "山东如意科技集团",
                        WebSite = "http://www.chinaruyi.com/home",
                        Address = "山东省济宁市高新区如意工业园",
                        Slogan = "以传承千年的儒学精神为根基，提炼德载品质、竞显卓越、从严求实、至诚至善"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "江苏大生集团有限公司",
                        WebSite = "http://www.dasheng-group.com.cn/",
                        Address = "江苏省南通市港闸区唐闸南市街14号",
                        Slogan = "天地之大德日生"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "宜宾弘曲线业有限公司",
                        WebSite = "",
                        Address = "四川省宜宾市屏山县屏山镇王场工业园区",
                        Slogan = ""
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "天虹纺织集团有限公司",
                        WebSite = "http://www.texhong.com",
                        Address = "上海市黄浦区中山东二路88号",
                        Slogan = "敬天爱人、自利利他"
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "南阳木兰花股份有限公司",
                        WebSite = "",
                        Address = "河南省南阳市伏牛南路",
                        Slogan = ""
                    },
                    autoSave: true
                );
                await _textileGroups.InsertAsync(
                    new TextileGroup
                    {
                        GroupName = "芦山湘邻纺织有限公司",
                        WebSite = "",
                        Address = "芦山县芦阳镇灵鹫山路2号附10号",
                        Slogan = ""
                    },
                    autoSave: true
                );
            }
        }
    }
}
