using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000443 RID: 1091
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroCheckProgress : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600694A RID: 26954 RVA: 0x00099D16 File Offset: 0x00097F16
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroCheckProgress.StaticFunctionPtr();
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00099D22 File Offset: 0x00097F22
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroCheckProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroCheckProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroCheckProgress__DelegateSignature");
			}
			return FKuroCheckProgress._FunctionPtr;
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00099D45 File Offset: 0x00097F45
		public FKuroCheckProgress()
		{
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00099D4D File Offset: 0x00097F4D
		[NullableContext(2)]
		public FKuroCheckProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00099D57 File Offset: 0x00097F57
		public FKuroCheckProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00099D62 File Offset: 0x00097F62
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00099D94 File Offset: 0x00097F94
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FKuroCheckProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroCheckProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroCheckProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroCheckProgress.OnScriptCallback));
				}
				FKuroCheckProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroCheckProgress.RegisterId);
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00099DCE File Offset: 0x00097FCE
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00099DD8 File Offset: 0x00097FD8
		[SkipLocalsInit]
		public unsafe void Broadcast(int Current, int Total)
		{
			FKuroCheckProgress.__FKuroCheckProgress_DelegateParams* ptr = stackalloc FKuroCheckProgress.__FKuroCheckProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroCheckProgress.__FKuroCheckProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroCheckProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Current = Current;
			ptr->Total = Total;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00099E1C File Offset: 0x0009801C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroCheckProgress.__FKuroCheckProgress_DelegateParams*)__Parameters)->Current, ((FKuroCheckProgress.__FKuroCheckProgress_DelegateParams*)__Parameters)->Total);
		}

		// Token: 0x04002CE2 RID: 11490
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CE3 RID: 11491
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckProgress__DelegateSignature";

		// Token: 0x04002CE4 RID: 11492
		private static int RegisterId;

		// Token: 0x02000B64 RID: 2916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FKuroCheckProgress_DelegateParams
		{
			// Token: 0x04005C7C RID: 23676
			[FieldOffset(0)]
			public int Current;

			// Token: 0x04005C7D RID: 23677
			[FieldOffset(4)]
			public int Total;
		}

		// Token: 0x02000B65 RID: 2917
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C7E RID: 23678
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
