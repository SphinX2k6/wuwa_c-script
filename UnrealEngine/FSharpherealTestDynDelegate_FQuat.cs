using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002732 RID: 10034
	public sealed class FSharpherealTestDynDelegate_FQuat : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602528D RID: 152205 RVA: 0x003709EA File Offset: 0x0036EBEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate_FQuat.StaticFunctionPtr();
		}

		// Token: 0x0602528E RID: 152206 RVA: 0x003709F6 File Offset: 0x0036EBF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate_FQuat._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate_FQuat._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate_FQuat__DelegateSignature");
			}
			return FSharpherealTestDynDelegate_FQuat._FunctionPtr;
		}

		// Token: 0x0602528F RID: 152207 RVA: 0x00370A19 File Offset: 0x0036EC19
		public FSharpherealTestDynDelegate_FQuat()
		{
		}

		// Token: 0x06025290 RID: 152208 RVA: 0x00370A21 File Offset: 0x0036EC21
		[NullableContext(2)]
		public FSharpherealTestDynDelegate_FQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025291 RID: 152209 RVA: 0x00370A2B File Offset: 0x0036EC2B
		public FSharpherealTestDynDelegate_FQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025292 RID: 152210 RVA: 0x00370A36 File Offset: 0x0036EC36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FQuat, FQuat, FQuat>) ?? ((Func<FQuat, FQuat, FQuat>)Delegate.CreateDelegate(typeof(Func<FQuat, FQuat, FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025293 RID: 152211 RVA: 0x00370A68 File Offset: 0x0036EC68
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025294 RID: 152212 RVA: 0x00370AA4 File Offset: 0x0036ECA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FQuat Execute(in FQuat A, in FQuat B)
		{
			FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FSharpherealTestDynDelegate_FQuat.__FSharpherealTestDynDelegate_FQuat_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate_FQuat.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025295 RID: 152213 RVA: 0x00370AF8 File Offset: 0x0036ECF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0401407A RID: 82042
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401407B RID: 82043
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate_FQuat__DelegateSignature";

		// Token: 0x0401407C RID: 82044
		private static int RegisterId;

		// Token: 0x020036BD RID: 14013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FSharpherealTestDynDelegate_FQuat_DelegateParams
		{
			// Token: 0x040177D8 RID: 96216
			[FieldOffset(0)]
			public FQuat A;

			// Token: 0x040177D9 RID: 96217
			[FieldOffset(16)]
			public FQuat B;

			// Token: 0x040177DA RID: 96218
			[FieldOffset(32)]
			public FQuat __Result;
		}

		// Token: 0x020036BE RID: 14014
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177DB RID: 96219
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
