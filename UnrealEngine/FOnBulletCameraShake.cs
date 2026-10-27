using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001707 RID: 5895
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBulletCameraShake : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015487 RID: 87175 RVA: 0x001F46EF File Offset: 0x001F28EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBulletCameraShake.StaticFunctionPtr();
		}

		// Token: 0x06015488 RID: 87176 RVA: 0x001F46FB File Offset: 0x001F28FB
		private static IntPtr StaticFunctionPtr()
		{
			if (UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBulletCore.BulletWorld:OnBulletCameraShake__DelegateSignature");
			}
			return UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06015489 RID: 87177 RVA: 0x001F471E File Offset: 0x001F291E
		public FOnBulletCameraShake()
		{
		}

		// Token: 0x0601548A RID: 87178 RVA: 0x001F4726 File Offset: 0x001F2926
		[NullableContext(2)]
		public FOnBulletCameraShake(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601548B RID: 87179 RVA: 0x001F4730 File Offset: 0x001F2930
		public FOnBulletCameraShake(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601548C RID: 87180 RVA: 0x001F473B File Offset: 0x001F293B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601548D RID: 87181 RVA: 0x001F476D File Offset: 0x001F296D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnBulletCameraShake.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBulletCameraShake.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBulletCameraShake.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBulletCameraShake.OnScriptCallback));
				}
				FOnBulletCameraShake.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBulletCameraShake.RegisterId);
		}

		// Token: 0x0601548E RID: 87182 RVA: 0x001F47A7 File Offset: 0x001F29A7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601548F RID: 87183 RVA: 0x001F47B0 File Offset: 0x001F29B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string ShakePath)
		{
			FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams* ptr = stackalloc FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBulletCameraShake.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ShakePath), ShakePath);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06015490 RID: 87184 RVA: 0x001F4804 File Offset: 0x001F2A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams*)__Parameters)->ShakePath));
			action(obj);
		}

		// Token: 0x0400B9A4 RID: 47524
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld:OnBulletCameraShake__DelegateSignature";

		// Token: 0x0400B9A5 RID: 47525
		private static int RegisterId;

		// Token: 0x02002EF2 RID: 12018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnBulletCameraShake_DelegateParams
		{
			// Token: 0x04016A27 RID: 92711
			[FieldOffset(0)]
			public FString ShakePath;
		}

		// Token: 0x02002EF3 RID: 12019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A28 RID: 92712
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
