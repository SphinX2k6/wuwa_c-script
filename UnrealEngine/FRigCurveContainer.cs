using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200051D RID: 1309
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigCurveContainer")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigCurveContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044AA RID: 17578 RVA: 0x0006642A File Offset: 0x0006462A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigCurveContainer._ScriptStructPtr != 0) ? FRigCurveContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigCurveContainer", ref FRigCurveContainer._ScriptStructPtr);
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x00066450 File Offset: 0x00064650
		// (set) Token: 0x060044AC RID: 17580 RVA: 0x00066493 File Offset: 0x00064693
		public TArray<FRigCurve> Curves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigCurve> result;
				if ((result = this._Curves) == null)
				{
					result = (this._Curves = new TArray<FRigCurve>(base.NativePtr + (IntPtr)FRigCurveContainer.__PropertyOffset_Curves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curves.CopyAssign(value);
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x000664A4 File Offset: 0x000646A4
		// (set) Token: 0x060044AE RID: 17582 RVA: 0x000664E7 File Offset: 0x000646E7
		public TMap<FName, int> NameToIndexMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameToIndexMapping) == null)
				{
					result = (this._NameToIndexMapping = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigCurveContainer.__PropertyOffset_NameToIndexMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameToIndexMapping.CopyAssign(value);
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x000664F8 File Offset: 0x000646F8
		// (set) Token: 0x060044B0 RID: 17584 RVA: 0x0006653B File Offset: 0x0006473B
		public TArray<FName> Selection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Selection) == null)
				{
					result = (this._Selection = new TArray<FName>(base.NativePtr + (IntPtr)FRigCurveContainer.__PropertyOffset_Selection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Selection.CopyAssign(value);
			}
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00066549 File Offset: 0x00064749
		public FRigCurveContainer()
		{
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00066551 File Offset: 0x00064751
		public FRigCurveContainer(TArray<FRigCurve> Curves, TMap<FName, int> NameToIndexMapping, TArray<FName> Selection)
		{
			this.Curves = Curves;
			this.NameToIndexMapping = NameToIndexMapping;
			this.Selection = Selection;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0006656E File Offset: 0x0006476E
		protected override IntPtr GetUStructPtr()
		{
			return FRigCurveContainer.StaticStruct();
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x0006657A File Offset: 0x0006477A
		[NullableContext(2)]
		public FRigCurveContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00066584 File Offset: 0x00064784
		public FRigCurveContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x0006658F File Offset: 0x0006478F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigCurveContainer(Pointer, false, true);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00066599 File Offset: 0x00064799
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigCurveContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04002175 RID: 8565
		public const string __ObjectPath = "/Script/ControlRig.RigCurveContainer";

		// Token: 0x04002176 RID: 8566
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002177 RID: 8567
		internal static int __PropertyOffset_Curves;

		// Token: 0x04002178 RID: 8568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigCurve> _Curves;

		// Token: 0x04002179 RID: 8569
		internal static int __PropertyOffset_NameToIndexMapping;

		// Token: 0x0400217A RID: 8570
		[Nullable(2)]
		private TMap<FName, int> _NameToIndexMapping;

		// Token: 0x0400217B RID: 8571
		internal static int __PropertyOffset_Selection;

		// Token: 0x0400217C RID: 8572
		[Nullable(2)]
		private TArray<FName> _Selection;
	}
}
