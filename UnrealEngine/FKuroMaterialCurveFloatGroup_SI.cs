using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B63 RID: 7011
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup_SI")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroMaterialCurveFloatGroup_SI : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8A8 RID: 108712 RVA: 0x002722D9 File Offset: 0x002704D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCurveFloatGroup_SI._ScriptStructPtr != 0) ? FKuroMaterialCurveFloatGroup_SI._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup_SI", ref FKuroMaterialCurveFloatGroup_SI._ScriptStructPtr);
		}

		// Token: 0x17006AAC RID: 27308
		// (get) Token: 0x0601A8A9 RID: 108713 RVA: 0x00272300 File Offset: 0x00270500
		// (set) Token: 0x0601A8AA RID: 108714 RVA: 0x00272343 File Offset: 0x00270543
		public FKuroCurveFloat Curve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup_SI.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup_SI.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A8AB RID: 108715 RVA: 0x00272364 File Offset: 0x00270564
		public FKuroMaterialCurveFloatGroup_SI()
		{
		}

		// Token: 0x0601A8AC RID: 108716 RVA: 0x0027236C File Offset: 0x0027056C
		public FKuroMaterialCurveFloatGroup_SI(FKuroCurveFloat Curve)
		{
			this.Curve = Curve;
		}

		// Token: 0x0601A8AD RID: 108717 RVA: 0x0027237B File Offset: 0x0027057B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCurveFloatGroup_SI.StaticStruct();
		}

		// Token: 0x0601A8AE RID: 108718 RVA: 0x00272387 File Offset: 0x00270587
		[NullableContext(2)]
		public FKuroMaterialCurveFloatGroup_SI(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8AF RID: 108719 RVA: 0x00272391 File Offset: 0x00270591
		public FKuroMaterialCurveFloatGroup_SI(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x0027239C File Offset: 0x0027059C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCurveFloatGroup_SI(Pointer, false, true);
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x002723A6 File Offset: 0x002705A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCurveFloatGroup_SI(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5FA RID: 58874
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup_SI";

		// Token: 0x0400E5FB RID: 58875
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5FC RID: 58876
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400E5FD RID: 58877
		[Nullable(2)]
		private FKuroCurveFloat _Curve;
	}
}
