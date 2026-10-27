using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002730 RID: 10032
	public sealed class FSharpherealTestDynDelegate0 : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602527B RID: 152187 RVA: 0x00370765 File Offset: 0x0036E965
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate0.StaticFunctionPtr();
		}

		// Token: 0x0602527C RID: 152188 RVA: 0x00370771 File Offset: 0x0036E971
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate0._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate0._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate0__DelegateSignature");
			}
			return FSharpherealTestDynDelegate0._FunctionPtr;
		}

		// Token: 0x0602527D RID: 152189 RVA: 0x00370794 File Offset: 0x0036E994
		public FSharpherealTestDynDelegate0()
		{
		}

		// Token: 0x0602527E RID: 152190 RVA: 0x0037079C File Offset: 0x0036E99C
		[NullableContext(2)]
		public FSharpherealTestDynDelegate0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602527F RID: 152191 RVA: 0x003707A6 File Offset: 0x0036E9A6
		public FSharpherealTestDynDelegate0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025280 RID: 152192 RVA: 0x003707B1 File Offset: 0x0036E9B1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int>) ?? ((Func<int>)Delegate.CreateDelegate(typeof(Func<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025281 RID: 152193 RVA: 0x003707E3 File Offset: 0x0036E9E3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int> Callback)
		{
			if (FSharpherealTestDynDelegate0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate0.OnScriptCallback));
				}
				FSharpherealTestDynDelegate0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate0.RegisterId);
		}

		// Token: 0x06025282 RID: 152194 RVA: 0x00370820 File Offset: 0x0036EA20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute()
		{
			FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate0.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025283 RID: 152195 RVA: 0x0037085C File Offset: 0x0036EA5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int> func = target as Func<int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			int _Result = func();
			((FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04014074 RID: 82036
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014075 RID: 82037
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate0__DelegateSignature";

		// Token: 0x04014076 RID: 82038
		private static int RegisterId;

		// Token: 0x020036B9 RID: 14009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FSharpherealTestDynDelegate0_DelegateParams
		{
			// Token: 0x040177D4 RID: 96212
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020036BA RID: 14010
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177D5 RID: 96213
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
