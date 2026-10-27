using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C9C RID: 7324
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalQueryAchievementsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6FC RID: 116476 RVA: 0x002A0228 File Offset: 0x0029E428
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalQueryAchievementsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6FD RID: 116477 RVA: 0x002A0234 File Offset: 0x0029E434
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalQueryAchievementsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalQueryAchievementsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalQueryAchievementsDelegate__DelegateSignature");
			}
			return FSDKExternalQueryAchievementsDelegate._FunctionPtr;
		}

		// Token: 0x0601C6FE RID: 116478 RVA: 0x002A0257 File Offset: 0x0029E457
		public FSDKExternalQueryAchievementsDelegate()
		{
		}

		// Token: 0x0601C6FF RID: 116479 RVA: 0x002A025F File Offset: 0x0029E45F
		[NullableContext(2)]
		public FSDKExternalQueryAchievementsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C700 RID: 116480 RVA: 0x002A0269 File Offset: 0x0029E469
		public FSDKExternalQueryAchievementsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C701 RID: 116481 RVA: 0x002A0274 File Offset: 0x0029E474
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TArray<FAchievementStruct>>) ?? ((Action<bool, TArray<FAchievementStruct>>)Delegate.CreateDelegate(typeof(Action<bool, TArray<FAchievementStruct>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C702 RID: 116482 RVA: 0x002A02A6 File Offset: 0x0029E4A6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, TArray<FAchievementStruct>> Callback)
		{
			if (FSDKExternalQueryAchievementsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKExternalQueryAchievementsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKExternalQueryAchievementsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKExternalQueryAchievementsDelegate.OnScriptCallback));
				}
				FSDKExternalQueryAchievementsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKExternalQueryAchievementsDelegate.RegisterId);
		}

		// Token: 0x0601C703 RID: 116483 RVA: 0x002A02E0 File Offset: 0x0029E4E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, TArray<FAchievementStruct>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C704 RID: 116484 RVA: 0x002A02EC File Offset: 0x0029E4EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FAchievementStruct> data)
		{
			FSDKExternalQueryAchievementsDelegate.__FSDKExternalQueryAchievementsDelegate_DelegateParams* ptr = stackalloc FSDKExternalQueryAchievementsDelegate.__FSDKExternalQueryAchievementsDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSDKExternalQueryAchievementsDelegate.__FSDKExternalQueryAchievementsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKExternalQueryAchievementsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			if (data != null)
			{
				data.CopyTo(&ptr->data, default(UScriptStructStackOnlyPtr));
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKExternalQueryAchievementsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C705 RID: 116485 RVA: 0x002A0354 File Offset: 0x0029E554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, TArray<FAchievementStruct>> action = target as Action<bool, TArray<FAchievementStruct>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FAchievementStruct> arg = new TArray<FAchievementStruct>(&((FSDKExternalQueryAchievementsDelegate.__FSDKExternalQueryAchievementsDelegate_DelegateParams*)__Parameters)->data, true, true);
			action(((FSDKExternalQueryAchievementsDelegate.__FSDKExternalQueryAchievementsDelegate_DelegateParams*)__Parameters)->result, arg);
		}

		// Token: 0x0400F4B5 RID: 62645
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4B6 RID: 62646
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalQueryAchievementsDelegate__DelegateSignature";

		// Token: 0x0400F4B7 RID: 62647
		private static int RegisterId;

		// Token: 0x0200326B RID: 12907
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSDKExternalQueryAchievementsDelegate_DelegateParams
		{
			// Token: 0x040170ED RID: 94445
			[FieldOffset(0)]
			public bool result;

			// Token: 0x040170EE RID: 94446
			[FieldOffset(8)]
			public byte data;
		}

		// Token: 0x0200326C RID: 12908
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170EF RID: 94447
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
