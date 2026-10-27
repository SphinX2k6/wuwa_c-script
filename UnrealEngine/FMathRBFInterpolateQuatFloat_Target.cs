using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000508 RID: 1288
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateQuatFloat_Target")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMathRBFInterpolateQuatFloat_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004343 RID: 17219 RVA: 0x00064526 File Offset: 0x00062726
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateQuatFloat_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateQuatFloat_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateQuatFloat_Target", ref FMathRBFInterpolateQuatFloat_Target._ScriptStructPtr);
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x0006454A File Offset: 0x0006274A
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x0006455E File Offset: 0x0006275E
		public unsafe FQuat Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatFloat_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatFloat_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00064573 File Offset: 0x00062773
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00064583 File Offset: 0x00062783
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatFloat_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatFloat_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00064594 File Offset: 0x00062794
		public FMathRBFInterpolateQuatFloat_Target()
		{
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x0006459C File Offset: 0x0006279C
		public FMathRBFInterpolateQuatFloat_Target(FQuat Target, float Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x000645B2 File Offset: 0x000627B2
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateQuatFloat_Target.StaticStruct();
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x000645BE File Offset: 0x000627BE
		[NullableContext(2)]
		public FMathRBFInterpolateQuatFloat_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x000645C8 File Offset: 0x000627C8
		public FMathRBFInterpolateQuatFloat_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x000645D3 File Offset: 0x000627D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateQuatFloat_Target(Pointer, false, true);
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x000645DD File Offset: 0x000627DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateQuatFloat_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020CB RID: 8395
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateQuatFloat_Target";

		// Token: 0x040020CC RID: 8396
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020CD RID: 8397
		internal static int __PropertyOffset_Target;

		// Token: 0x040020CE RID: 8398
		internal static int __PropertyOffset_Value;
	}
}
