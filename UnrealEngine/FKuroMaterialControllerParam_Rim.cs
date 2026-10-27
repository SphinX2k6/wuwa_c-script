using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B4B RID: 6987
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Rim")]
	[UnrealStructLayout(2504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2504)]
	public class FKuroMaterialControllerParam_Rim : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A74B RID: 108363 RVA: 0x002700AB File Offset: 0x0026E2AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Rim._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Rim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Rim", ref FKuroMaterialControllerParam_Rim._ScriptStructPtr);
		}

		// Token: 0x17006A5D RID: 27229
		// (get) Token: 0x0601A74C RID: 108364 RVA: 0x002700D0 File Offset: 0x0026E2D0
		// (set) Token: 0x0601A74D RID: 108365 RVA: 0x00270113 File Offset: 0x0026E313
		public FKuroMaterialCurveFloatGroup RimRange
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._RimRange) == null)
				{
					result = (this._RimRange = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A5E RID: 27230
		// (get) Token: 0x0601A74E RID: 108366 RVA: 0x00270134 File Offset: 0x0026E334
		// (set) Token: 0x0601A74F RID: 108367 RVA: 0x00270177 File Offset: 0x0026E377
		public FKuroMaterialCurveColorGroup RimColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._RimColor) == null)
				{
					result = (this._RimColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A5F RID: 27231
		// (get) Token: 0x0601A750 RID: 108368 RVA: 0x00270198 File Offset: 0x0026E398
		// (set) Token: 0x0601A751 RID: 108369 RVA: 0x002701DB File Offset: 0x0026E3DB
		public FKuroMaterialCurveFloatGroup RimIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._RimIntensity) == null)
				{
					result = (this._RimIntensity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimIntensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A60 RID: 27232
		// (get) Token: 0x0601A752 RID: 108370 RVA: 0x002701FC File Offset: 0x0026E3FC
		// (set) Token: 0x0601A753 RID: 108371 RVA: 0x0027020C File Offset: 0x0026E40C
		public unsafe bool bRimUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_bRimUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_bRimUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A61 RID: 27233
		// (get) Token: 0x0601A754 RID: 108372 RVA: 0x0027021D File Offset: 0x0026E41D
		// (set) Token: 0x0601A755 RID: 108373 RVA: 0x0027022D File Offset: 0x0026E42D
		public unsafe EKuroCharacterControllerChannelSwitch RimChannel
		{
			get
			{
				return (EKuroCharacterControllerChannelSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Rim.__PropertyOffset_RimChannel) = (byte)value;
			}
		}

		// Token: 0x0601A756 RID: 108374 RVA: 0x0027023E File Offset: 0x0026E43E
		public FKuroMaterialControllerParam_Rim()
		{
		}

		// Token: 0x0601A757 RID: 108375 RVA: 0x00270246 File Offset: 0x0026E446
		public FKuroMaterialControllerParam_Rim(FKuroMaterialCurveFloatGroup RimRange, FKuroMaterialCurveColorGroup RimColor, FKuroMaterialCurveFloatGroup RimIntensity, bool bRimUseTex, EKuroCharacterControllerChannelSwitch RimChannel)
		{
			this.RimRange = RimRange;
			this.RimColor = RimColor;
			this.RimIntensity = RimIntensity;
			this.bRimUseTex = bRimUseTex;
			this.RimChannel = RimChannel;
		}

		// Token: 0x0601A758 RID: 108376 RVA: 0x00270273 File Offset: 0x0026E473
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Rim.StaticStruct();
		}

		// Token: 0x0601A759 RID: 108377 RVA: 0x0027027F File Offset: 0x0026E47F
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Rim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A75A RID: 108378 RVA: 0x00270289 File Offset: 0x0026E489
		public FKuroMaterialControllerParam_Rim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A75B RID: 108379 RVA: 0x00270294 File Offset: 0x0026E494
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Rim(Pointer, false, true);
		}

		// Token: 0x0601A75C RID: 108380 RVA: 0x0027029E File Offset: 0x0026E49E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Rim(Pointer, MemoryOwner);
		}

		// Token: 0x0400E553 RID: 58707
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Rim";

		// Token: 0x0400E554 RID: 58708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E555 RID: 58709
		internal static int __PropertyOffset_RimRange;

		// Token: 0x0400E556 RID: 58710
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _RimRange;

		// Token: 0x0400E557 RID: 58711
		internal static int __PropertyOffset_RimColor;

		// Token: 0x0400E558 RID: 58712
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _RimColor;

		// Token: 0x0400E559 RID: 58713
		internal static int __PropertyOffset_RimIntensity;

		// Token: 0x0400E55A RID: 58714
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _RimIntensity;

		// Token: 0x0400E55B RID: 58715
		internal static int __PropertyOffset_bRimUseTex;

		// Token: 0x0400E55C RID: 58716
		internal static int __PropertyOffset_RimChannel;
	}
}
