using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B53 RID: 6995
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Dissolve")]
	[UnrealStructLayout(2208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2208)]
	public class FKuroMaterialControllerParam_SI_Dissolve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7B3 RID: 108467 RVA: 0x00270987 File Offset: 0x0026EB87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_Dissolve._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_Dissolve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Dissolve", ref FKuroMaterialControllerParam_SI_Dissolve._ScriptStructPtr);
		}

		// Token: 0x17006A71 RID: 27249
		// (get) Token: 0x0601A7B4 RID: 108468 RVA: 0x002709AC File Offset: 0x0026EBAC
		// (set) Token: 0x0601A7B5 RID: 108469 RVA: 0x002709EF File Offset: 0x0026EBEF
		public FKuroMaterialCurveFloatGroup_SI DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveProgress, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A72 RID: 27250
		// (get) Token: 0x0601A7B6 RID: 108470 RVA: 0x00270A10 File Offset: 0x0026EC10
		// (set) Token: 0x0601A7B7 RID: 108471 RVA: 0x00270A53 File Offset: 0x0026EC53
		public FKuroMaterialCurveFloatGroup_SI DissolveEdageWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._DissolveEdageWidth) == null)
				{
					result = (this._DissolveEdageWidth = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageWidth, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A73 RID: 27251
		// (get) Token: 0x0601A7B8 RID: 108472 RVA: 0x00270A74 File Offset: 0x0026EC74
		// (set) Token: 0x0601A7B9 RID: 108473 RVA: 0x00270AB7 File Offset: 0x0026ECB7
		public FKuroMaterialCurveFloatGroup_SI DissolveEdageStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._DissolveEdageStrength) == null)
				{
					result = (this._DissolveEdageStrength = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageStrength, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A74 RID: 27252
		// (get) Token: 0x0601A7BA RID: 108474 RVA: 0x00270AD8 File Offset: 0x0026ECD8
		// (set) Token: 0x0601A7BB RID: 108475 RVA: 0x00270B1B File Offset: 0x0026ED1B
		public FKuroMaterialCurveFloatGroup_SI DissolveAdjustment
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._DissolveAdjustment) == null)
				{
					result = (this._DissolveAdjustment = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveAdjustment, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveAdjustment, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A75 RID: 27253
		// (get) Token: 0x0601A7BC RID: 108476 RVA: 0x00270B3C File Offset: 0x0026ED3C
		// (set) Token: 0x0601A7BD RID: 108477 RVA: 0x00270B7F File Offset: 0x0026ED7F
		public FKuroMaterialCurveColorGroup_SI DissolveEdageColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._DissolveEdageColor) == null)
				{
					result = (this._DissolveEdageColor = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveEdageColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A76 RID: 27254
		// (get) Token: 0x0601A7BE RID: 108478 RVA: 0x00270BA0 File Offset: 0x0026EDA0
		// (set) Token: 0x0601A7BF RID: 108479 RVA: 0x00270BE3 File Offset: 0x0026EDE3
		public FKuroMaterialCurveColorGroup_SI DissolveTexScaleOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._DissolveTexScaleOffset) == null)
				{
					result = (this._DissolveTexScaleOffset = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveTexScaleOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveTexScaleOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A77 RID: 27255
		// (get) Token: 0x0601A7C0 RID: 108480 RVA: 0x00270C04 File Offset: 0x0026EE04
		// (set) Token: 0x0601A7C1 RID: 108481 RVA: 0x00270C47 File Offset: 0x0026EE47
		public FKuroMaterialCurveColorGroup_SI DissolveTexSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._DissolveTexSpeed) == null)
				{
					result = (this._DissolveTexSpeed = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveTexSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Dissolve.__PropertyOffset_DissolveTexSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A7C2 RID: 108482 RVA: 0x00270C68 File Offset: 0x0026EE68
		public FKuroMaterialControllerParam_SI_Dissolve()
		{
		}

		// Token: 0x0601A7C3 RID: 108483 RVA: 0x00270C70 File Offset: 0x0026EE70
		public FKuroMaterialControllerParam_SI_Dissolve(FKuroMaterialCurveFloatGroup_SI DissolveProgress, FKuroMaterialCurveFloatGroup_SI DissolveEdageWidth, FKuroMaterialCurveFloatGroup_SI DissolveEdageStrength, FKuroMaterialCurveFloatGroup_SI DissolveAdjustment, FKuroMaterialCurveColorGroup_SI DissolveEdageColor, FKuroMaterialCurveColorGroup_SI DissolveTexScaleOffset, FKuroMaterialCurveColorGroup_SI DissolveTexSpeed)
		{
			this.DissolveProgress = DissolveProgress;
			this.DissolveEdageWidth = DissolveEdageWidth;
			this.DissolveEdageStrength = DissolveEdageStrength;
			this.DissolveAdjustment = DissolveAdjustment;
			this.DissolveEdageColor = DissolveEdageColor;
			this.DissolveTexScaleOffset = DissolveTexScaleOffset;
			this.DissolveTexSpeed = DissolveTexSpeed;
		}

		// Token: 0x0601A7C4 RID: 108484 RVA: 0x00270CAD File Offset: 0x0026EEAD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_Dissolve.StaticStruct();
		}

		// Token: 0x0601A7C5 RID: 108485 RVA: 0x00270CB9 File Offset: 0x0026EEB9
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_Dissolve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7C6 RID: 108486 RVA: 0x00270CC3 File Offset: 0x0026EEC3
		public FKuroMaterialControllerParam_SI_Dissolve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7C7 RID: 108487 RVA: 0x00270CCE File Offset: 0x0026EECE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_Dissolve(Pointer, false, true);
		}

		// Token: 0x0601A7C8 RID: 108488 RVA: 0x00270CD8 File Offset: 0x0026EED8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_Dissolve(Pointer, MemoryOwner);
		}

		// Token: 0x0400E581 RID: 58753
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Dissolve";

		// Token: 0x0400E582 RID: 58754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E583 RID: 58755
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400E584 RID: 58756
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _DissolveProgress;

		// Token: 0x0400E585 RID: 58757
		internal static int __PropertyOffset_DissolveEdageWidth;

		// Token: 0x0400E586 RID: 58758
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _DissolveEdageWidth;

		// Token: 0x0400E587 RID: 58759
		internal static int __PropertyOffset_DissolveEdageStrength;

		// Token: 0x0400E588 RID: 58760
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _DissolveEdageStrength;

		// Token: 0x0400E589 RID: 58761
		internal static int __PropertyOffset_DissolveAdjustment;

		// Token: 0x0400E58A RID: 58762
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _DissolveAdjustment;

		// Token: 0x0400E58B RID: 58763
		internal static int __PropertyOffset_DissolveEdageColor;

		// Token: 0x0400E58C RID: 58764
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _DissolveEdageColor;

		// Token: 0x0400E58D RID: 58765
		internal static int __PropertyOffset_DissolveTexScaleOffset;

		// Token: 0x0400E58E RID: 58766
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _DissolveTexScaleOffset;

		// Token: 0x0400E58F RID: 58767
		internal static int __PropertyOffset_DissolveTexSpeed;

		// Token: 0x0400E590 RID: 58768
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _DissolveTexSpeed;
	}
}
