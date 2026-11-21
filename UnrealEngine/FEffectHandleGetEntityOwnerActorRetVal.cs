using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BC RID: 956
	public sealed class FEffectHandleGetEntityOwnerActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D96 RID: 23958 RVA: 0x0008446E File Offset: 0x0008266E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetEntityOwnerActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x0008447A File Offset: 0x0008267A
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetEntityOwnerActorRetVal__DelegateSignature");
			}
			return FEffectHandleGetEntityOwnerActorRetVal._FunctionPtr;
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x0008449D File Offset: 0x0008269D
		public FEffectHandleGetEntityOwnerActorRetVal()
		{
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x000844A5 File Offset: 0x000826A5
		[NullableContext(2)]
		public FEffectHandleGetEntityOwnerActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x000844AF File Offset: 0x000826AF
		public FEffectHandleGetEntityOwnerActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x000844BA File Offset: 0x000826BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, AActor>) ?? ((Func<int, AActor>)Delegate.CreateDelegate(typeof(Func<int, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x000844EC File Offset: 0x000826EC
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

		// Token: 0x06005D9D RID: 23965 RVA: 0x00084528 File Offset: 0x00082728
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe AActor Execute(int EntityId)
		{
			FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectHandleGetEntityOwnerActorRetVal.__FEffectHandleGetEntityOwnerActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetEntityOwnerActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x00084570 File Offset: 0x00082770
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002700 RID: 9984
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002701 RID: 9985
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetEntityOwnerActorRetVal__DelegateSignature";

		// Token: 0x04002702 RID: 9986
		private static int RegisterId;

		// Token: 0x02000AC2 RID: 2754
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FEffectHandleGetEntityOwnerActorRetVal_DelegateParams
		{
			// Token: 0x04005B32 RID: 23346
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B33 RID: 23347
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000AC3 RID: 2755
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B34 RID: 23348
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
