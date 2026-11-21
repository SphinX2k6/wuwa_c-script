using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000511 RID: 1297
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLineHitTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007954 RID: 31060 RVA: 0x000B203A File Offset: 0x000B023A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLineHitTrigger.StaticFunctionPtr();
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x000B2046 File Offset: 0x000B0246
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLineHitTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnLineHitTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnLineHitTrigger__DelegateSignature");
			}
			return FOnLineHitTrigger._FunctionPtr;
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x000B2069 File Offset: 0x000B0269
		public FOnLineHitTrigger()
		{
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x000B2071 File Offset: 0x000B0271
		[NullableContext(2)]
		public FOnLineHitTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x000B207B File Offset: 0x000B027B
		public FOnLineHitTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x000B2086 File Offset: 0x000B0286
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x000B20B8 File Offset: 0x000B02B8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnLineHitTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLineHitTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLineHitTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLineHitTrigger.OnScriptCallback));
				}
				FOnLineHitTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLineHitTrigger.RegisterId);
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x000B20F2 File Offset: 0x000B02F2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x000B20FB File Offset: 0x000B02FB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x000B2108 File Offset: 0x000B0308
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

		// Token: 0x04003390 RID: 13200
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003391 RID: 13201
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnLineHitTrigger__DelegateSignature";

		// Token: 0x04003392 RID: 13202
		private static int RegisterId;

		// Token: 0x02000C79 RID: 3193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ED6 RID: 24278
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
