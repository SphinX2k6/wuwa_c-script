using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052D RID: 1325
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigSpaceHierarchy")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigSpaceHierarchy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x00067582 File Offset: 0x00065782
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigSpaceHierarchy._ScriptStructPtr != 0) ? FRigSpaceHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigSpaceHierarchy", ref FRigSpaceHierarchy._ScriptStructPtr);
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x000675A8 File Offset: 0x000657A8
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x000675EB File Offset: 0x000657EB
		public TArray<FRigSpace> Spaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigSpace> result;
				if ((result = this._Spaces) == null)
				{
					result = (this._Spaces = new TArray<FRigSpace>(base.NativePtr + (IntPtr)FRigSpaceHierarchy.__PropertyOffset_Spaces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Spaces.CopyAssign(value);
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x000675FC File Offset: 0x000657FC
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x0006763F File Offset: 0x0006583F
		public TMap<FName, int> NameToIndexMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameToIndexMapping) == null)
				{
					result = (this._NameToIndexMapping = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigSpaceHierarchy.__PropertyOffset_NameToIndexMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameToIndexMapping.CopyAssign(value);
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00067650 File Offset: 0x00065850
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x00067693 File Offset: 0x00065893
		public TArray<FName> Selection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Selection) == null)
				{
					result = (this._Selection = new TArray<FName>(base.NativePtr + (IntPtr)FRigSpaceHierarchy.__PropertyOffset_Selection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Selection.CopyAssign(value);
			}
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x000676A1 File Offset: 0x000658A1
		public FRigSpaceHierarchy()
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x000676A9 File Offset: 0x000658A9
		public FRigSpaceHierarchy(TArray<FRigSpace> Spaces, TMap<FName, int> NameToIndexMapping, TArray<FName> Selection)
		{
			this.Spaces = Spaces;
			this.NameToIndexMapping = NameToIndexMapping;
			this.Selection = Selection;
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x000676C6 File Offset: 0x000658C6
		protected override IntPtr GetUStructPtr()
		{
			return FRigSpaceHierarchy.StaticStruct();
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x000676D2 File Offset: 0x000658D2
		[NullableContext(2)]
		public FRigSpaceHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x000676DC File Offset: 0x000658DC
		public FRigSpaceHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x000676E7 File Offset: 0x000658E7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigSpaceHierarchy(Pointer, false, true);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x000676F1 File Offset: 0x000658F1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigSpaceHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x040021CF RID: 8655
		public const string __ObjectPath = "/Script/ControlRig.RigSpaceHierarchy";

		// Token: 0x040021D0 RID: 8656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021D1 RID: 8657
		internal static int __PropertyOffset_Spaces;

		// Token: 0x040021D2 RID: 8658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigSpace> _Spaces;

		// Token: 0x040021D3 RID: 8659
		internal static int __PropertyOffset_NameToIndexMapping;

		// Token: 0x040021D4 RID: 8660
		[Nullable(2)]
		private TMap<FName, int> _NameToIndexMapping;

		// Token: 0x040021D5 RID: 8661
		internal static int __PropertyOffset_Selection;

		// Token: 0x040021D6 RID: 8662
		[Nullable(2)]
		private TArray<FName> _Selection;
	}
}
