using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B7A RID: 7034
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMultipleLayerSkySetting")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FKuroMultipleLayerSkySetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AB12 RID: 109330 RVA: 0x0027541B File Offset: 0x0027361B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMultipleLayerSkySetting._ScriptStructPtr != 0) ? FKuroMultipleLayerSkySetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMultipleLayerSkySetting", ref FKuroMultipleLayerSkySetting._ScriptStructPtr);
		}

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x0601AB13 RID: 109331 RVA: 0x0027543F File Offset: 0x0027363F
		// (set) Token: 0x0601AB14 RID: 109332 RVA: 0x00275458 File Offset: 0x00273658
		public unsafe bool bOverride_Layer1BaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer1BaseColor) & FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer1BaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer1BaseColor) = ((*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer1BaseColor) & ~FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer1BaseColor) | (value ? FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer1BaseColor : 0));
			}
		}

		// Token: 0x17006B5A RID: 27482
		// (get) Token: 0x0601AB15 RID: 109333 RVA: 0x00275488 File Offset: 0x00273688
		// (set) Token: 0x0601AB16 RID: 109334 RVA: 0x002754A1 File Offset: 0x002736A1
		public unsafe bool bOverride_Layer2BaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer2BaseColor) & FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer2BaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer2BaseColor) = ((*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer2BaseColor) & ~FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer2BaseColor) | (value ? FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer2BaseColor : 0));
			}
		}

		// Token: 0x17006B5B RID: 27483
		// (get) Token: 0x0601AB17 RID: 109335 RVA: 0x002754D1 File Offset: 0x002736D1
		// (set) Token: 0x0601AB18 RID: 109336 RVA: 0x002754EA File Offset: 0x002736EA
		public unsafe bool bOverride_Layer3BaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer3BaseColor) & FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer3BaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer3BaseColor) = ((*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_bOverride_Layer3BaseColor) & ~FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer3BaseColor) | (value ? FKuroMultipleLayerSkySetting.__PropertyMask_bOverride_Layer3BaseColor : 0));
			}
		}

		// Token: 0x17006B5C RID: 27484
		// (get) Token: 0x0601AB19 RID: 109337 RVA: 0x0027551A File Offset: 0x0027371A
		// (set) Token: 0x0601AB1A RID: 109338 RVA: 0x0027552E File Offset: 0x0027372E
		public unsafe FLinearColor Layer1BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer1BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer1BaseColor) = value;
			}
		}

		// Token: 0x17006B5D RID: 27485
		// (get) Token: 0x0601AB1B RID: 109339 RVA: 0x00275543 File Offset: 0x00273743
		// (set) Token: 0x0601AB1C RID: 109340 RVA: 0x00275557 File Offset: 0x00273757
		public unsafe FLinearColor Layer2BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer2BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer2BaseColor) = value;
			}
		}

		// Token: 0x17006B5E RID: 27486
		// (get) Token: 0x0601AB1D RID: 109341 RVA: 0x0027556C File Offset: 0x0027376C
		// (set) Token: 0x0601AB1E RID: 109342 RVA: 0x00275580 File Offset: 0x00273780
		public unsafe FLinearColor Layer3BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer3BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMultipleLayerSkySetting.__PropertyOffset_Layer3BaseColor) = value;
			}
		}

		// Token: 0x0601AB1F RID: 109343 RVA: 0x00275595 File Offset: 0x00273795
		public FKuroMultipleLayerSkySetting()
		{
		}

		// Token: 0x0601AB20 RID: 109344 RVA: 0x0027559D File Offset: 0x0027379D
		public FKuroMultipleLayerSkySetting(bool bOverride_Layer1BaseColor, bool bOverride_Layer2BaseColor, bool bOverride_Layer3BaseColor, FLinearColor Layer1BaseColor, FLinearColor Layer2BaseColor, FLinearColor Layer3BaseColor)
		{
			this.bOverride_Layer1BaseColor = bOverride_Layer1BaseColor;
			this.bOverride_Layer2BaseColor = bOverride_Layer2BaseColor;
			this.bOverride_Layer3BaseColor = bOverride_Layer3BaseColor;
			this.Layer1BaseColor = Layer1BaseColor;
			this.Layer2BaseColor = Layer2BaseColor;
			this.Layer3BaseColor = Layer3BaseColor;
		}

		// Token: 0x0601AB21 RID: 109345 RVA: 0x002755D2 File Offset: 0x002737D2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMultipleLayerSkySetting.StaticStruct();
		}

		// Token: 0x0601AB22 RID: 109346 RVA: 0x002755DE File Offset: 0x002737DE
		[NullableContext(2)]
		public FKuroMultipleLayerSkySetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AB23 RID: 109347 RVA: 0x002755E8 File Offset: 0x002737E8
		public FKuroMultipleLayerSkySetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AB24 RID: 109348 RVA: 0x002755F3 File Offset: 0x002737F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMultipleLayerSkySetting(Pointer, false, true);
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x002755FD File Offset: 0x002737FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMultipleLayerSkySetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E709 RID: 59145
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMultipleLayerSkySetting";

		// Token: 0x0400E70A RID: 59146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E70B RID: 59147
		internal static int __PropertyOffset_bOverride_Layer1BaseColor;

		// Token: 0x0400E70C RID: 59148
		internal static byte __PropertyMask_bOverride_Layer1BaseColor;

		// Token: 0x0400E70D RID: 59149
		internal static int __PropertyOffset_bOverride_Layer2BaseColor;

		// Token: 0x0400E70E RID: 59150
		internal static byte __PropertyMask_bOverride_Layer2BaseColor;

		// Token: 0x0400E70F RID: 59151
		internal static int __PropertyOffset_bOverride_Layer3BaseColor;

		// Token: 0x0400E710 RID: 59152
		internal static byte __PropertyMask_bOverride_Layer3BaseColor;

		// Token: 0x0400E711 RID: 59153
		internal static int __PropertyOffset_Layer1BaseColor;

		// Token: 0x0400E712 RID: 59154
		internal static int __PropertyOffset_Layer2BaseColor;

		// Token: 0x0400E713 RID: 59155
		internal static int __PropertyOffset_Layer3BaseColor;
	}
}
