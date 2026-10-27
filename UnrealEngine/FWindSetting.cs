using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C39 RID: 7225
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.WindSetting")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWindSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C068 RID: 114792 RVA: 0x00293F6E File Offset: 0x0029216E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWindSetting._ScriptStructPtr != 0) ? FWindSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.WindSetting", ref FWindSetting._ScriptStructPtr);
		}

		// Token: 0x1700714D RID: 29005
		// (get) Token: 0x0601C069 RID: 114793 RVA: 0x00293F92 File Offset: 0x00292192
		// (set) Token: 0x0601C06A RID: 114794 RVA: 0x00293FAB File Offset: 0x002921AB
		public unsafe bool bOverride_WindDirection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindDirection) & FWindSetting.__PropertyMask_bOverride_WindDirection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindDirection) = ((*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindDirection) & ~FWindSetting.__PropertyMask_bOverride_WindDirection) | (value ? FWindSetting.__PropertyMask_bOverride_WindDirection : 0));
			}
		}

		// Token: 0x1700714E RID: 29006
		// (get) Token: 0x0601C06B RID: 114795 RVA: 0x00293FDB File Offset: 0x002921DB
		// (set) Token: 0x0601C06C RID: 114796 RVA: 0x00293FEB File Offset: 0x002921EB
		public unsafe float WindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindDirection) = value;
			}
		}

		// Token: 0x1700714F RID: 29007
		// (get) Token: 0x0601C06D RID: 114797 RVA: 0x00293FFC File Offset: 0x002921FC
		// (set) Token: 0x0601C06E RID: 114798 RVA: 0x00294015 File Offset: 0x00292215
		public unsafe bool bOverride_WindSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindSpeed) & FWindSetting.__PropertyMask_bOverride_WindSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindSpeed) = ((*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindSpeed) & ~FWindSetting.__PropertyMask_bOverride_WindSpeed) | (value ? FWindSetting.__PropertyMask_bOverride_WindSpeed : 0));
			}
		}

		// Token: 0x17007150 RID: 29008
		// (get) Token: 0x0601C06F RID: 114799 RVA: 0x00294045 File Offset: 0x00292245
		// (set) Token: 0x0601C070 RID: 114800 RVA: 0x0029405E File Offset: 0x0029225E
		public unsafe bool bOverride_SoundPower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SoundPower) & FWindSetting.__PropertyMask_bOverride_SoundPower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SoundPower) = ((*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SoundPower) & ~FWindSetting.__PropertyMask_bOverride_SoundPower) | (value ? FWindSetting.__PropertyMask_bOverride_SoundPower : 0));
			}
		}

		// Token: 0x17007151 RID: 29009
		// (get) Token: 0x0601C071 RID: 114801 RVA: 0x0029408E File Offset: 0x0029228E
		// (set) Token: 0x0601C072 RID: 114802 RVA: 0x0029409E File Offset: 0x0029229E
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindSpeed) = value;
			}
		}

		// Token: 0x17007152 RID: 29010
		// (get) Token: 0x0601C073 RID: 114803 RVA: 0x002940AF File Offset: 0x002922AF
		// (set) Token: 0x0601C074 RID: 114804 RVA: 0x002940C8 File Offset: 0x002922C8
		public unsafe bool bOverride_WindPower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindPower) & FWindSetting.__PropertyMask_bOverride_WindPower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindPower) = ((*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_WindPower) & ~FWindSetting.__PropertyMask_bOverride_WindPower) | (value ? FWindSetting.__PropertyMask_bOverride_WindPower : 0));
			}
		}

		// Token: 0x17007153 RID: 29011
		// (get) Token: 0x0601C075 RID: 114805 RVA: 0x002940F8 File Offset: 0x002922F8
		// (set) Token: 0x0601C076 RID: 114806 RVA: 0x00294108 File Offset: 0x00292308
		public unsafe float WindPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_WindPower) = value;
			}
		}

		// Token: 0x17007154 RID: 29012
		// (get) Token: 0x0601C077 RID: 114807 RVA: 0x00294119 File Offset: 0x00292319
		// (set) Token: 0x0601C078 RID: 114808 RVA: 0x00294132 File Offset: 0x00292332
		public unsafe bool bOverride_SkyWind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SkyWind) & FWindSetting.__PropertyMask_bOverride_SkyWind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SkyWind) = ((*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_bOverride_SkyWind) & ~FWindSetting.__PropertyMask_bOverride_SkyWind) | (value ? FWindSetting.__PropertyMask_bOverride_SkyWind : 0));
			}
		}

		// Token: 0x17007155 RID: 29013
		// (get) Token: 0x0601C079 RID: 114809 RVA: 0x00294162 File Offset: 0x00292362
		// (set) Token: 0x0601C07A RID: 114810 RVA: 0x00294176 File Offset: 0x00292376
		public unsafe FVector2D SkyWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_SkyWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_SkyWind) = value;
			}
		}

		// Token: 0x17007156 RID: 29014
		// (get) Token: 0x0601C07B RID: 114811 RVA: 0x0029418B File Offset: 0x0029238B
		// (set) Token: 0x0601C07C RID: 114812 RVA: 0x0029419B File Offset: 0x0029239B
		public unsafe float SoundPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_SoundPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindSetting.__PropertyOffset_SoundPower) = value;
			}
		}

		// Token: 0x0601C07D RID: 114813 RVA: 0x002941AC File Offset: 0x002923AC
		public FWindSetting()
		{
		}

		// Token: 0x0601C07E RID: 114814 RVA: 0x002941B4 File Offset: 0x002923B4
		public FWindSetting(bool bOverride_WindDirection, float WindDirection, bool bOverride_WindSpeed, bool bOverride_SoundPower, float WindSpeed, bool bOverride_WindPower, float WindPower, bool bOverride_SkyWind, FVector2D SkyWind, float SoundPower)
		{
			this.bOverride_WindDirection = bOverride_WindDirection;
			this.WindDirection = WindDirection;
			this.bOverride_WindSpeed = bOverride_WindSpeed;
			this.bOverride_SoundPower = bOverride_SoundPower;
			this.WindSpeed = WindSpeed;
			this.bOverride_WindPower = bOverride_WindPower;
			this.WindPower = WindPower;
			this.bOverride_SkyWind = bOverride_SkyWind;
			this.SkyWind = SkyWind;
			this.SoundPower = SoundPower;
		}

		// Token: 0x0601C07F RID: 114815 RVA: 0x00294214 File Offset: 0x00292414
		protected override IntPtr GetUStructPtr()
		{
			return FWindSetting.StaticStruct();
		}

		// Token: 0x0601C080 RID: 114816 RVA: 0x00294220 File Offset: 0x00292420
		[NullableContext(2)]
		public FWindSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C081 RID: 114817 RVA: 0x0029422A File Offset: 0x0029242A
		public FWindSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C082 RID: 114818 RVA: 0x00294235 File Offset: 0x00292435
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWindSetting(Pointer, false, true);
		}

		// Token: 0x0601C083 RID: 114819 RVA: 0x0029423F File Offset: 0x0029243F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWindSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0DA RID: 61658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.WindSetting";

		// Token: 0x0400F0DB RID: 61659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0DC RID: 61660
		internal static int __PropertyOffset_bOverride_WindDirection;

		// Token: 0x0400F0DD RID: 61661
		internal static byte __PropertyMask_bOverride_WindDirection;

		// Token: 0x0400F0DE RID: 61662
		internal static int __PropertyOffset_WindDirection;

		// Token: 0x0400F0DF RID: 61663
		internal static int __PropertyOffset_bOverride_WindSpeed;

		// Token: 0x0400F0E0 RID: 61664
		internal static byte __PropertyMask_bOverride_WindSpeed;

		// Token: 0x0400F0E1 RID: 61665
		internal static int __PropertyOffset_bOverride_SoundPower;

		// Token: 0x0400F0E2 RID: 61666
		internal static byte __PropertyMask_bOverride_SoundPower;

		// Token: 0x0400F0E3 RID: 61667
		internal static int __PropertyOffset_WindSpeed;

		// Token: 0x0400F0E4 RID: 61668
		internal static int __PropertyOffset_bOverride_WindPower;

		// Token: 0x0400F0E5 RID: 61669
		internal static byte __PropertyMask_bOverride_WindPower;

		// Token: 0x0400F0E6 RID: 61670
		internal static int __PropertyOffset_WindPower;

		// Token: 0x0400F0E7 RID: 61671
		internal static int __PropertyOffset_bOverride_SkyWind;

		// Token: 0x0400F0E8 RID: 61672
		internal static byte __PropertyMask_bOverride_SkyWind;

		// Token: 0x0400F0E9 RID: 61673
		internal static int __PropertyOffset_SkyWind;

		// Token: 0x0400F0EA RID: 61674
		internal static int __PropertyOffset_SoundPower;
	}
}
