using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002107 RID: 8455
	public sealed class FSimpleSequenceEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FD13 RID: 130323 RVA: 0x002F522E File Offset: 0x002F342E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSimpleSequenceEvent.StaticFunctionPtr();
		}

		// Token: 0x0601FD14 RID: 130324 RVA: 0x002F523A File Offset: 0x002F343A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSimpleSequenceEvent._FunctionPtr == IntPtr.Zero)
			{
				FSimpleSequenceEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SimpleSequenceEvent__DelegateSignature");
			}
			return FSimpleSequenceEvent._FunctionPtr;
		}

		// Token: 0x0601FD15 RID: 130325 RVA: 0x002F525D File Offset: 0x002F345D
		public FSimpleSequenceEvent()
		{
		}

		// Token: 0x0601FD16 RID: 130326 RVA: 0x002F5265 File Offset: 0x002F3465
		[NullableContext(2)]
		public FSimpleSequenceEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD17 RID: 130327 RVA: 0x002F526F File Offset: 0x002F346F
		public FSimpleSequenceEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD18 RID: 130328 RVA: 0x002F527A File Offset: 0x002F347A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FD19 RID: 130329 RVA: 0x002F52AC File Offset: 0x002F34AC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FSimpleSequenceEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSimpleSequenceEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSimpleSequenceEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSimpleSequenceEvent.OnScriptCallback));
				}
				FSimpleSequenceEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSimpleSequenceEvent.RegisterId);
		}

		// Token: 0x0601FD1A RID: 130330 RVA: 0x002F52E6 File Offset: 0x002F34E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601FD1B RID: 130331 RVA: 0x002F52F4 File Offset: 0x002F34F4
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

		// Token: 0x04011257 RID: 70231
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011258 RID: 70232
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SimpleSequenceEvent__DelegateSignature";

		// Token: 0x04011259 RID: 70233
		private static int RegisterId;

		// Token: 0x020034E5 RID: 13541
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F9 RID: 95481
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
