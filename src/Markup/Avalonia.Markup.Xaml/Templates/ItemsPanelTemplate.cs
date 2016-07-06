// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Avalonia.Controls;
using Avalonia.Metadata;
using Avalonia.Styling;

namespace Avalonia.Markup.Xaml.Templates
{
    public class ItemsPanelTemplate : ITemplate<IPanel>
    {
        [Content]
        public TemplateContent Content { get; set; }

        public IPanel Build()
        {
            return (IPanel)Content.Load();
        }

        object ITemplate.Build() => Build();
    }
}
