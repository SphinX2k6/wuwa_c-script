using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006DE RID: 1758
	[UnrealObjectPath("/Script/ControlRig.RigUnit_StartsWith")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_StartsWith : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E52 RID: 24146 RVA: 0x000875E8 File Offset: 0x000857E8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_StartsWith._ScriptStructPtr != 0) ? FRigUnit_StartsWith._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_StartsWith", ref FRigUnit_StartsWith._ScriptStructPtr);
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06005E53 RID: 24147 RVA: 0x0008760C File Offset: 0x0008580C
		// (set) Token: 0x06005E54 RID: 24148 RVA: 0x00087620 File Offset: 0x00085820
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x00087635 File Offset: 0x00085835
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x00087649 File Offset: 0x00085849
		public unsafe FName Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x0008765E File Offset: 0x0008585E
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x0008766E File Offset: 0x0008586E
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_StartsWith.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x0008767F File Offset: 0x0008587F
		public FRigUnit_StartsWith()
		{
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x00087687 File Offset: 0x00085887
		public FRigUnit_StartsWith(FName Name, FName Start, bool Result)
		{
			this.Name = Name;
			this.Start = Start;
			this.Result = Result;
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x000876A4 File Offset: 0x000858A4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_StartsWith.StaticStruct();
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x000876B0 File Offset: 0x000858B0
		[NullableContext(2)]
		public FRigUnit_StartsWith(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x000876BA File Offset: 0x000858BA
		public FRigUnit_StartsWith(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x000876C5 File Offset: 0x000858C5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_StartsWith(Pointer, false, true);
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x000876CF File Offset: 0x000858CF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_StartsWith(Pointer, MemoryOwner);
		}

		// Token: 0x04002C22 RID: 11298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_StartsWith";

		// Token: 0x04002C23 RID: 11299
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C24 RID: 11300
		internal static int __PropertyOffset_Name;

		// Token: 0x04002C25 RID: 11301
		internal static int __PropertyOffset_Start;

		// Token: 0x04002C26 RID: 11302
		internal static int __PropertyOffset_Result;
	}
}
