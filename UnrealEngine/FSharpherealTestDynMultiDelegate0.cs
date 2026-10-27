using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002734 RID: 10036
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSharpherealTestDynMultiDelegate0 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602529F RID: 152223 RVA: 0x00370CB8 File Offset: 0x0036EEB8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynMultiDelegate0.StaticFunctionPtr();
		}

		// Token: 0x060252A0 RID: 152224 RVA: 0x00370CC4 File Offset: 0x0036EEC4
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynMultiDelegate0._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynMultiDelegate0._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynMultiDelegate0__DelegateSignature");
			}
			return FSharpherealTestDynMultiDelegate0._FunctionPtr;
		}

		// Token: 0x060252A1 RID: 152225 RVA: 0x00370CE7 File Offset: 0x0036EEE7
		public FSharpherealTestDynMultiDelegate0()
		{
		}

		// Token: 0x060252A2 RID: 152226 RVA: 0x00370CEF File Offset: 0x0036EEEF
		[NullableContext(2)]
		public FSharpherealTestDynMultiDelegate0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060252A3 RID: 152227 RVA: 0x00370CF9 File Offset: 0x0036EEF9
		public FSharpherealTestDynMultiDelegate0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060252A4 RID: 152228 RVA: 0x00370D04 File Offset: 0x0036EF04
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060252A5 RID: 152229 RVA: 0x00370D36 File Offset: 0x0036EF36
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FSharpherealTestDynMultiDelegate0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynMultiDelegate0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynMultiDelegate0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynMultiDelegate0.OnScriptCallback));
				}
				FSharpherealTestDynMultiDelegate0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSharpherealTestDynMultiDelegate0.RegisterId);
		}

		// Token: 0x060252A6 RID: 152230 RVA: 0x00370D70 File Offset: 0x0036EF70
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060252A7 RID: 152231 RVA: 0x00370D79 File Offset: 0x0036EF79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060252A8 RID: 152232 RVA: 0x00370D84 File Offset: 0x0036EF84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04014080 RID: 82048
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014081 RID: 82049
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynMultiDelegate0__DelegateSignature";

		// Token: 0x04014082 RID: 82050
		private static int RegisterId;

		// Token: 0x020036C1 RID: 14017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177E0 RID: 96224
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
