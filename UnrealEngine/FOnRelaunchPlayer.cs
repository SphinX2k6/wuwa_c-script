using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200059E RID: 1438
	public sealed class FOnRelaunchPlayer : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008214 RID: 33300 RVA: 0x000C0406 File Offset: 0x000BE606
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRelaunchPlayer.StaticFunctionPtr();
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x000C0412 File Offset: 0x000BE612
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRelaunchPlayer._FunctionPtr == IntPtr.Zero)
			{
				FOnRelaunchPlayer._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnRelaunchPlayer__DelegateSignature");
			}
			return FOnRelaunchPlayer._FunctionPtr;
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x000C0435 File Offset: 0x000BE635
		public FOnRelaunchPlayer()
		{
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x000C043D File Offset: 0x000BE63D
		[NullableContext(2)]
		public FOnRelaunchPlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x000C0447 File Offset: 0x000BE647
		public FOnRelaunchPlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x000C0452 File Offset: 0x000BE652
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x000C0484 File Offset: 0x000BE684
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnRelaunchPlayer.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRelaunchPlayer.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRelaunchPlayer.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRelaunchPlayer.OnScriptCallback));
				}
				FOnRelaunchPlayer.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnRelaunchPlayer.RegisterId);
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x000C04BE File Offset: 0x000BE6BE
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x000C04CC File Offset: 0x000BE6CC
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

		// Token: 0x040038B9 RID: 14521
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038BA RID: 14522
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnRelaunchPlayer__DelegateSignature";

		// Token: 0x040038BB RID: 14523
		private static int RegisterId;

		// Token: 0x02000D1F RID: 3359
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB0 RID: 24496
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
