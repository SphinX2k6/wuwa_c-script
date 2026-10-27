using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000516 RID: 1302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigBoneHierarchy")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FRigBoneHierarchy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600440B RID: 17419 RVA: 0x000655E4 File Offset: 0x000637E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigBoneHierarchy._ScriptStructPtr != 0) ? FRigBoneHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigBoneHierarchy", ref FRigBoneHierarchy._ScriptStructPtr);
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x00065608 File Offset: 0x00063808
		// (set) Token: 0x0600440D RID: 17421 RVA: 0x0006564B File Offset: 0x0006384B
		public TArray<FRigBone> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigBone> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FRigBone>(base.NativePtr + (IntPtr)FRigBoneHierarchy.__PropertyOffset_Bones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x0006565C File Offset: 0x0006385C
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x0006569F File Offset: 0x0006389F
		public TMap<FName, int> NameToIndexMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameToIndexMapping) == null)
				{
					result = (this._NameToIndexMapping = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigBoneHierarchy.__PropertyOffset_NameToIndexMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameToIndexMapping.CopyAssign(value);
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x000656B0 File Offset: 0x000638B0
		// (set) Token: 0x06004411 RID: 17425 RVA: 0x000656F3 File Offset: 0x000638F3
		public TArray<FName> Selection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Selection) == null)
				{
					result = (this._Selection = new TArray<FName>(base.NativePtr + (IntPtr)FRigBoneHierarchy.__PropertyOffset_Selection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Selection.CopyAssign(value);
			}
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00065701 File Offset: 0x00063901
		public FRigBoneHierarchy()
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00065709 File Offset: 0x00063909
		public FRigBoneHierarchy(TArray<FRigBone> Bones, TMap<FName, int> NameToIndexMapping, TArray<FName> Selection)
		{
			this.Bones = Bones;
			this.NameToIndexMapping = NameToIndexMapping;
			this.Selection = Selection;
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00065726 File Offset: 0x00063926
		protected override IntPtr GetUStructPtr()
		{
			return FRigBoneHierarchy.StaticStruct();
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00065732 File Offset: 0x00063932
		[NullableContext(2)]
		public FRigBoneHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x0006573C File Offset: 0x0006393C
		public FRigBoneHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00065747 File Offset: 0x00063947
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigBoneHierarchy(Pointer, false, true);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00065751 File Offset: 0x00063951
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigBoneHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x04002127 RID: 8487
		public const string __ObjectPath = "/Script/ControlRig.RigBoneHierarchy";

		// Token: 0x04002128 RID: 8488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002129 RID: 8489
		internal static int __PropertyOffset_Bones;

		// Token: 0x0400212A RID: 8490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigBone> _Bones;

		// Token: 0x0400212B RID: 8491
		internal static int __PropertyOffset_NameToIndexMapping;

		// Token: 0x0400212C RID: 8492
		[Nullable(2)]
		private TMap<FName, int> _NameToIndexMapping;

		// Token: 0x0400212D RID: 8493
		internal static int __PropertyOffset_Selection;

		// Token: 0x0400212E RID: 8494
		[Nullable(2)]
		private TArray<FName> _Selection;
	}
}
