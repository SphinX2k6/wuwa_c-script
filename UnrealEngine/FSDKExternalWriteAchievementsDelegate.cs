using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000536 RID: 1334
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalWriteAchievementsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C43 RID: 31811 RVA: 0x000B7D62 File Offset: 0x000B5F62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalWriteAchievementsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x000B7D6E File Offset: 0x000B5F6E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalWriteAchievementsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalWriteAchievementsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalWriteAchievementsDelegate__DelegateSignature");
			}
			return FSDKExternalWriteAchievementsDelegate._FunctionPtr;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x000B7D91 File Offset: 0x000B5F91
		public FSDKExternalWriteAchievementsDelegate()
		{
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x000B7D99 File Offset: 0x000B5F99
		[NullableContext(2)]
		public FSDKExternalWriteAchievementsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x000B7DA3 File Offset: 0x000B5FA3
		public FSDKExternalWriteAchievementsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x000B7DAE File Offset: 0x000B5FAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TArray<string>>) ?? ((Action<bool, TArray<string>>)Delegate.CreateDelegate(typeof(Action<bool, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x000B7DE0 File Offset: 0x000B5FE0
		[NullableContext(1)]
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

		// Token: 0x06007C4A RID: 31818 RVA: 0x000B7E1A File Offset: 0x000B601A
		[NullableContext(1)]
		public void Remove(Action<bool, TArray<string>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x000B7E24 File Offset: 0x000B6024
		[SkipLocalsInit]
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

		// Token: 0x06007C4C RID: 31820 RVA: 0x000B7E8C File Offset: 0x000B608C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003522 RID: 13602
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003523 RID: 13603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalWriteAchievementsDelegate__DelegateSignature";

		// Token: 0x04003524 RID: 13604
		private static int RegisterId;

		// Token: 0x02000CE2 RID: 3298
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSDKExternalWriteAchievementsDelegate_DelegateParams
		{
			// Token: 0x04005F64 RID: 24420
			[FieldOffset(0)]
			public bool result;

			// Token: 0x04005F65 RID: 24421
			[FieldOffset(8)]
			public byte data;
		}

		// Token: 0x02000CE3 RID: 3299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F66 RID: 24422
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
