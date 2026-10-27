using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B76 RID: 7030
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMountainSetting")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroMountainSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AA1B RID: 109083 RVA: 0x002742DC File Offset: 0x002724DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMountainSetting._ScriptStructPtr != 0) ? FKuroMountainSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMountainSetting", ref FKuroMountainSetting._ScriptStructPtr);
		}

		// Token: 0x17006AFF RID: 27391
		// (get) Token: 0x0601AA1C RID: 109084 RVA: 0x00274300 File Offset: 0x00272500
		// (set) Token: 0x0601AA1D RID: 109085 RVA: 0x00274319 File Offset: 0x00272519
		public unsafe bool bOverride_MountainFogColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainFogColor) & FKuroMountainSetting.__PropertyMask_bOverride_MountainFogColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainFogColor) = ((*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainFogColor) & ~FKuroMountainSetting.__PropertyMask_bOverride_MountainFogColor) | (value ? FKuroMountainSetting.__PropertyMask_bOverride_MountainFogColor : 0));
			}
		}

		// Token: 0x17006B00 RID: 27392
		// (get) Token: 0x0601AA1E RID: 109086 RVA: 0x00274349 File Offset: 0x00272549
		// (set) Token: 0x0601AA1F RID: 109087 RVA: 0x0027435D File Offset: 0x0027255D
		public unsafe FLinearColor MountainFogColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_MountainFogColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_MountainFogColor) = value;
			}
		}

		// Token: 0x17006B01 RID: 27393
		// (get) Token: 0x0601AA20 RID: 109088 RVA: 0x00274372 File Offset: 0x00272572
		// (set) Token: 0x0601AA21 RID: 109089 RVA: 0x0027438B File Offset: 0x0027258B
		public unsafe bool bOverride_MountainColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainColor) & FKuroMountainSetting.__PropertyMask_bOverride_MountainColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainColor) = ((*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_bOverride_MountainColor) & ~FKuroMountainSetting.__PropertyMask_bOverride_MountainColor) | (value ? FKuroMountainSetting.__PropertyMask_bOverride_MountainColor : 0));
			}
		}

		// Token: 0x17006B02 RID: 27394
		// (get) Token: 0x0601AA22 RID: 109090 RVA: 0x002743BB File Offset: 0x002725BB
		// (set) Token: 0x0601AA23 RID: 109091 RVA: 0x002743CF File Offset: 0x002725CF
		public unsafe FLinearColor MountainColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_MountainColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMountainSetting.__PropertyOffset_MountainColor) = value;
			}
		}

		// Token: 0x0601AA24 RID: 109092 RVA: 0x002743E4 File Offset: 0x002725E4
		public FKuroMountainSetting()
		{
		}

		// Token: 0x0601AA25 RID: 109093 RVA: 0x002743EC File Offset: 0x002725EC
		public FKuroMountainSetting(bool bOverride_MountainFogColor, FLinearColor MountainFogColor, bool bOverride_MountainColor, FLinearColor MountainColor)
		{
			this.bOverride_MountainFogColor = bOverride_MountainFogColor;
			this.MountainFogColor = MountainFogColor;
			this.bOverride_MountainColor = bOverride_MountainColor;
			this.MountainColor = MountainColor;
		}

		// Token: 0x0601AA26 RID: 109094 RVA: 0x00274411 File Offset: 0x00272611
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMountainSetting.StaticStruct();
		}

		// Token: 0x0601AA27 RID: 109095 RVA: 0x0027441D File Offset: 0x0027261D
		[NullableContext(2)]
		public FKuroMountainSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AA28 RID: 109096 RVA: 0x00274427 File Offset: 0x00272627
		public FKuroMountainSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AA29 RID: 109097 RVA: 0x00274432 File Offset: 0x00272632
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMountainSetting(Pointer, false, true);
		}

		// Token: 0x0601AA2A RID: 109098 RVA: 0x0027443C File Offset: 0x0027263C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMountainSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E69B RID: 59035
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMountainSetting";

		// Token: 0x0400E69C RID: 59036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E69D RID: 59037
		internal static int __PropertyOffset_bOverride_MountainFogColor;

		// Token: 0x0400E69E RID: 59038
		internal static byte __PropertyMask_bOverride_MountainFogColor;

		// Token: 0x0400E69F RID: 59039
		internal static int __PropertyOffset_MountainFogColor;

		// Token: 0x0400E6A0 RID: 59040
		internal static int __PropertyOffset_bOverride_MountainColor;

		// Token: 0x0400E6A1 RID: 59041
		internal static byte __PropertyMask_bOverride_MountainColor;

		// Token: 0x0400E6A2 RID: 59042
		internal static int __PropertyOffset_MountainColor;
	}
}
