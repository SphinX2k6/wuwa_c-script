using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000440 RID: 1088
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroCheckComplete : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600691A RID: 26906 RVA: 0x000998DE File Offset: 0x00097ADE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroCheckComplete.StaticFunctionPtr();
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x000998EA File Offset: 0x00097AEA
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroCheckComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroCheckComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroCheckComplete__DelegateSignature");
			}
			return FKuroCheckComplete._FunctionPtr;
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0009990D File Offset: 0x00097B0D
		public FKuroCheckComplete()
		{
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00099915 File Offset: 0x00097B15
		[NullableContext(2)]
		public FKuroCheckComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x0009991F File Offset: 0x00097B1F
		public FKuroCheckComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x0009992A File Offset: 0x00097B2A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x0009995C File Offset: 0x00097B5C
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FKuroCheckComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroCheckComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroCheckComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroCheckComplete.OnScriptCallback));
				}
				FKuroCheckComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroCheckComplete.RegisterId);
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00099996 File Offset: 0x00097B96
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x0009999F File Offset: 0x00097B9F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x000999AC File Offset: 0x00097BAC
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

		// Token: 0x04002CCC RID: 11468
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CCD RID: 11469
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckComplete__DelegateSignature";

		// Token: 0x04002CCE RID: 11470
		private static int RegisterId;

		// Token: 0x02000B63 RID: 2915
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C7B RID: 23675
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
