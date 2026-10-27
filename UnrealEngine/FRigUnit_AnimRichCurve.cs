using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200054D RID: 1357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AnimRichCurve")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_AnimRichCurve : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047BB RID: 18363 RVA: 0x0006A7AA File Offset: 0x000689AA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AnimRichCurve._ScriptStructPtr != 0) ? FRigUnit_AnimRichCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AnimRichCurve", ref FRigUnit_AnimRichCurve._ScriptStructPtr);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x0006A7D0 File Offset: 0x000689D0
		// (set) Token: 0x060047BD RID: 18365 RVA: 0x0006A813 File Offset: 0x00068A13
		public FRuntimeFloatCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRigUnit_AnimRichCurve.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AnimRichCurve.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0006A834 File Offset: 0x00068A34
		public FRigUnit_AnimRichCurve()
		{
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0006A83C File Offset: 0x00068A3C
		public FRigUnit_AnimRichCurve(FRuntimeFloatCurve Curve)
		{
			this.Curve = Curve;
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0006A84B File Offset: 0x00068A4B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AnimRichCurve.StaticStruct();
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0006A857 File Offset: 0x00068A57
		[NullableContext(2)]
		public FRigUnit_AnimRichCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0006A861 File Offset: 0x00068A61
		public FRigUnit_AnimRichCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0006A86C File Offset: 0x00068A6C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AnimRichCurve(Pointer, false, true);
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0006A876 File Offset: 0x00068A76
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AnimRichCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040022D8 RID: 8920
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AnimRichCurve";

		// Token: 0x040022D9 RID: 8921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022DA RID: 8922
		internal static int __PropertyOffset_Curve;

		// Token: 0x040022DB RID: 8923
		[Nullable(2)]
		private FRuntimeFloatCurve _Curve;
	}
}
