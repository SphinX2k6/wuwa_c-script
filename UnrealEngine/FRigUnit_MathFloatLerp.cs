using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000602 RID: 1538
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatLerp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatLerp : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600529C RID: 21148 RVA: 0x00078FF6 File Offset: 0x000771F6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatLerp._ScriptStructPtr != 0) ? FRigUnit_MathFloatLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatLerp", ref FRigUnit_MathFloatLerp._ScriptStructPtr);
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x0007901A File Offset: 0x0007721A
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x0007902A File Offset: 0x0007722A
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x0007903B File Offset: 0x0007723B
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x0007904B File Offset: 0x0007724B
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x0007905C File Offset: 0x0007725C
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x0007906C File Offset: 0x0007726C
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x0007907D File Offset: 0x0007727D
		// (set) Token: 0x060052A4 RID: 21156 RVA: 0x0007908D File Offset: 0x0007728D
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0007909E File Offset: 0x0007729E
		public FRigUnit_MathFloatLerp()
		{
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x000790A6 File Offset: 0x000772A6
		public FRigUnit_MathFloatLerp(float A, float B, float T, float Result)
		{
			this.A = A;
			this.B = B;
			this.T = T;
			this.Result = Result;
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x000790CB File Offset: 0x000772CB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatLerp.StaticStruct();
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x000790D7 File Offset: 0x000772D7
		[NullableContext(2)]
		public FRigUnit_MathFloatLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x000790E1 File Offset: 0x000772E1
		public FRigUnit_MathFloatLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x000790EC File Offset: 0x000772EC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatLerp(Pointer, false, true);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x000790F6 File Offset: 0x000772F6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatLerp(Pointer, MemoryOwner);
		}

		// Token: 0x0400278B RID: 10123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatLerp";

		// Token: 0x0400278C RID: 10124
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400278D RID: 10125
		internal static int __PropertyOffset_A;

		// Token: 0x0400278E RID: 10126
		internal static int __PropertyOffset_B;

		// Token: 0x0400278F RID: 10127
		internal static int __PropertyOffset_T;

		// Token: 0x04002790 RID: 10128
		internal static int __PropertyOffset_Result;
	}
}
