using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000603 RID: 1539
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatLess")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatLess : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052AC RID: 21164 RVA: 0x000790FF File Offset: 0x000772FF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatLess._ScriptStructPtr != 0) ? FRigUnit_MathFloatLess._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatLess", ref FRigUnit_MathFloatLess._ScriptStructPtr);
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x00079123 File Offset: 0x00077323
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x00079133 File Offset: 0x00077333
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x00079144 File Offset: 0x00077344
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x00079154 File Offset: 0x00077354
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x00079165 File Offset: 0x00077365
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x00079175 File Offset: 0x00077375
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLess.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00079186 File Offset: 0x00077386
		public FRigUnit_MathFloatLess()
		{
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x0007918E File Offset: 0x0007738E
		public FRigUnit_MathFloatLess(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x000791AB File Offset: 0x000773AB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatLess.StaticStruct();
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x000791B7 File Offset: 0x000773B7
		[NullableContext(2)]
		public FRigUnit_MathFloatLess(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x000791C1 File Offset: 0x000773C1
		public FRigUnit_MathFloatLess(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x000791CC File Offset: 0x000773CC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatLess(Pointer, false, true);
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x000791D6 File Offset: 0x000773D6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatLess(Pointer, MemoryOwner);
		}

		// Token: 0x04002791 RID: 10129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatLess";

		// Token: 0x04002792 RID: 10130
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002793 RID: 10131
		internal static int __PropertyOffset_A;

		// Token: 0x04002794 RID: 10132
		internal static int __PropertyOffset_B;

		// Token: 0x04002795 RID: 10133
		internal static int __PropertyOffset_Result;
	}
}
