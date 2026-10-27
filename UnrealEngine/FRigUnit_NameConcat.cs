using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069C RID: 1692
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NameConcat")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_NameConcat : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059CD RID: 22989 RVA: 0x00080F79 File Offset: 0x0007F179
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NameConcat._ScriptStructPtr != 0) ? FRigUnit_NameConcat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NameConcat", ref FRigUnit_NameConcat._ScriptStructPtr);
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x00080F9D File Offset: 0x0007F19D
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x00080FB1 File Offset: 0x0007F1B1
		public unsafe FName A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x00080FC6 File Offset: 0x0007F1C6
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x00080FDA File Offset: 0x0007F1DA
		public unsafe FName B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x00080FEF File Offset: 0x0007F1EF
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x00081003 File Offset: 0x0007F203
		public unsafe FName Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameConcat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x00081018 File Offset: 0x0007F218
		public FRigUnit_NameConcat()
		{
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00081020 File Offset: 0x0007F220
		public FRigUnit_NameConcat(FName A, FName B, FName Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x0008103D File Offset: 0x0007F23D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NameConcat.StaticStruct();
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00081049 File Offset: 0x0007F249
		[NullableContext(2)]
		public FRigUnit_NameConcat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00081053 File Offset: 0x0007F253
		public FRigUnit_NameConcat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x0008105E File Offset: 0x0007F25E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NameConcat(Pointer, false, true);
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00081068 File Offset: 0x0007F268
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NameConcat(Pointer, MemoryOwner);
		}

		// Token: 0x04002A0D RID: 10765
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NameConcat";

		// Token: 0x04002A0E RID: 10766
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A0F RID: 10767
		internal static int __PropertyOffset_A;

		// Token: 0x04002A10 RID: 10768
		internal static int __PropertyOffset_B;

		// Token: 0x04002A11 RID: 10769
		internal static int __PropertyOffset_Result;
	}
}
