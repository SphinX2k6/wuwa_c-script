using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002735 RID: 10037
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSharpherealTestDynMultiDelegate1 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060252A9 RID: 152233 RVA: 0x00370DC6 File Offset: 0x0036EFC6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynMultiDelegate1.StaticFunctionPtr();
		}

		// Token: 0x060252AA RID: 152234 RVA: 0x00370DD2 File Offset: 0x0036EFD2
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynMultiDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynMultiDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynMultiDelegate1__DelegateSignature");
			}
			return FSharpherealTestDynMultiDelegate1._FunctionPtr;
		}

		// Token: 0x060252AB RID: 152235 RVA: 0x00370DF5 File Offset: 0x0036EFF5
		public FSharpherealTestDynMultiDelegate1()
		{
		}

		// Token: 0x060252AC RID: 152236 RVA: 0x00370DFD File Offset: 0x0036EFFD
		[NullableContext(2)]
		public FSharpherealTestDynMultiDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060252AD RID: 152237 RVA: 0x00370E07 File Offset: 0x0036F007
		public FSharpherealTestDynMultiDelegate1(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060252AE RID: 152238 RVA: 0x00370E12 File Offset: 0x0036F012
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060252AF RID: 152239 RVA: 0x00370E44 File Offset: 0x0036F044
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FSharpherealTestDynMultiDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynMultiDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynMultiDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynMultiDelegate1.OnScriptCallback));
				}
				FSharpherealTestDynMultiDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSharpherealTestDynMultiDelegate1.RegisterId);
		}

		// Token: 0x060252B0 RID: 152240 RVA: 0x00370E7E File Offset: 0x0036F07E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060252B1 RID: 152241 RVA: 0x00370E88 File Offset: 0x0036F088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Val)
		{
			FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynMultiDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060252B2 RID: 152242 RVA: 0x00370EC4 File Offset: 0x0036F0C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04014083 RID: 82051
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014084 RID: 82052
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynMultiDelegate1__DelegateSignature";

		// Token: 0x04014085 RID: 82053
		private static int RegisterId;

		// Token: 0x020036C2 RID: 14018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FSharpherealTestDynMultiDelegate1_DelegateParams
		{
			// Token: 0x040177E1 RID: 96225
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036C3 RID: 14019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177E2 RID: 96226
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
