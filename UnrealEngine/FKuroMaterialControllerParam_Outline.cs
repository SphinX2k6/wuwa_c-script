using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B49 RID: 6985
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Outline")]
	[UnrealStructLayout(2504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2504)]
	public class FKuroMaterialControllerParam_Outline : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A727 RID: 108327 RVA: 0x0026FD75 File Offset: 0x0026DF75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Outline._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Outline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Outline", ref FKuroMaterialControllerParam_Outline._ScriptStructPtr);
		}

		// Token: 0x17006A53 RID: 27219
		// (get) Token: 0x0601A728 RID: 108328 RVA: 0x0026FD99 File Offset: 0x0026DF99
		// (set) Token: 0x0601A729 RID: 108329 RVA: 0x0026FDA9 File Offset: 0x0026DFA9
		public unsafe bool bOutlineUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_bOutlineUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_bOutlineUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A54 RID: 27220
		// (get) Token: 0x0601A72A RID: 108330 RVA: 0x0026FDBA File Offset: 0x0026DFBA
		// (set) Token: 0x0601A72B RID: 108331 RVA: 0x0026FDCA File Offset: 0x0026DFCA
		public unsafe bool bUseOuterOutlineEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_bUseOuterOutlineEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_bUseOuterOutlineEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A55 RID: 27221
		// (get) Token: 0x0601A72C RID: 108332 RVA: 0x0026FDDC File Offset: 0x0026DFDC
		// (set) Token: 0x0601A72D RID: 108333 RVA: 0x0026FE1F File Offset: 0x0026E01F
		public FKuroMaterialCurveFloatGroup OutlineWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._OutlineWidth) == null)
				{
					result = (this._OutlineWidth = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineWidth, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A56 RID: 27222
		// (get) Token: 0x0601A72E RID: 108334 RVA: 0x0026FE40 File Offset: 0x0026E040
		// (set) Token: 0x0601A72F RID: 108335 RVA: 0x0026FE83 File Offset: 0x0026E083
		public FKuroMaterialCurveColorGroup OutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._OutlineColor) == null)
				{
					result = (this._OutlineColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A57 RID: 27223
		// (get) Token: 0x0601A730 RID: 108336 RVA: 0x0026FEA4 File Offset: 0x0026E0A4
		// (set) Token: 0x0601A731 RID: 108337 RVA: 0x0026FEE7 File Offset: 0x0026E0E7
		public FKuroMaterialCurveFloatGroup OutlineIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._OutlineIntensity) == null)
				{
					result = (this._OutlineIntensity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineIntensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Outline.__PropertyOffset_OutlineIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A732 RID: 108338 RVA: 0x0026FF08 File Offset: 0x0026E108
		public FKuroMaterialControllerParam_Outline()
		{
		}

		// Token: 0x0601A733 RID: 108339 RVA: 0x0026FF10 File Offset: 0x0026E110
		public FKuroMaterialControllerParam_Outline(bool bOutlineUseTex, bool bUseOuterOutlineEffect, FKuroMaterialCurveFloatGroup OutlineWidth, FKuroMaterialCurveColorGroup OutlineColor, FKuroMaterialCurveFloatGroup OutlineIntensity)
		{
			this.bOutlineUseTex = bOutlineUseTex;
			this.bUseOuterOutlineEffect = bUseOuterOutlineEffect;
			this.OutlineWidth = OutlineWidth;
			this.OutlineColor = OutlineColor;
			this.OutlineIntensity = OutlineIntensity;
		}

		// Token: 0x0601A734 RID: 108340 RVA: 0x0026FF3D File Offset: 0x0026E13D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Outline.StaticStruct();
		}

		// Token: 0x0601A735 RID: 108341 RVA: 0x0026FF49 File Offset: 0x0026E149
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Outline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A736 RID: 108342 RVA: 0x0026FF53 File Offset: 0x0026E153
		public FKuroMaterialControllerParam_Outline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A737 RID: 108343 RVA: 0x0026FF5E File Offset: 0x0026E15E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Outline(Pointer, false, true);
		}

		// Token: 0x0601A738 RID: 108344 RVA: 0x0026FF68 File Offset: 0x0026E168
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Outline(Pointer, MemoryOwner);
		}

		// Token: 0x0400E542 RID: 58690
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Outline";

		// Token: 0x0400E543 RID: 58691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E544 RID: 58692
		internal static int __PropertyOffset_bOutlineUseTex;

		// Token: 0x0400E545 RID: 58693
		internal static int __PropertyOffset_bUseOuterOutlineEffect;

		// Token: 0x0400E546 RID: 58694
		internal static int __PropertyOffset_OutlineWidth;

		// Token: 0x0400E547 RID: 58695
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _OutlineWidth;

		// Token: 0x0400E548 RID: 58696
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x0400E549 RID: 58697
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _OutlineColor;

		// Token: 0x0400E54A RID: 58698
		internal static int __PropertyOffset_OutlineIntensity;

		// Token: 0x0400E54B RID: 58699
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _OutlineIntensity;
	}
}
