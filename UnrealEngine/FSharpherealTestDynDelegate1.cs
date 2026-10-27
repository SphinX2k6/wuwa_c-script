using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002731 RID: 10033
	public sealed class FSharpherealTestDynDelegate1 : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025284 RID: 152196 RVA: 0x003708A8 File Offset: 0x0036EAA8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate1.StaticFunctionPtr();
		}

		// Token: 0x06025285 RID: 152197 RVA: 0x003708B4 File Offset: 0x0036EAB4
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate1__DelegateSignature");
			}
			return FSharpherealTestDynDelegate1._FunctionPtr;
		}

		// Token: 0x06025286 RID: 152198 RVA: 0x003708D7 File Offset: 0x0036EAD7
		public FSharpherealTestDynDelegate1()
		{
		}

		// Token: 0x06025287 RID: 152199 RVA: 0x003708DF File Offset: 0x0036EADF
		[NullableContext(2)]
		public FSharpherealTestDynDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025288 RID: 152200 RVA: 0x003708E9 File Offset: 0x0036EAE9
		public FSharpherealTestDynDelegate1(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025289 RID: 152201 RVA: 0x003708F4 File Offset: 0x0036EAF4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602528A RID: 152202 RVA: 0x00370926 File Offset: 0x0036EB26
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FSharpherealTestDynDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate1.OnScriptCallback));
				}
				FSharpherealTestDynDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate1.RegisterId);
		}

		// Token: 0x0602528B RID: 152203 RVA: 0x00370960 File Offset: 0x0036EB60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Val)
		{
			FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0602528C RID: 152204 RVA: 0x003709A0 File Offset: 0x0036EBA0
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
			action(((FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04014077 RID: 82039
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014078 RID: 82040
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate1__DelegateSignature";

		// Token: 0x04014079 RID: 82041
		private static int RegisterId;

		// Token: 0x020036BB RID: 14011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FSharpherealTestDynDelegate1_DelegateParams
		{
			// Token: 0x040177D6 RID: 96214
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036BC RID: 14012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177D7 RID: 96215
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
