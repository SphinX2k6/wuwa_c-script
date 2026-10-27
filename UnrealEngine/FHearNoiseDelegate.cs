using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001CB RID: 459
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FHearNoiseDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001B23 RID: 6947 RVA: 0x00028793 File Offset: 0x00026993
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHearNoiseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0002879F File Offset: 0x0002699F
		private static IntPtr StaticFunctionPtr()
		{
			if (UPawnSensingComponent.__HearNoiseDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPawnSensingComponent.__HearNoiseDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature");
			}
			return UPawnSensingComponent.__HearNoiseDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000287C2 File Offset: 0x000269C2
		public FHearNoiseDelegate()
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000287CA File Offset: 0x000269CA
		[NullableContext(2)]
		public FHearNoiseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000287D4 File Offset: 0x000269D4
		public FHearNoiseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000287DF File Offset: 0x000269DF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APawn, FVector, float>) ?? ((Action<APawn, FVector, float>)Delegate.CreateDelegate(typeof(Action<APawn, FVector, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00028811 File Offset: 0x00026A11
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<APawn, FVector, float> Callback)
		{
			if (FHearNoiseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHearNoiseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHearNoiseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHearNoiseDelegate.OnScriptCallback));
				}
				FHearNoiseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FHearNoiseDelegate.RegisterId);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0002884B File Offset: 0x00026A4B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<APawn, FVector, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00028854 File Offset: 0x00026A54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(APawn Instigator, in FVector Location, float Volume)
		{
			FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams* ptr = stackalloc FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FHearNoiseDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instigator = ((Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
			ptr->Location = Location;
			ptr->Volume = Volume;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000288B4 File Offset: 0x00026AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APawn, FVector, float> action = target as Action<APawn, FVector, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(((FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams*)__Parameters)->Instigator);
			action(orCreateUObjectByNativePointer, ((FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams*)__Parameters)->Location, ((FHearNoiseDelegate.__FHearNoiseDelegate_DelegateParams*)__Parameters)->Volume);
		}

		// Token: 0x040008B0 RID: 2224
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature";

		// Token: 0x040008B1 RID: 2225
		private static int RegisterId;

		// Token: 0x02002B6A RID: 11114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FHearNoiseDelegate_DelegateParams
		{
			// Token: 0x040163EF RID: 91119
			[FieldOffset(0)]
			public IntPtr Instigator;

			// Token: 0x040163F0 RID: 91120
			[FieldOffset(8)]
			public FVector Location;

			// Token: 0x040163F1 RID: 91121
			[FieldOffset(20)]
			public float Volume;
		}

		// Token: 0x02002B6B RID: 11115
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040163F2 RID: 91122
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
