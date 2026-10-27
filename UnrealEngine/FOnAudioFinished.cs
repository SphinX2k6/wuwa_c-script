using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F05 RID: 3845
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D022 RID: 53282 RVA: 0x0012FBC0 File Offset: 0x0012DDC0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioFinished.StaticFunctionPtr();
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x0012FBCC File Offset: 0x0012DDCC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioFinished__DelegateSignature");
			}
			return FOnAudioFinished._FunctionPtr;
		}

		// Token: 0x0600D024 RID: 53284 RVA: 0x0012FBEF File Offset: 0x0012DDEF
		public FOnAudioFinished()
		{
		}

		// Token: 0x0600D025 RID: 53285 RVA: 0x0012FBF7 File Offset: 0x0012DDF7
		[NullableContext(2)]
		public FOnAudioFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D026 RID: 53286 RVA: 0x0012FC01 File Offset: 0x0012DE01
		public FOnAudioFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D027 RID: 53287 RVA: 0x0012FC0C File Offset: 0x0012DE0C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D028 RID: 53288 RVA: 0x0012FC3E File Offset: 0x0012DE3E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnAudioFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioFinished.OnScriptCallback));
				}
				FOnAudioFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioFinished.RegisterId);
		}

		// Token: 0x0600D029 RID: 53289 RVA: 0x0012FC78 File Offset: 0x0012DE78
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x0012FC81 File Offset: 0x0012DE81
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600D02B RID: 53291 RVA: 0x0012FC8C File Offset: 0x0012DE8C
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

		// Token: 0x04007024 RID: 28708
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007025 RID: 28709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioFinished__DelegateSignature";

		// Token: 0x04007026 RID: 28710
		private static int RegisterId;

		// Token: 0x02002D5A RID: 11610
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401676E RID: 92014
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
