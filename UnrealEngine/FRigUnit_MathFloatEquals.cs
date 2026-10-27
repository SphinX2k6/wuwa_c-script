using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FB RID: 1531
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatEquals")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatEquals : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005230 RID: 21040 RVA: 0x00078909 File Offset: 0x00076B09
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatEquals._ScriptStructPtr != 0) ? FRigUnit_MathFloatEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatEquals", ref FRigUnit_MathFloatEquals._ScriptStructPtr);
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x0007892D File Offset: 0x00076B2D
		// (set) Token: 0x06005232 RID: 21042 RVA: 0x0007893D File Offset: 0x00076B3D
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x0007894E File Offset: 0x00076B4E
		// (set) Token: 0x06005234 RID: 21044 RVA: 0x0007895E File Offset: 0x00076B5E
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06005235 RID: 21045 RVA: 0x0007896F File Offset: 0x00076B6F
		// (set) Token: 0x06005236 RID: 21046 RVA: 0x0007897F File Offset: 0x00076B7F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00078990 File Offset: 0x00076B90
		public FRigUnit_MathFloatEquals()
		{
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00078998 File Offset: 0x00076B98
		public FRigUnit_MathFloatEquals(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x000789B5 File Offset: 0x00076BB5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatEquals.StaticStruct();
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x000789C1 File Offset: 0x00076BC1
		[NullableContext(2)]
		public FRigUnit_MathFloatEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x000789CB File Offset: 0x00076BCB
		public FRigUnit_MathFloatEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x000789D6 File Offset: 0x00076BD6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatEquals(Pointer, false, true);
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x000789E0 File Offset: 0x00076BE0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002763 RID: 10083
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatEquals";

		// Token: 0x04002764 RID: 10084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002765 RID: 10085
		internal static int __PropertyOffset_A;

		// Token: 0x04002766 RID: 10086
		internal static int __PropertyOffset_B;

		// Token: 0x04002767 RID: 10087
		internal static int __PropertyOffset_Result;
	}
}
