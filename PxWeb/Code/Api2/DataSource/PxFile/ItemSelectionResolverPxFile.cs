﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Caching.Memory;
using PCAxis.Menu;
using Px.Abstractions.Interfaces;
using PxWeb.Code.Api2.DataSource.Cnmm;
using PxWeb.Config.Api2;

namespace PxWeb.Code.Api2.DataSource.PxFile
{
    public class ItemSelectionResolverPxFile : IItemSelectionResolver
    {

        private readonly IMemoryCache _memoryCache;
        private readonly IItemSelectionResolverFactory _itemSelectionResolverFactory;
        private readonly IPxApiConfigurationService _pxApiConfigurationService;

        public ItemSelectionResolverPxFile(IMemoryCache memoryCache, IItemSelectionResolverFactory itemSelectionResolverFactory, IPxApiConfigurationService pxApiConfigurationService)
        {
            _memoryCache = memoryCache;
            _itemSelectionResolverFactory = itemSelectionResolverFactory;
            _pxApiConfigurationService = pxApiConfigurationService;
        }
        public ItemSelection Resolve(string language, string selection, out bool selectionExists)
        {
            var op = _pxApiConfigurationService.GetConfiguration();

            selectionExists = true;
            ItemSelection itemSelection = new ItemSelection();
            
            string lookupTableName = "LookUpTableCache_" + language;
            if (!_memoryCache.TryGetValue(lookupTableName, out Dictionary<string, string> lookupTable))
            {
                lookupTable = _itemSelectionResolverFactory.GetMenuLookup(language);
              
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(op.CacheTime));

                _memoryCache.Set(lookupTableName, lookupTable, cacheEntryOptions);
            }

            if (!string.IsNullOrEmpty(selection))
            {
                if (lookupTable.ContainsKey(selection.ToUpper()))
                {
                    string menu = lookupTable[selection.ToUpper()];
                    itemSelection.Menu = menu;
                    itemSelection.Selection = Path.Combine(menu, selection);
                }
                else
                {
                    selectionExists = false;
                }
            }
            return itemSelection;
        }
    }
}
