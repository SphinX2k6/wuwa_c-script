using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002695 RID: 9877
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSceneColorCapturedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06024AC3 RID: 150211 RVA: 0x00364AF8 File Offset: 0x00362CF8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneColorCapturedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06024AC4 RID: 150212 RVA: 0x00364B04 File Offset: 0x00362D04
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSceneColorCapturedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSceneColorCapturedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Renderer.OnSceneColorCapturedDelegate__DelegateSignature");
			}
			return FOnSceneColorCapturedDelegate._FunctionPtr;
		}

		// Token: 0x06024AC5 RID: 150213 RVA: 0x00364B27 File Offset: 0x00362D27
		public FOnSceneColorCapturedDelegate()
		{
		}

		// Token: 0x06024AC6 RID: 150214 RVA: 0x00364B2F File Offset: 0x00362D2F
		[NullableContext(2)]
		public FOnSceneColorCapturedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024AC7 RID: 150215 RVA: 0x00364B39 File Offset: 0x00362D39
		public FOnSceneColorCapturedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024AC8 RID: 150216 RVA: 0x00364B44 File Offset: 0x00362D44
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06024AC9 RID: 150217 RVA: 0x00364B76 File Offset: 0x00362D76
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnSceneColorCapturedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSceneColorCapturedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSceneColorCapturedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSceneColorCapturedDelegate.OnScriptCallback));
				}
				FOnSceneColorCapturedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSceneColorCapturedDelegate.RegisterId);
		}

		// Token: 0x06024ACA RID: 150218 RVA: 0x00364BB0 File Offset: 0x00362DB0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06024ACB RID: 150219 RVA: 0x00364BB9 File Offset: 0x00362DB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06024ACC RID: 150220 RVA: 0x00364BC4 File Offset: 0x00362DC4
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

		// Token: 0x04013B79 RID: 80761
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013B7A RID: 80762
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.OnSceneColorCapturedDelegate__DelegateSignature";

		// Token: 0x04013B7B RID: 80763
		private static int RegisterId;

		// Token: 0x02003694 RID: 13972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017787 RID: 96135
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
