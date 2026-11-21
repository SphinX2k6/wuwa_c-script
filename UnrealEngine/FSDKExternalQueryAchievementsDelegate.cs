using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000535 RID: 1333
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalQueryAchievementsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C39 RID: 31801 RVA: 0x000B7BDC File Offset: 0x000B5DDC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalQueryAchievementsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x000B7BE8 File Offset: 0x000B5DE8
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalQueryAchievementsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalQueryAchievementsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalQueryAchievementsDelegate__DelegateSignature");
			}
			return FSDKExternalQueryAchievementsDelegate._FunctionPtr;
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x000B7C0B File Offset: 0x000B5E0B
		public FSDKExternalQueryAchievementsDelegate()
		{
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x000B7C13 File Offset: 0x000B5E13
		[NullableContext(2)]
		public FSDKExternalQueryAchievementsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x000B7C1D File Offset: 0x000B5E1D
		public FSDKExternalQueryAchievementsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x000B7C28 File Offset: 0x000B5E28
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TArray<FAchievementStruct>>) ?? ((Action<bool, TArray<FAchievementStruct>>)Delegate.CreateDelegate(typeof(Action<bool, TArray<FAchievementStruct>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x000B7C5A File Offset: 0x000B5E5A
		[NullableContext(1)]
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

		// Token: 0x06007C40 RID: 31808 RVA: 0x000B7C94 File Offset: 0x000B5E94
		[NullableContext(1)]
		public void Remove(Action<bool, TArray<FAchievementStruct>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x000B7CA0 File Offset: 0x000B5EA0
		[SkipLocalsInit]
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

		// Token: 0x06007C42 RID: 31810 RVA: 0x000B7D08 File Offset: 0x000B5F08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400351F RID: 13599
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003520 RID: 13600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalQueryAchievementsDelegate__DelegateSignature";

		// Token: 0x04003521 RID: 13601
		private static int RegisterId;

		// Token: 0x02000CE0 RID: 3296
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSDKExternalQueryAchievementsDelegate_DelegateParams
		{
			// Token: 0x04005F61 RID: 24417
			[FieldOffset(0)]
			public bool result;

			// Token: 0x04005F62 RID: 24418
			[FieldOffset(8)]
			public byte data;
		}

		// Token: 0x02000CE1 RID: 3297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F63 RID: 24419
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
