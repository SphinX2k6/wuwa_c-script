using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200188E RID: 6286
	public sealed class FAudioSystemGetAkComponentRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601728F RID: 94863 RVA: 0x0021C15C File Offset: 0x0021A35C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemGetAkComponentRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017290 RID: 94864 RVA: 0x0021C168 File Offset: 0x0021A368
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemGetAkComponentRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemGetAkComponentRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemGetAkComponentRetVal__DelegateSignature");
			}
			return FAudioSystemGetAkComponentRetVal._FunctionPtr;
		}

		// Token: 0x06017291 RID: 94865 RVA: 0x0021C18B File Offset: 0x0021A38B
		public FAudioSystemGetAkComponentRetVal()
		{
		}

		// Token: 0x06017292 RID: 94866 RVA: 0x0021C193 File Offset: 0x0021A393
		[NullableContext(2)]
		public FAudioSystemGetAkComponentRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017293 RID: 94867 RVA: 0x0021C19D File Offset: 0x0021A39D
		public FAudioSystemGetAkComponentRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017294 RID: 94868 RVA: 0x0021C1A8 File Offset: 0x0021A3A8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool, AActor, UAkComponent>) ?? ((Func<bool, AActor, UAkComponent>)Delegate.CreateDelegate(typeof(Func<bool, AActor, UAkComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017295 RID: 94869 RVA: 0x0021C1DA File Offset: 0x0021A3DA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<bool, AActor, UAkComponent> Callback)
		{
			if (FAudioSystemGetAkComponentRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemGetAkComponentRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemGetAkComponentRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemGetAkComponentRetVal.OnScriptCallback));
				}
				FAudioSystemGetAkComponentRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemGetAkComponentRetVal.RegisterId);
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x0021C214 File Offset: 0x0021A414
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UAkComponent Execute(bool FromPrimaryRole, AActor Actor)
		{
			FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams* ptr = stackalloc FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemGetAkComponentRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FromPrimaryRole = FromPrimaryRole;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(ptr->__Result);
		}

		// Token: 0x06017297 RID: 94871 RVA: 0x0021C274 File Offset: 0x0021A474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<bool, AActor, UAkComponent> func = target as Func<bool, AActor, UAkComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams*)__Parameters)->Actor);
			UAkComponent uakComponent = func(((FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams*)__Parameters)->FromPrimaryRole, orCreateUObjectByNativePointer);
			((FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams*)__Parameters)->__Result = ((uakComponent != null) ? uakComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400C8F2 RID: 51442
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8F3 RID: 51443
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemGetAkComponentRetVal__DelegateSignature";

		// Token: 0x0400C8F4 RID: 51444
		private static int RegisterId;

		// Token: 0x02002F8C RID: 12172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FAudioSystemGetAkComponentRetVal_DelegateParams
		{
			// Token: 0x04016B50 RID: 93008
			[FieldOffset(0)]
			public bool FromPrimaryRole;

			// Token: 0x04016B51 RID: 93009
			[FieldOffset(8)]
			public IntPtr Actor;

			// Token: 0x04016B52 RID: 93010
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002F8D RID: 12173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B53 RID: 93011
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
