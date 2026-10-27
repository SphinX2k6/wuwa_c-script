using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B61 RID: 7009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup_SI")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FKuroMaterialCurveColorGroup_SI : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A890 RID: 108688 RVA: 0x00272059 File Offset: 0x00270259
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCurveColorGroup_SI._ScriptStructPtr != 0) ? FKuroMaterialCurveColorGroup_SI._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup_SI", ref FKuroMaterialCurveColorGroup_SI._ScriptStructPtr);
		}

		// Token: 0x17006AA8 RID: 27304
		// (get) Token: 0x0601A891 RID: 108689 RVA: 0x00272080 File Offset: 0x00270280
		// (set) Token: 0x0601A892 RID: 108690 RVA: 0x002720C3 File Offset: 0x002702C3
		public FKuroCurveLinearColor Curve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup_SI.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup_SI.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A893 RID: 108691 RVA: 0x002720E4 File Offset: 0x002702E4
		public FKuroMaterialCurveColorGroup_SI()
		{
		}

		// Token: 0x0601A894 RID: 108692 RVA: 0x002720EC File Offset: 0x002702EC
		public FKuroMaterialCurveColorGroup_SI(FKuroCurveLinearColor Curve)
		{
			this.Curve = Curve;
		}

		// Token: 0x0601A895 RID: 108693 RVA: 0x002720FB File Offset: 0x002702FB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCurveColorGroup_SI.StaticStruct();
		}

		// Token: 0x0601A896 RID: 108694 RVA: 0x00272107 File Offset: 0x00270307
		[NullableContext(2)]
		public FKuroMaterialCurveColorGroup_SI(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A897 RID: 108695 RVA: 0x00272111 File Offset: 0x00270311
		public FKuroMaterialCurveColorGroup_SI(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A898 RID: 108696 RVA: 0x0027211C File Offset: 0x0027031C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCurveColorGroup_SI(Pointer, false, true);
		}

		// Token: 0x0601A899 RID: 108697 RVA: 0x00272126 File Offset: 0x00270326
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCurveColorGroup_SI(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5EE RID: 58862
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup_SI";

		// Token: 0x0400E5EF RID: 58863
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5F0 RID: 58864
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400E5F1 RID: 58865
		[Nullable(2)]
		private FKuroCurveLinearColor _Curve;
	}
}
