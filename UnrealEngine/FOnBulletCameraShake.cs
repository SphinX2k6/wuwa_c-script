using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032C RID: 812
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBulletCameraShake : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060054FB RID: 21755 RVA: 0x00076E47 File Offset: 0x00075047
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBulletCameraShake.StaticFunctionPtr();
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00076E53 File Offset: 0x00075053
		private static IntPtr StaticFunctionPtr()
		{
			if (UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBulletCore.BulletWorld:OnBulletCameraShake__DelegateSignature");
			}
			return UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00076E76 File Offset: 0x00075076
		public FOnBulletCameraShake()
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00076E7E File Offset: 0x0007507E
		[NullableContext(2)]
		public FOnBulletCameraShake(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00076E88 File Offset: 0x00075088
		public FOnBulletCameraShake(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00076E93 File Offset: 0x00075093
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x00076EC5 File Offset: 0x000750C5
		[NullableContext(1)]
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

		// Token: 0x06005502 RID: 21762 RVA: 0x00076EFF File Offset: 0x000750FF
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00076F08 File Offset: 0x00075108
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string ShakePath)
		{
			FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams* ptr = stackalloc FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnBulletCameraShake.__FOnBulletCameraShake_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBulletCameraShake.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ShakePath), ShakePath);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UBulletWorld.__OnBulletCameraShake__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00076F5C File Offset: 0x0007515C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040022B9 RID: 8889
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld:OnBulletCameraShake__DelegateSignature";

		// Token: 0x040022BA RID: 8890
		private static int RegisterId;

		// Token: 0x02000A27 RID: 2599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnBulletCameraShake_DelegateParams
		{
			// Token: 0x040059FB RID: 23035
			[FieldOffset(0)]
			public FString ShakePath;
		}

		// Token: 0x02000A28 RID: 2600
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059FC RID: 23036
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
