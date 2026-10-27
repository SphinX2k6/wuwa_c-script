using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002514 RID: 9492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroBlurCurve")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FKuroBlurCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602340E RID: 144398 RVA: 0x003423EC File Offset: 0x003405EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBlurCurve._ScriptStructPtr != 0) ? FKuroBlurCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.KuroBlurCurve", ref FKuroBlurCurve._ScriptStructPtr);
		}

		// Token: 0x17008787 RID: 34695
		// (get) Token: 0x0602340F RID: 144399 RVA: 0x00342410 File Offset: 0x00340610
		// (set) Token: 0x06023410 RID: 144400 RVA: 0x00342453 File Offset: 0x00340653
		public FRichCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRichCurve(base.NativePtr + (IntPtr)FKuroBlurCurve.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurCurve.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023411 RID: 144401 RVA: 0x00342474 File Offset: 0x00340674
		public FKuroBlurCurve()
		{
		}

		// Token: 0x06023412 RID: 144402 RVA: 0x0034247C File Offset: 0x0034067C
		public FKuroBlurCurve(FRichCurve Curve)
		{
			this.Curve = Curve;
		}

		// Token: 0x06023413 RID: 144403 RVA: 0x0034248B File Offset: 0x0034068B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBlurCurve.StaticStruct();
		}

		// Token: 0x06023414 RID: 144404 RVA: 0x00342497 File Offset: 0x00340697
		[NullableContext(2)]
		public FKuroBlurCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023415 RID: 144405 RVA: 0x003424A1 File Offset: 0x003406A1
		public FKuroBlurCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023416 RID: 144406 RVA: 0x003424AC File Offset: 0x003406AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBlurCurve(Pointer, false, true);
		}

		// Token: 0x06023417 RID: 144407 RVA: 0x003424B6 File Offset: 0x003406B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBlurCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04012ED0 RID: 77520
		public const string __ObjectPath = "/Script/Niagara.KuroBlurCurve";

		// Token: 0x04012ED1 RID: 77521
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012ED2 RID: 77522
		internal static int __PropertyOffset_Curve;

		// Token: 0x04012ED3 RID: 77523
		[Nullable(2)]
		private FRichCurve _Curve;
	}
}
