using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E7 RID: 2023
	public sealed class FSharpherealTestDynDelegate_FQuat : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD7D RID: 44413 RVA: 0x001009CE File Offset: 0x000FEBCE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate_FQuat.StaticFunctionPtr();
		}

		// Token: 0x0600AD7E RID: 44414 RVA: 0x001009DA File Offset: 0x000FEBDA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate_FQuat._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate_FQuat._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate_FQuat__DelegateSignature");
			}
			return FSharpherealTestDynDelegate_FQuat._FunctionPtr;
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x001009FD File Offset: 0x000FEBFD
		public FSharpherealTestDynDelegate_FQuat()
		{
		}

		// Token: 0x0600AD80 RID: 44416 RVA: 0x00100A05 File Offset: 0x000FEC05
		[NullableContext(2)]
		public FSharpherealTestDynDelegate_FQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x00100A0F File Offset: 0x000FEC0F
		public FSharpherealTestDynDelegate_FQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x00100A1A File Offset: 0x000FEC1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FQuat, FQuat, FQuat>) ?? ((Func<FQuat, FQuat, FQuat>)Delegate.CreateDelegate(typeof(Func<FQuat, FQuat, FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x00100A4C File Offset: 0x000FEC4C
		[NullableContext(1)]
		public void Bind(Func<FQuat, FQuat, FQuat> Callback)
		{
			if (FSharpherealTestDynDelegate_FQuat.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate_FQuat.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate_FQuat.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate_FQuat.OnScriptCallback));
				}
				FSharpherealTestDynDelegate_FQuat.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate_FQuat.RegisterId);
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x00100A88 File Offset: 0x000FEC88
		[SkipLocalsInit]
		public unsafe FQuat Execute(in FQuat A, in FQuat B)
		{
			FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate_FQuat.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x00100ADC File Offset: 0x000FECDC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FQuat, FQuat, FQuat> func = target as Func<FQuat, FQuat, FQuat>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FQuat _Result = func(((FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams*)__Parameters)->A, ((FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams*)__Parameters)->B);
			((FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04004ADD RID: 19165
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004ADE RID: 19166
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate_FQuat__DelegateSignature";

		// Token: 0x04004ADF RID: 19167
		private static int RegisterId;

		// Token: 0x02000F8F RID: 3983
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FSharpherealTestDynDelegate_FQuat_DelegateParams
		{
			// Token: 0x0400638B RID: 25483
			[FieldOffset(0)]
			public FQuat A;

			// Token: 0x0400638C RID: 25484
			[FieldOffset(16)]
			public FQuat B;

			// Token: 0x0400638D RID: 25485
			[FieldOffset(32)]
			public FQuat __Result;
		}

		// Token: 0x02000F90 RID: 3984
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400638E RID: 25486
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
