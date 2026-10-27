using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F2 RID: 1522
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatCeil")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatCeil : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051D8 RID: 20952 RVA: 0x000783DA File Offset: 0x000765DA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatCeil._ScriptStructPtr != 0) ? FRigUnit_MathFloatCeil._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatCeil", ref FRigUnit_MathFloatCeil._ScriptStructPtr);
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x000783FE File Offset: 0x000765FE
		// (set) Token: 0x060051DA RID: 20954 RVA: 0x0007840E File Offset: 0x0007660E
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x0007841F File Offset: 0x0007661F
		// (set) Token: 0x060051DC RID: 20956 RVA: 0x0007842F File Offset: 0x0007662F
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x00078440 File Offset: 0x00076640
		// (set) Token: 0x060051DE RID: 20958 RVA: 0x00078450 File Offset: 0x00076650
		public unsafe int Int
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Int);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatCeil.__PropertyOffset_Int) = value;
			}
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00078461 File Offset: 0x00076661
		public FRigUnit_MathFloatCeil()
		{
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00078469 File Offset: 0x00076669
		public FRigUnit_MathFloatCeil(float Value, float Result, int Int)
		{
			this.Value = Value;
			this.Result = Result;
			this.Int = Int;
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00078486 File Offset: 0x00076686
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatCeil.StaticStruct();
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00078492 File Offset: 0x00076692
		[NullableContext(2)]
		public FRigUnit_MathFloatCeil(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x0007849C File Offset: 0x0007669C
		public FRigUnit_MathFloatCeil(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x000784A7 File Offset: 0x000766A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatCeil(Pointer, false, true);
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x000784B1 File Offset: 0x000766B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatCeil(Pointer, MemoryOwner);
		}

		// Token: 0x04002749 RID: 10057
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatCeil";

		// Token: 0x0400274A RID: 10058
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400274B RID: 10059
		internal static int __PropertyOffset_Value;

		// Token: 0x0400274C RID: 10060
		internal static int __PropertyOffset_Result;

		// Token: 0x0400274D RID: 10061
		internal static int __PropertyOffset_Int;
	}
}
