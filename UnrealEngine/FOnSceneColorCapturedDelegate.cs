using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007C1 RID: 1985
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSceneColorCapturedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ABD0 RID: 43984 RVA: 0x000FD661 File Offset: 0x000FB861
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneColorCapturedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x000FD66D File Offset: 0x000FB86D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSceneColorCapturedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSceneColorCapturedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Renderer.OnSceneColorCapturedDelegate__DelegateSignature");
			}
			return FOnSceneColorCapturedDelegate._FunctionPtr;
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x000FD690 File Offset: 0x000FB890
		public FOnSceneColorCapturedDelegate()
		{
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x000FD698 File Offset: 0x000FB898
		[NullableContext(2)]
		public FOnSceneColorCapturedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x000FD6A2 File Offset: 0x000FB8A2
		public FOnSceneColorCapturedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x000FD6AD File Offset: 0x000FB8AD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x000FD6DF File Offset: 0x000FB8DF
		[NullableContext(1)]
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

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x000FD719 File Offset: 0x000FB919
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x000FD722 File Offset: 0x000FB922
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x000FD72C File Offset: 0x000FB92C
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

		// Token: 0x040049E2 RID: 18914
		internal static IntPtr _FunctionPtr;

		// Token: 0x040049E3 RID: 18915
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.OnSceneColorCapturedDelegate__DelegateSignature";

		// Token: 0x040049E4 RID: 18916
		private static int RegisterId;

		// Token: 0x02000F6E RID: 3950
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006348 RID: 25416
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
