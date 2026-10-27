using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000573 RID: 1395
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Contains")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_Contains : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A4C RID: 19020 RVA: 0x0006E5F9 File Offset: 0x0006C7F9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Contains._ScriptStructPtr != 0) ? FRigUnit_Contains._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Contains", ref FRigUnit_Contains._ScriptStructPtr);
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06004A4D RID: 19021 RVA: 0x0006E61D File Offset: 0x0006C81D
		// (set) Token: 0x06004A4E RID: 19022 RVA: 0x0006E631 File Offset: 0x0006C831
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x0006E646 File Offset: 0x0006C846
		// (set) Token: 0x06004A50 RID: 19024 RVA: 0x0006E65A File Offset: 0x0006C85A
		public unsafe FName Search
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Search);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Search) = value;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x0006E66F File Offset: 0x0006C86F
		// (set) Token: 0x06004A52 RID: 19026 RVA: 0x0006E67F File Offset: 0x0006C87F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Contains.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0006E690 File Offset: 0x0006C890
		public FRigUnit_Contains()
		{
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x0006E698 File Offset: 0x0006C898
		public FRigUnit_Contains(FName Name, FName Search, bool Result)
		{
			this.Name = Name;
			this.Search = Search;
			this.Result = Result;
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0006E6B5 File Offset: 0x0006C8B5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Contains.StaticStruct();
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x0006E6C1 File Offset: 0x0006C8C1
		[NullableContext(2)]
		public FRigUnit_Contains(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0006E6CB File Offset: 0x0006C8CB
		public FRigUnit_Contains(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0006E6D6 File Offset: 0x0006C8D6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Contains(Pointer, false, true);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0006E6E0 File Offset: 0x0006C8E0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Contains(Pointer, MemoryOwner);
		}

		// Token: 0x04002419 RID: 9241
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Contains";

		// Token: 0x0400241A RID: 9242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400241B RID: 9243
		internal static int __PropertyOffset_Name;

		// Token: 0x0400241C RID: 9244
		internal static int __PropertyOffset_Search;

		// Token: 0x0400241D RID: 9245
		internal static int __PropertyOffset_Result;
	}
}
