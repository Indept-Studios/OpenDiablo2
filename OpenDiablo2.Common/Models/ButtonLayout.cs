﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using OpenDiablo2.Common.Enums;

namespace OpenDiablo2.Common.Models
{
    public class ButtonLayout
    {
        public int XSegments { get; internal set; }
        public string ResourceName { get; internal set; }
        public string PaletteName { get; internal set; }
        public bool Toggleable { get; internal set; } = false;
        public int BaseFrame { get; internal set; } = 0;
        public int DisabledFrame { get; internal set; } = -1;

        public bool IsDarkenedWhenDisabled => DisabledFrame == -1;

        public static ImmutableDictionary<eButtonType, ButtonLayout> Values { get; } = new Dictionary<eButtonType, ButtonLayout>
        {
            {eButtonType.Wide,  new ButtonLayout { XSegments = 2, ResourceName = ResourcePaths.WideButtonBlank, PaletteName = Palettes.Units } },
            {eButtonType.Medium, new ButtonLayout{ XSegments = 1, ResourceName=ResourcePaths.MediumButtonBlank, PaletteName = Palettes.Units } },
            {eButtonType.Narrow, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.NarrowButtonBlank,PaletteName = Palettes.Units } },
            {eButtonType.Tall, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.TallButtonBlank, PaletteName = Palettes.Units } },
            {eButtonType.Cancel, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.CancelButton,PaletteName = Palettes.Units } },
            // Minipanel
            {eButtonType.MinipanelCharacter, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 0 } },
            {eButtonType.MinipanelInventory, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 2 } },
            {eButtonType.MinipanelSkill, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 4 } },
            {eButtonType.MinipanelAutomap, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 8 } },
            {eButtonType.MinipanelMessage, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 10 } },
            {eButtonType.MinipanelQuest, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 12 } },
            {eButtonType.MinipanelMenu, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MinipanelButton,PaletteName = Palettes.Units, BaseFrame = 14 } },
            
            {eButtonType.SecondaryInvHand, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.InventoryWeaponsTab, PaletteName = Palettes.Units } },
            {eButtonType.Run, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.RunButton,PaletteName = Palettes.Units, Toggleable = true } },
            {eButtonType.Menu, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.MenuButton,PaletteName = Palettes.Units, Toggleable = true } },
            {eButtonType.GoldCoin, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.GoldCoinButton,PaletteName = Palettes.Units } },
            {eButtonType.Close, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.SquareButton,PaletteName = Palettes.Units, BaseFrame = 10 } },
            {eButtonType.Skill, new ButtonLayout {XSegments = 1, ResourceName = ResourcePaths.AddSkillButton, PaletteName = Palettes.Units, DisabledFrame = 2 } },
        }.ToImmutableDictionary();
    }

}
