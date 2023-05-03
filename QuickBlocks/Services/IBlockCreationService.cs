﻿using HtmlAgilityPack;

using Microsoft.AspNetCore.Hosting;
using QuickBlocks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Strings;

namespace QuickBlocks.Services
{
    public interface IBlockCreationService
    {
        public bool CreateRowPartial(RowModel row);

        void CreateList(BlockListModel list, FolderStructure folderStructure, int parentDataTypeId);

        List<BlockListConfiguration.BlockConfiguration> CreateBlockConfigurations(BlockListModel list, FolderStructure folderStructure);

        BlockListConfiguration.BlockConfiguration CreateBlockConfiguration(RowModel row, FolderStructure folderStructure);

        void CreateBlockListDataType(BlockListModel list, List<BlockListConfiguration.BlockConfiguration> blocks, int parentDataTypeId);

        IContentType CreateContentType(string name, string alias, int parentId = -1,
            bool isElement = true, bool isContainer = false, string iconClass = "icon-science", 
            bool allowedAtRoot = false, bool updateDoctype = false);

        void AddPropertiesToContentType(IContentType contentType, IEnumerable<PropertyModel> properties, string groupName);

        FolderStructure CreateFolderStructure();

        int CreateSupportingDataTypes();

        void CreateSupportingContentTypes(int parentId);

        void RemoveAllQuickBlocksAttributes(HtmlDocument doc);

        void CreatePartialViews(List<PartialViewModel> partialViews);
    }
}