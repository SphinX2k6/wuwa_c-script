using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000554 RID: 1364
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BlendTransform")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigUnit_BlendTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600481D RID: 18461 RVA: 0x0006AF17 File Offset: 0x00069117
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BlendTransform._ScriptStructPtr != 0) ? FRigUnit_BlendTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BlendTransform", ref FRigUnit_BlendTransform._ScriptStructPtr);
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x0006AF3B File Offset: 0x0006913B
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x0006AF4F File Offset: 0x0006914F
		public unsafe FTransform Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BlendTransform.__PropertyOffset_Source);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BlendTransform.__PropertyOffset_Source) = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0006AF64 File Offset: 0x00069164
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x0006AFA7 File Offset: 0x000691A7
		public TArray<FBlendTarget> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlendTarget> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FBlendTarget>(base.NativePtr + (IntPtr)FRigUnit_BlendTransform.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x0006AFB5 File Offset: 0x000691B5
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x0006AFC9 File Offset: 0x000691C9
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BlendTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BlendTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x0006AFDE File Offset: 0x000691DE
		public FRigUnit_BlendTransform()
		{
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x0006AFE6 File Offset: 0x000691E6
		public FRigUnit_BlendTransform(FTransform Source, TArray<FBlendTarget> Targets, FTransform Result)
		{
			this.Source = Source;
			this.Targets = Targets;
			this.Result = Result;
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x0006B003 File Offset: 0x00069203
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BlendTransform.StaticStruct();
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x0006B00F File Offset: 0x0006920F
		[NullableContext(2)]
		public FRigUnit_BlendTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x0006B019 File Offset: 0x00069219
		public FRigUnit_BlendTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x0006B024 File Offset: 0x00069224
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BlendTransform(Pointer, false, true);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x0006B02E File Offset: 0x0006922E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BlendTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040022FE RID: 8958
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BlendTransform";

		// Token: 0x040022FF RID: 8959
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002300 RID: 8960
		internal static int __PropertyOffset_Source;

		// Token: 0x04002301 RID: 8961
		internal static int __PropertyOffset_Targets;

		// Token: 0x04002302 RID: 8962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlendTarget> _Targets;

		// Token: 0x04002303 RID: 8963
		internal static int __PropertyOffset_Result;
	}
}
