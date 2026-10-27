using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C6B RID: 3179
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInstigatedAnyDamageSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A1C1 RID: 41409 RVA: 0x000E5B7A File Offset: 0x000E3D7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInstigatedAnyDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x000E5B86 File Offset: 0x000E3D86
		private static IntPtr StaticFunctionPtr()
		{
			if (FInstigatedAnyDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FInstigatedAnyDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature");
			}
			return FInstigatedAnyDamageSignature._FunctionPtr;
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x000E5BA9 File Offset: 0x000E3DA9
		public FInstigatedAnyDamageSignature()
		{
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x000E5BB1 File Offset: 0x000E3DB1
		[NullableContext(2)]
		public FInstigatedAnyDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x000E5BBB File Offset: 0x000E3DBB
		public FInstigatedAnyDamageSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x000E5BC6 File Offset: 0x000E3DC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, UDamageType, AActor, AActor>) ?? ((Action<float, UDamageType, AActor, AActor>)Delegate.CreateDelegate(typeof(Action<float, UDamageType, AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x000E5BF8 File Offset: 0x000E3DF8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<float, UDamageType, AActor, AActor> Callback)
		{
			if (FInstigatedAnyDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInstigatedAnyDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInstigatedAnyDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInstigatedAnyDamageSignature.OnScriptCallback));
				}
				FInstigatedAnyDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInstigatedAnyDamageSignature.RegisterId);
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x000E5C32 File Offset: 0x000E3E32
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<float, UDamageType, AActor, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x000E5C3C File Offset: 0x000E3E3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
		{
			FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams* ptr = stackalloc FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInstigatedAnyDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Damage = Damage;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->DamagedActor = ((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x000E5CBC File Offset: 0x000E3EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, UDamageType, AActor, AActor> action = target as Action<float, UDamageType, AActor, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UDamageType orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams*)__Parameters)->DamageType);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams*)__Parameters)->DamagedActor);
			AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			action(((FInstigatedAnyDamageSignature.__FInstigatedAnyDamageSignature_DelegateParams*)__Parameters)->Damage, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
		}

		// Token: 0x040058CD RID: 22733
		internal static IntPtr _FunctionPtr;

		// Token: 0x040058CE RID: 22734
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature";

		// Token: 0x040058CF RID: 22735
		private static int RegisterId;

		// Token: 0x02002D17 RID: 11543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FInstigatedAnyDamageSignature_DelegateParams
		{
			// Token: 0x040166E3 RID: 91875
			[FieldOffset(0)]
			public float Damage;

			// Token: 0x040166E4 RID: 91876
			[FieldOffset(8)]
			public IntPtr DamageType;

			// Token: 0x040166E5 RID: 91877
			[FieldOffset(16)]
			public IntPtr DamagedActor;

			// Token: 0x040166E6 RID: 91878
			[FieldOffset(24)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002D18 RID: 11544
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040166E7 RID: 91879
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
