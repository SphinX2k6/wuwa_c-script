using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060E RID: 1550
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatRound")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatRound : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005324 RID: 21284 RVA: 0x00079880 File Offset: 0x00077A80
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatRound._ScriptStructPtr != 0) ? FRigUnit_MathFloatRound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatRound", ref FRigUnit_MathFloatRound._ScriptStructPtr);
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x000798A4 File Offset: 0x00077AA4
		// (set) Token: 0x06005326 RID: 21286 RVA: 0x000798B4 File Offset: 0x00077AB4
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x000798C5 File Offset: 0x00077AC5
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x000798D5 File Offset: 0x00077AD5
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x000798E6 File Offset: 0x00077AE6
		// (set) Token: 0x0600532A RID: 21290 RVA: 0x000798F6 File Offset: 0x00077AF6
		public unsafe int Int
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Int);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRound.__PropertyOffset_Int) = value;
			}
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x00079907 File Offset: 0x00077B07
		public FRigUnit_MathFloatRound()
		{
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x0007990F File Offset: 0x00077B0F
		public FRigUnit_MathFloatRound(float Value, float Result, int Int)
		{
			this.Value = Value;
			this.Result = Result;
			this.Int = Int;
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x0007992C File Offset: 0x00077B2C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatRound.StaticStruct();
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00079938 File Offset: 0x00077B38
		[NullableContext(2)]
		public FRigUnit_MathFloatRound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00079942 File Offset: 0x00077B42
		public FRigUnit_MathFloatRound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x0007994D File Offset: 0x00077B4D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatRound(Pointer, false, true);
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00079957 File Offset: 0x00077B57
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatRound(Pointer, MemoryOwner);
		}

		// Token: 0x040027B7 RID: 10167
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatRound";

		// Token: 0x040027B8 RID: 10168
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027B9 RID: 10169
		internal static int __PropertyOffset_Value;

		// Token: 0x040027BA RID: 10170
		internal static int __PropertyOffset_Result;

		// Token: 0x040027BB RID: 10171
		internal static int __PropertyOffset_Int;
	}
}
