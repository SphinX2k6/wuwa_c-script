using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B4C RID: 6988
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_RimConst")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroMaterialControllerParam_RimConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A75D RID: 108381 RVA: 0x002702A7 File Offset: 0x0026E4A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_RimConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_RimConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_RimConst", ref FKuroMaterialControllerParam_RimConst._ScriptStructPtr);
		}

		// Token: 0x17006A62 RID: 27234
		// (get) Token: 0x0601A75E RID: 108382 RVA: 0x002702CB File Offset: 0x0026E4CB
		// (set) Token: 0x0601A75F RID: 108383 RVA: 0x002702DB File Offset: 0x0026E4DB
		public unsafe float RimRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimRange) = value;
			}
		}

		// Token: 0x17006A63 RID: 27235
		// (get) Token: 0x0601A760 RID: 108384 RVA: 0x002702EC File Offset: 0x0026E4EC
		// (set) Token: 0x0601A761 RID: 108385 RVA: 0x00270300 File Offset: 0x0026E500
		public unsafe FLinearColor RimColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimColor) = value;
			}
		}

		// Token: 0x17006A64 RID: 27236
		// (get) Token: 0x0601A762 RID: 108386 RVA: 0x00270315 File Offset: 0x0026E515
		// (set) Token: 0x0601A763 RID: 108387 RVA: 0x00270325 File Offset: 0x0026E525
		public unsafe float RimIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimIntensity) = value;
			}
		}

		// Token: 0x17006A65 RID: 27237
		// (get) Token: 0x0601A764 RID: 108388 RVA: 0x00270336 File Offset: 0x0026E536
		// (set) Token: 0x0601A765 RID: 108389 RVA: 0x00270346 File Offset: 0x0026E546
		public unsafe bool bRimUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_bRimUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_bRimUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A66 RID: 27238
		// (get) Token: 0x0601A766 RID: 108390 RVA: 0x00270357 File Offset: 0x0026E557
		// (set) Token: 0x0601A767 RID: 108391 RVA: 0x00270367 File Offset: 0x0026E567
		public unsafe EKuroCharacterControllerChannelSwitch RimChannel
		{
			get
			{
				return (EKuroCharacterControllerChannelSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_RimConst.__PropertyOffset_RimChannel) = (byte)value;
			}
		}

		// Token: 0x0601A768 RID: 108392 RVA: 0x00270378 File Offset: 0x0026E578
		public FKuroMaterialControllerParam_RimConst()
		{
		}

		// Token: 0x0601A769 RID: 108393 RVA: 0x00270380 File Offset: 0x0026E580
		public FKuroMaterialControllerParam_RimConst(float RimRange, FLinearColor RimColor, float RimIntensity, bool bRimUseTex, EKuroCharacterControllerChannelSwitch RimChannel)
		{
			this.RimRange = RimRange;
			this.RimColor = RimColor;
			this.RimIntensity = RimIntensity;
			this.bRimUseTex = bRimUseTex;
			this.RimChannel = RimChannel;
		}

		// Token: 0x0601A76A RID: 108394 RVA: 0x002703AD File Offset: 0x0026E5AD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_RimConst.StaticStruct();
		}

		// Token: 0x0601A76B RID: 108395 RVA: 0x002703B9 File Offset: 0x0026E5B9
		[NullableContext(2)]
		public FKuroMaterialControllerParam_RimConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A76C RID: 108396 RVA: 0x002703C3 File Offset: 0x0026E5C3
		public FKuroMaterialControllerParam_RimConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A76D RID: 108397 RVA: 0x002703CE File Offset: 0x0026E5CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_RimConst(Pointer, false, true);
		}

		// Token: 0x0601A76E RID: 108398 RVA: 0x002703D8 File Offset: 0x0026E5D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_RimConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E55D RID: 58717
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_RimConst";

		// Token: 0x0400E55E RID: 58718
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E55F RID: 58719
		internal static int __PropertyOffset_RimRange;

		// Token: 0x0400E560 RID: 58720
		internal static int __PropertyOffset_RimColor;

		// Token: 0x0400E561 RID: 58721
		internal static int __PropertyOffset_RimIntensity;

		// Token: 0x0400E562 RID: 58722
		internal static int __PropertyOffset_bRimUseTex;

		// Token: 0x0400E563 RID: 58723
		internal static int __PropertyOffset_RimChannel;
	}
}
