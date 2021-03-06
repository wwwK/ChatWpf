﻿using System.Collections.Generic;
using ChatWpf.Core.DataModels;
using ChatWpf.ViewModel.Menu;

namespace ChatWpf.ViewModel.PopupMenu
{
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>(new[]
                {
                    new MenuItemViewModel { Text = "Attach a file...", Type = MenuItemType.Header },
                    new MenuItemViewModel { Text = "From Computer", Icon = IconType.File },
                    new MenuItemViewModel { Text = "From Pictures", Icon = IconType.Picture }
                })
            };
        }
    }
}
