using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000753 RID: 1875
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A3DF RID: 41951 RVA: 0x000F1DD3 File Offset: 0x000EFFD3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaEvent.StaticFunctionPtr();
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x000F1DDF File Offset: 0x000EFFDF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature");
			}
			return FOnMediaPlayerMediaEvent._FunctionPtr;
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x000F1E02 File Offset: 0x000F0002
		public FOnMediaPlayerMediaEvent()
		{
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x000F1E0A File Offset: 0x000F000A
		[NullableContext(2)]
		public FOnMediaPlayerMediaEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x000F1E14 File Offset: 0x000F0014
		public FOnMediaPlayerMediaEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x000F1E1F File Offset: 0x000F001F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x000F1E51 File Offset: 0x000F0051
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnMediaPlayerMediaEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMediaPlayerMediaEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMediaPlayerMediaEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMediaPlayerMediaEvent.OnScriptCallback));
				}
				FOnMediaPlayerMediaEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMediaPlayerMediaEvent.RegisterId);
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x000F1E8B File Offset: 0x000F008B
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x000F1E94 File Offset: 0x000F0094
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x000F1EA0 File Offset: 0x000F00A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040045E8 RID: 17896
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045E9 RID: 17897
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature";

		// Token: 0x040045EA RID: 17898
		private static int RegisterId;

		// Token: 0x02000F3F RID: 3903
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006313 RID: 25363
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
