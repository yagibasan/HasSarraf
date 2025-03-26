using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasSarraf.BackOffice.Library.Saglamoglu
{
    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        [JsonProperty("bid")]
        public decimal Bid { get; set; }  
        
        [JsonProperty("laborAsk")]
        public decimal LaborAsk { get; set; }

        [JsonProperty("laborBid")]
        public decimal LaborBid { get; set; }
    }

    public class Forex
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        [JsonProperty("lastClose")]
        public decimal LastClose { get; set; }

        [JsonProperty("lastOpen")]
        public decimal LastOpen { get; set; }
    }

    public class Pivot
    {
        [JsonProperty("tab_id")]
        public int TabId { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("item_order")]
        public int? ItemOrder { get; set; }
    }

    public class Product
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("forex")]
        public Forex Forex { get; set; }

        [JsonProperty("pivot")]
        public Pivot Pivot { get; set; }
    }

    public class Tab
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tab_group_id")]
        public int TabGroupId { get; set; }

        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }

    public class TabGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tabs")]
        public List<Tab> Tabs { get; set; }
    }

    public class SaglamogluDto
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("tabGroup")]
        public TabGroup TabGroup { get; set; }
    }


}
