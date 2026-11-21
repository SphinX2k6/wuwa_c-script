using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000234 RID: 564
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLevelStreamingVisibilityStatus : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002DBE RID: 11710 RVA: 0x00040B32 File Offset: 0x0003ED32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLevelStreamingVisibilityStatus.StaticFunctionPtr();
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00040B3E File Offset: 0x0003ED3E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLevelStreamingVisibilityStatus._FunctionPtr == IntPtr.Zero)
			{
				FLevelStreamingVisibilityStatus._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature");
			}
			return FLevelStreamingVisibilityStatus._FunctionPtr;
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00040B61 File Offset: 0x0003ED61
		public FLevelStreamingVisibilityStatus()
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00040B69 File Offset: 0x0003ED69
		[NullableContext(2)]
		public FLevelStreamingVisibilityStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00040B73 File Offset: 0x0003ED73
		public FLevelStreamingVisibilityStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00040B7E File Offset: 0x0003ED7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00040BB0 File Offset: 0x0003EDB0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FLevelStreamingVisibilityStatus.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLevelStreamingVisibilityStatus.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLevelStreamingVisibilityStatus.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLevelStreamingVisibilityStatus.OnScriptCallback));
				}
				FLevelStreamingVisibilityStatus.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLevelStreamingVisibilityStatus.RegisterId);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00040BEA File Offset: 0x0003EDEA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00040BF3 File Offset: 0x0003EDF3
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00040C00 File Offset: 0x0003EE00
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

		// Token: 0x04000EA7 RID: 3751
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000EA8 RID: 3752
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature";

		// Token: 0x04000EA9 RID: 3753
		private static int RegisterId;

		// Token: 0x020009B9 RID: 2489
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005940 RID: 22848
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
