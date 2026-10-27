using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B59 RID: 7001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample")]
	[UnrealStructLayout(5784, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5784)]
	public class FKuroMaterialControllerParam_TextureSample : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A813 RID: 108563 RVA: 0x00271312 File Offset: 0x0026F512
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_TextureSample._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_TextureSample._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample", ref FKuroMaterialControllerParam_TextureSample._ScriptStructPtr);
		}

		// Token: 0x17006A89 RID: 27273
		// (get) Token: 0x0601A814 RID: 108564 RVA: 0x00271336 File Offset: 0x0026F536
		// (set) Token: 0x0601A815 RID: 108565 RVA: 0x0027134A File Offset: 0x0026F54A
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSample.__PropertyOffset_MaskTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSample.__PropertyOffset_MaskTexture, value);
			}
		}

		// Token: 0x17006A8A RID: 27274
		// (get) Token: 0x0601A816 RID: 108566 RVA: 0x00271360 File Offset: 0x0026F560
		// (set) Token: 0x0601A817 RID: 108567 RVA: 0x002713A3 File Offset: 0x0026F5A3
		public FKuroMaterialCurveColorGroup TextureScaleAndOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._TextureScaleAndOffset) == null)
				{
					result = (this._TextureScaleAndOffset = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureScaleAndOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureScaleAndOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A8B RID: 27275
		// (get) Token: 0x0601A818 RID: 108568 RVA: 0x002713C4 File Offset: 0x0026F5C4
		// (set) Token: 0x0601A819 RID: 108569 RVA: 0x00271407 File Offset: 0x0026F607
		public FKuroMaterialCurveColorGroup TextureSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._TextureSpeed) == null)
				{
					result = (this._TextureSpeed = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A8C RID: 27276
		// (get) Token: 0x0601A81A RID: 108570 RVA: 0x00271428 File Offset: 0x0026F628
		// (set) Token: 0x0601A81B RID: 108571 RVA: 0x0027146B File Offset: 0x0026F66B
		public FKuroMaterialCurveColorGroup TextureColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._TextureColorTint) == null)
				{
					result = (this._TextureColorTint = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureColorTint, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A8D RID: 27277
		// (get) Token: 0x0601A81C RID: 108572 RVA: 0x0027148C File Offset: 0x0026F68C
		// (set) Token: 0x0601A81D RID: 108573 RVA: 0x002714CF File Offset: 0x0026F6CF
		public FKuroMaterialCurveFloatGroup Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_Rotation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A8E RID: 27278
		// (get) Token: 0x0601A81E RID: 108574 RVA: 0x002714F0 File Offset: 0x0026F6F0
		// (set) Token: 0x0601A81F RID: 108575 RVA: 0x00271500 File Offset: 0x0026F700
		public unsafe bool bUseAlphaToMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_bUseAlphaToMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_bUseAlphaToMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A8F RID: 27279
		// (get) Token: 0x0601A820 RID: 108576 RVA: 0x00271514 File Offset: 0x0026F714
		// (set) Token: 0x0601A821 RID: 108577 RVA: 0x00271557 File Offset: 0x0026F757
		public FKuroMaterialCurveFloatGroup TextureMaskRange
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._TextureMaskRange) == null)
				{
					result = (this._TextureMaskRange = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureMaskRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_TextureMaskRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A90 RID: 27280
		// (get) Token: 0x0601A822 RID: 108578 RVA: 0x00271578 File Offset: 0x0026F778
		// (set) Token: 0x0601A823 RID: 108579 RVA: 0x00271588 File Offset: 0x0026F788
		public unsafe ECharacterControllerUVSwitch UvSelection
		{
			get
			{
				return (ECharacterControllerUVSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_UvSelection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_UvSelection) = (byte)value;
			}
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x00271599 File Offset: 0x0026F799
		public FKuroMaterialControllerParam_TextureSample()
		{
		}

		// Token: 0x0601A825 RID: 108581 RVA: 0x002715A4 File Offset: 0x0026F7A4
		public FKuroMaterialControllerParam_TextureSample(UTexture2D MaskTexture, FKuroMaterialCurveColorGroup TextureScaleAndOffset, FKuroMaterialCurveColorGroup TextureSpeed, FKuroMaterialCurveColorGroup TextureColorTint, FKuroMaterialCurveFloatGroup Rotation, bool bUseAlphaToMask, FKuroMaterialCurveFloatGroup TextureMaskRange, ECharacterControllerUVSwitch UvSelection)
		{
			this.MaskTexture = MaskTexture;
			this.TextureScaleAndOffset = TextureScaleAndOffset;
			this.TextureSpeed = TextureSpeed;
			this.TextureColorTint = TextureColorTint;
			this.Rotation = Rotation;
			this.bUseAlphaToMask = bUseAlphaToMask;
			this.TextureMaskRange = TextureMaskRange;
			this.UvSelection = UvSelection;
		}

		// Token: 0x0601A826 RID: 108582 RVA: 0x002715F4 File Offset: 0x0026F7F4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_TextureSample.StaticStruct();
		}

		// Token: 0x0601A827 RID: 108583 RVA: 0x00271600 File Offset: 0x0026F800
		[NullableContext(2)]
		public FKuroMaterialControllerParam_TextureSample(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A828 RID: 108584 RVA: 0x0027160A File Offset: 0x0026F80A
		public FKuroMaterialControllerParam_TextureSample(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x00271615 File Offset: 0x0026F815
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_TextureSample(Pointer, false, true);
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x0027161F File Offset: 0x0026F81F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_TextureSample(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5B1 RID: 58801
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample";

		// Token: 0x0400E5B2 RID: 58802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5B3 RID: 58803
		internal static int __PropertyOffset_MaskTexture;

		// Token: 0x0400E5B4 RID: 58804
		internal static int __PropertyOffset_TextureScaleAndOffset;

		// Token: 0x0400E5B5 RID: 58805
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _TextureScaleAndOffset;

		// Token: 0x0400E5B6 RID: 58806
		internal static int __PropertyOffset_TextureSpeed;

		// Token: 0x0400E5B7 RID: 58807
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _TextureSpeed;

		// Token: 0x0400E5B8 RID: 58808
		internal static int __PropertyOffset_TextureColorTint;

		// Token: 0x0400E5B9 RID: 58809
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _TextureColorTint;

		// Token: 0x0400E5BA RID: 58810
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400E5BB RID: 58811
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _Rotation;

		// Token: 0x0400E5BC RID: 58812
		internal static int __PropertyOffset_bUseAlphaToMask;

		// Token: 0x0400E5BD RID: 58813
		internal static int __PropertyOffset_TextureMaskRange;

		// Token: 0x0400E5BE RID: 58814
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _TextureMaskRange;

		// Token: 0x0400E5BF RID: 58815
		internal static int __PropertyOffset_UvSelection;
	}
}
