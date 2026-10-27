using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B4F RID: 6991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColor")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FKuroMaterialControllerParam_SI_BaseColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A783 RID: 108419 RVA: 0x0027054F File Offset: 0x0026E74F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_BaseColor._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_BaseColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColor", ref FKuroMaterialControllerParam_SI_BaseColor._ScriptStructPtr);
		}

		// Token: 0x17006A69 RID: 27241
		// (get) Token: 0x0601A784 RID: 108420 RVA: 0x00270574 File Offset: 0x0026E774
		// (set) Token: 0x0601A785 RID: 108421 RVA: 0x002705B7 File Offset: 0x0026E7B7
		public FKuroMaterialCurveFloatGroup_SI BaseColorScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._BaseColorScale) == null)
				{
					result = (this._BaseColorScale = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColor.__PropertyOffset_BaseColorScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColor.__PropertyOffset_BaseColorScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A6A RID: 27242
		// (get) Token: 0x0601A786 RID: 108422 RVA: 0x002705D8 File Offset: 0x0026E7D8
		// (set) Token: 0x0601A787 RID: 108423 RVA: 0x0027061B File Offset: 0x0026E81B
		public FKuroMaterialCurveColorGroup_SI BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColor.__PropertyOffset_BaseColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColor.__PropertyOffset_BaseColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A788 RID: 108424 RVA: 0x0027063C File Offset: 0x0026E83C
		public FKuroMaterialControllerParam_SI_BaseColor()
		{
		}

		// Token: 0x0601A789 RID: 108425 RVA: 0x00270644 File Offset: 0x0026E844
		public FKuroMaterialControllerParam_SI_BaseColor(FKuroMaterialCurveFloatGroup_SI BaseColorScale, FKuroMaterialCurveColorGroup_SI BaseColor)
		{
			this.BaseColorScale = BaseColorScale;
			this.BaseColor = BaseColor;
		}

		// Token: 0x0601A78A RID: 108426 RVA: 0x0027065A File Offset: 0x0026E85A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_BaseColor.StaticStruct();
		}

		// Token: 0x0601A78B RID: 108427 RVA: 0x00270666 File Offset: 0x0026E866
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_BaseColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A78C RID: 108428 RVA: 0x00270670 File Offset: 0x0026E870
		public FKuroMaterialControllerParam_SI_BaseColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A78D RID: 108429 RVA: 0x0027067B File Offset: 0x0026E87B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_BaseColor(Pointer, false, true);
		}

		// Token: 0x0601A78E RID: 108430 RVA: 0x00270685 File Offset: 0x0026E885
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_BaseColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400E56B RID: 58731
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColor";

		// Token: 0x0400E56C RID: 58732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E56D RID: 58733
		internal static int __PropertyOffset_BaseColorScale;

		// Token: 0x0400E56E RID: 58734
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _BaseColorScale;

		// Token: 0x0400E56F RID: 58735
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0400E570 RID: 58736
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _BaseColor;
	}
}
