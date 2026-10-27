using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000515 RID: 1301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigBone")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigBone : FRigElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060043F5 RID: 17397 RVA: 0x000653F3 File Offset: 0x000635F3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigBone._ScriptStructPtr != 0) ? FRigBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigBone", ref FRigBone._ScriptStructPtr);
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x00065417 File Offset: 0x00063617
		// (set) Token: 0x060043F7 RID: 17399 RVA: 0x0006542B File Offset: 0x0006362B
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x00065440 File Offset: 0x00063640
		// (set) Token: 0x060043F9 RID: 17401 RVA: 0x00065450 File Offset: 0x00063650
		public unsafe int ParentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_ParentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_ParentIndex) = value;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x00065461 File Offset: 0x00063661
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x00065475 File Offset: 0x00063675
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x0006548A File Offset: 0x0006368A
		// (set) Token: 0x060043FD RID: 17405 RVA: 0x0006549E File Offset: 0x0006369E
		public unsafe FTransform GlobalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_GlobalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_GlobalTransform) = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x000654B3 File Offset: 0x000636B3
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x000654C7 File Offset: 0x000636C7
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x000654DC File Offset: 0x000636DC
		// (set) Token: 0x06004401 RID: 17409 RVA: 0x0006551F File Offset: 0x0006371F
		public TArray<int> Dependents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Dependents) == null)
				{
					result = (this._Dependents = new TArray<int>(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_Dependents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Dependents.CopyAssign(value);
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x0006552D File Offset: 0x0006372D
		// (set) Token: 0x06004403 RID: 17411 RVA: 0x0006553D File Offset: 0x0006373D
		public unsafe ERigBoneType Type
		{
			get
			{
				return (ERigBoneType)(*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigBone.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x0006554E File Offset: 0x0006374E
		public FRigBone()
		{
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00065558 File Offset: 0x00063758
		public FRigBone(FName ParentName, int ParentIndex, FTransform InitialTransform, FTransform GlobalTransform, FTransform LocalTransform, TArray<int> Dependents, ERigBoneType Type, FName Name, int Index)
		{
			this.ParentName = ParentName;
			this.ParentIndex = ParentIndex;
			this.InitialTransform = InitialTransform;
			this.GlobalTransform = GlobalTransform;
			this.LocalTransform = LocalTransform;
			this.Dependents = Dependents;
			this.Type = Type;
			base.Name = Name;
			base.Index = Index;
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000655B0 File Offset: 0x000637B0
		protected override IntPtr GetUStructPtr()
		{
			return FRigBone.StaticStruct();
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x000655BC File Offset: 0x000637BC
		[NullableContext(2)]
		public FRigBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000655C6 File Offset: 0x000637C6
		public FRigBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000655D1 File Offset: 0x000637D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigBone(Pointer, false, true);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x000655DB File Offset: 0x000637DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigBone(Pointer, MemoryOwner);
		}

		// Token: 0x0400211D RID: 8477
		public new const string __ObjectPath = "/Script/ControlRig.RigBone";

		// Token: 0x0400211E RID: 8478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400211F RID: 8479
		internal static int __PropertyOffset_ParentName;

		// Token: 0x04002120 RID: 8480
		internal static int __PropertyOffset_ParentIndex;

		// Token: 0x04002121 RID: 8481
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x04002122 RID: 8482
		internal static int __PropertyOffset_GlobalTransform;

		// Token: 0x04002123 RID: 8483
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x04002124 RID: 8484
		internal static int __PropertyOffset_Dependents;

		// Token: 0x04002125 RID: 8485
		[Nullable(2)]
		private TArray<int> _Dependents;

		// Token: 0x04002126 RID: 8486
		internal static int __PropertyOffset_Type;
	}
}
