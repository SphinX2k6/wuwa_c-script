using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001899 RID: 6297
	public sealed class FEffectHandleGetEntityOwnerActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172EB RID: 94955 RVA: 0x0021CFD2 File Offset: 0x0021B1D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetEntityOwnerActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172EC RID: 94956 RVA: 0x0021CFDE File Offset: 0x0021B1DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetEntityOwnerActorRetVal__DelegateSignature");
			}
			return FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr;
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0021D001 File Offset: 0x0021B201
		public FEffectHandleGetEntityOwnerActorRetVal()
		{
		}

		// Token: 0x060172EE RID: 94958 RVA: 0x0021D009 File Offset: 0x0021B209
		[NullableContext(2)]
		public FEffectHandleGetEntityOwnerActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x0021D013 File Offset: 0x0021B213
		public FEffectHandleGetEntityOwnerActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172F0 RID: 94960 RVA: 0x0021D01E File Offset: 0x0021B21E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, AActor>) ?? ((Func<int, AActor>)Delegate.CreateDelegate(typeof(Func<int, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172F1 RID: 94961 RVA: 0x0021D050 File Offset: 0x0021B250
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<int, AActor> Callback)
		{
			if (FEffectHandleGetEntityOwnerActorRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectHandleGetEntityOwnerActorRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectHandleGetEntityOwnerActorRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectHandleGetEntityOwnerActorRetVal.OnScriptCallback));
				}
				FEffectHandleGetEntityOwnerActorRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectHandleGetEntityOwnerActorRetVal.RegisterId);
		}

		// Token: 0x060172F2 RID: 94962 RVA: 0x0021D08C File Offset: 0x0021B28C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe AActor Execute(int EntityId)
		{
			FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetEntityOwnerActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x060172F3 RID: 94963 RVA: 0x0021D0D4 File Offset: 0x0021B2D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, AActor> func = target as Func<int, AActor>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor aactor = func(((FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams*)__Parameters)->EntityId);
			((FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams*)__Parameters)->__Result = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400C931 RID: 51505
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C932 RID: 51506
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetEntityOwnerActorRetVal__DelegateSignature";

		// Token: 0x0400C933 RID: 51507
		private static int RegisterId;

		// Token: 0x02002F9F RID: 12191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FEffectHandleGetEntityOwnerActorRetVal_DelegateParams
		{
			// Token: 0x04016B75 RID: 93045
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016B76 RID: 93046
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002FA0 RID: 12192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B77 RID: 93047
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
