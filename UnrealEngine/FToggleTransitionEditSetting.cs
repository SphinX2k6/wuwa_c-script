using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002117 RID: 8471
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/LGUI.ToggleTransitionEditSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FToggleTransitionEditSetting : IEqualityOperators<FToggleTransitionEditSetting, FToggleTransitionEditSetting, bool>, IEquatable<FToggleTransitionEditSetting>, IUnrealScriptStruct
	{
		// Token: 0x0601FDFA RID: 130554 RVA: 0x002F6B74 File Offset: 0x002F4D74
		public FToggleTransitionEditSetting(bool bEnableUnDetermined, bool bCustomUnCheckedHover, bool bCustomUnCheckedPressed, bool bCustomCheckedHover, bool bCustomCheckedPressed, bool bCustomUnDeterminedHover, bool bCustomUnDeterminePressed)
		{
			this.__DummyField0 = (byte)(((bEnableUnDetermined > false) ? 1 : 0) | (bCustomUnCheckedHover ? 2 : 0) | (bCustomUnCheckedPressed ? 4 : 0) | (bCustomCheckedHover ? 8 : 0) | (bCustomCheckedPressed ? 16 : 0) | (bCustomUnDeterminedHover ? 32 : 0) | (bCustomUnDeterminePressed ? 64 : 0));
		}

		// Token: 0x17007D5D RID: 32093
		// (get) Token: 0x0601FDFB RID: 130555 RVA: 0x002F6BC3 File Offset: 0x002F4DC3
		// (set) Token: 0x0601FDFC RID: 130556 RVA: 0x002F6BD0 File Offset: 0x002F4DD0
		public bool bEnableUnDetermined
		{
			get
			{
				return (this.__DummyField0 & 1) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 254) | ((value > false) ? 1 : 0));
			}
		}

		// Token: 0x17007D5E RID: 32094
		// (get) Token: 0x0601FDFD RID: 130557 RVA: 0x002F6BEA File Offset: 0x002F4DEA
		// (set) Token: 0x0601FDFE RID: 130558 RVA: 0x002F6BF7 File Offset: 0x002F4DF7
		public bool bCustomUnCheckedHover
		{
			get
			{
				return (this.__DummyField0 & 2) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 253) | (value ? 2 : 0));
			}
		}

		// Token: 0x17007D5F RID: 32095
		// (get) Token: 0x0601FDFF RID: 130559 RVA: 0x002F6C14 File Offset: 0x002F4E14
		// (set) Token: 0x0601FE00 RID: 130560 RVA: 0x002F6C21 File Offset: 0x002F4E21
		public bool bCustomUnCheckedPressed
		{
			get
			{
				return (this.__DummyField0 & 4) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 251) | (value ? 4 : 0));
			}
		}

		// Token: 0x17007D60 RID: 32096
		// (get) Token: 0x0601FE01 RID: 130561 RVA: 0x002F6C3E File Offset: 0x002F4E3E
		// (set) Token: 0x0601FE02 RID: 130562 RVA: 0x002F6C4B File Offset: 0x002F4E4B
		public bool bCustomCheckedHover
		{
			get
			{
				return (this.__DummyField0 & 8) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 247) | (value ? 8 : 0));
			}
		}

		// Token: 0x17007D61 RID: 32097
		// (get) Token: 0x0601FE03 RID: 130563 RVA: 0x002F6C68 File Offset: 0x002F4E68
		// (set) Token: 0x0601FE04 RID: 130564 RVA: 0x002F6C76 File Offset: 0x002F4E76
		public bool bCustomCheckedPressed
		{
			get
			{
				return (this.__DummyField0 & 16) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 239) | (value ? 16 : 0));
			}
		}

		// Token: 0x17007D62 RID: 32098
		// (get) Token: 0x0601FE05 RID: 130565 RVA: 0x002F6C94 File Offset: 0x002F4E94
		// (set) Token: 0x0601FE06 RID: 130566 RVA: 0x002F6CA2 File Offset: 0x002F4EA2
		public bool bCustomUnDeterminedHover
		{
			get
			{
				return (this.__DummyField0 & 32) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 223) | (value ? 32 : 0));
			}
		}

		// Token: 0x17007D63 RID: 32099
		// (get) Token: 0x0601FE07 RID: 130567 RVA: 0x002F6CC0 File Offset: 0x002F4EC0
		// (set) Token: 0x0601FE08 RID: 130568 RVA: 0x002F6CCE File Offset: 0x002F4ECE
		public bool bCustomUnDeterminePressed
		{
			get
			{
				return (this.__DummyField0 & 64) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 191) | (value ? 64 : 0));
			}
		}

		// Token: 0x0601FE09 RID: 130569 RVA: 0x002F6CEC File Offset: 0x002F4EEC
		public static bool operator ==(FToggleTransitionEditSetting left, FToggleTransitionEditSetting right)
		{
			return left.__DummyField0 == right.__DummyField0;
		}

		// Token: 0x0601FE0A RID: 130570 RVA: 0x002F6CFC File Offset: 0x002F4EFC
		public static bool operator !=(FToggleTransitionEditSetting left, FToggleTransitionEditSetting right)
		{
			return !(left == right);
		}

		// Token: 0x0601FE0B RID: 130571 RVA: 0x002F6D08 File Offset: 0x002F4F08
		public bool Equals(FToggleTransitionEditSetting other)
		{
			return this == other;
		}

		// Token: 0x0601FE0C RID: 130572 RVA: 0x002F6D18 File Offset: 0x002F4F18
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FToggleTransitionEditSetting)
			{
				FToggleTransitionEditSetting other = (FToggleTransitionEditSetting)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FE0D RID: 130573 RVA: 0x002F6D3D File Offset: 0x002F4F3D
		public override int GetHashCode()
		{
			return HashCode.Combine<byte>(this.__DummyField0);
		}

		// Token: 0x0601FE0E RID: 130574 RVA: 0x002F6D4A File Offset: 0x002F4F4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FToggleTransitionEditSetting._ScriptStructPtr != 0) ? FToggleTransitionEditSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ToggleTransitionEditSetting", ref FToggleTransitionEditSetting._ScriptStructPtr);
		}

		// Token: 0x040112D2 RID: 70354
		[FieldOffset(0)]
		private byte __DummyField0;

		// Token: 0x040112D3 RID: 70355
		public const string __ObjectPath = "/Script/LGUI.ToggleTransitionEditSetting";

		// Token: 0x040112D4 RID: 70356
		private static IntPtr _ScriptStructPtr;
	}
}
