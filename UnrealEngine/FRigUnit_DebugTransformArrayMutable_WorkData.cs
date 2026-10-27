using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000591 RID: 1425
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugTransformArrayMutable_WorkData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_DebugTransformArrayMutable_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x00070FC8 File Offset: 0x0006F1C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugTransformArrayMutable_WorkData._ScriptStructPtr != 0) ? FRigUnit_DebugTransformArrayMutable_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugTransformArrayMutable_WorkData", ref FRigUnit_DebugTransformArrayMutable_WorkData._ScriptStructPtr);
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x00070FEC File Offset: 0x0006F1EC
		// (set) Token: 0x06004C59 RID: 19545 RVA: 0x0007102F File Offset: 0x0006F22F
		public TArray<FTransform> DrawTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._DrawTransforms) == null)
				{
					result = (this._DrawTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable_WorkData.__PropertyOffset_DrawTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DrawTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x0007103D File Offset: 0x0006F23D
		public FRigUnit_DebugTransformArrayMutable_WorkData()
		{
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00071045 File Offset: 0x0006F245
		public FRigUnit_DebugTransformArrayMutable_WorkData(TArray<FTransform> DrawTransforms)
		{
			this.DrawTransforms = DrawTransforms;
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00071054 File Offset: 0x0006F254
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugTransformArrayMutable_WorkData.StaticStruct();
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00071060 File Offset: 0x0006F260
		[NullableContext(2)]
		public FRigUnit_DebugTransformArrayMutable_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x0007106A File Offset: 0x0006F26A
		public FRigUnit_DebugTransformArrayMutable_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00071075 File Offset: 0x0006F275
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugTransformArrayMutable_WorkData(Pointer, false, true);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0007107F File Offset: 0x0006F27F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugTransformArrayMutable_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040024F2 RID: 9458
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugTransformArrayMutable_WorkData";

		// Token: 0x040024F3 RID: 9459
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024F4 RID: 9460
		internal static int __PropertyOffset_DrawTransforms;

		// Token: 0x040024F5 RID: 9461
		[Nullable(2)]
		private TArray<FTransform> _DrawTransforms;
	}
}
