﻿using System;
using System.Collections.Generic;
using Datory;
using Newtonsoft.Json;
using SiteServer.CMS.Database.Core;
using SiteServer.CMS.Database.Models;

namespace SiteServer.Cli.Updater.Tables
{
    public partial class TableContentCheck
    {
        [JsonProperty("checkID")]
        public long CheckId { get; set; }

        [JsonProperty("tableName")]
        public string TableName { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("nodeID")]
        public long NodeId { get; set; }

        [JsonProperty("contentID")]
        public long ContentId { get; set; }

        [JsonProperty("isAdmin")]
        public string IsAdmin { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("isChecked")]
        public string IsChecked { get; set; }

        [JsonProperty("checkedLevel")]
        public long CheckedLevel { get; set; }

        [JsonProperty("checkDate")]
        public DateTimeOffset CheckDate { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }
    }

    public partial class TableContentCheck
    {
        public const string OldTableName = "bairong_ContentCheck";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private static readonly string NewTableName = DataProvider.ContentCheck.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.ContentCheck.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(ContentCheckInfo.Id), nameof(CheckId)},
                {nameof(ContentCheckInfo.SiteId), nameof(PublishmentSystemId)},
                {nameof(ContentCheckInfo.ChannelId), nameof(NodeId)}
            };

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}