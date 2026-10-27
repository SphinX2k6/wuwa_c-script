using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C9D RID: 7325
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalWriteAchievementsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C706 RID: 116486 RVA: 0x002A03AE File Offset: 0x0029E5AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalWriteAchievementsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C707 RID: 116487 RVA: 0x002A03BA File Offset: 0x0029E5BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalWriteAchievementsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalWriteAchievementsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalWriteAchievementsDelegate__DelegateSignature");
			}
			return FSDKExternalWriteAchievementsDelegate._FunctionPtr;
		}

		// Token: 0x0601C708 RID: 116488 RVA: 0x002A03DD File Offset: 0x0029E5DD
		public FSDKExternalWriteAchievementsDelegate()
		{
		}

		// Token: 0x0601C709 RID: 116489 RVA: 0x002A03E5 File Offset: 0x0029E5E5
		[NullableContext(2)]
		public FSDKExternalWriteAchievementsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C70A RID: 116490 RVA: 0x002A03EF File Offset: 0x0029E5EF
		public FSDKExternalWriteAchievementsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C70B RID: 116491 RVA: 0x002A03FA File Offset: 0x0029E5FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TArray<string>>) ?? ((Action<bool, TArray<string>>)Delegate.CreateDelegate(typeof(Action<bool, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x002A042C File Offset: 0x0029E62C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, TArray<string>> Callback)
		{
			if (FSDKExternalWriteAchievementsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKExternalWriteAchievementsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKExternalWriteAchievementsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKExternalWriteAchievementsDelegate.OnScriptCallback));
				}
				FSDKExternalWriteAchievementsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKExternalWriteAchievementsDelegate.RegisterId);
		}

		// Token: 0x0601C70D RID: 116493 RVA: 0x002A0466 File Offset: 0x0029E666
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, TArray<string>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C70E RID: 116494 RVA: 0x002A0470 File Offset: 0x0029E670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> data)
		{
			FSDKExternalWriteAchievementsDelegate.__FSDKExternalWriteAchievementsDelegate_DelegateParams* ptr = stackalloc FSDKExternalWriteAchievementsDelegate.__FSDKExternalWriteAchievementsDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSDKExternalWriteAchievementsDelegate.__FSDKExternalWriteAchievementsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKExternalWriteAchievementsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			if (data != null)
			{
				data.CopyTo(&ptr->data, default(UScriptStructStackOnlyPtr));
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKExternalWriteAchievementsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C70F RID: 116495 RVA: 0x002A04D8 File Offset: 0x0029E6D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, TArray<string>> action = target as Action<bool, TArray<string>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> arg = new TArray<string>(&((FSDKExternalWriteAchievementsDelegate.__FSDKExternalWriteAchievementsDelegate_DelegateParams*)__Parameters)->data, true, true);
			action(((FSDKExternalWriteAchievementsDelegate.__FSDKExternalWriteAchievementsDelegate_DelegateParams*)__Parameters)->result, arg);
		}

		// Token: 0x0400F4B8 RID: 62648
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4B9 RID: 62649
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalWriteAchievementsDelegate__DelegateSignature";

		// Token: 0x0400F4BA RID: 62650
		private static int RegisterId;

		// Token: 0x0200326D RID: 12909
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSDKExternalWriteAchievementsDelegate_DelegateParams
		{
			// Token: 0x040170F0 RID: 94448
			[FieldOffset(0)]
			public bool result;

			// Token: 0x040170F1 RID: 94449
			[FieldOffset(8)]
			public byte data;
		}

		// Token: 0x0200326E RID: 12910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170F2 RID: 94450
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
