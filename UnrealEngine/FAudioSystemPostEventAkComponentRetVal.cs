using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200188F RID: 6287
	public sealed class FAudioSystemPostEventAkComponentRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017298 RID: 94872 RVA: 0x0021C2E3 File Offset: 0x0021A4E3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemPostEventAkComponentRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017299 RID: 94873 RVA: 0x0021C2EF File Offset: 0x0021A4EF
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemPostEventAkComponentRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemPostEventAkComponentRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemPostEventAkComponentRetVal__DelegateSignature");
			}
			return FAudioSystemPostEventAkComponentRetVal._FunctionPtr;
		}

		// Token: 0x0601729A RID: 94874 RVA: 0x0021C312 File Offset: 0x0021A512
		public FAudioSystemPostEventAkComponentRetVal()
		{
		}

		// Token: 0x0601729B RID: 94875 RVA: 0x0021C31A File Offset: 0x0021A51A
		[NullableContext(2)]
		public FAudioSystemPostEventAkComponentRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601729C RID: 94876 RVA: 0x0021C324 File Offset: 0x0021A524
		public FAudioSystemPostEventAkComponentRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601729D RID: 94877 RVA: 0x0021C32F File Offset: 0x0021A52F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UAkComponent, int>) ?? ((Func<string, UAkComponent, int>)Delegate.CreateDelegate(typeof(Func<string, UAkComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601729E RID: 94878 RVA: 0x0021C361 File Offset: 0x0021A561
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, UAkComponent, int> Callback)
		{
			if (FAudioSystemPostEventAkComponentRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemPostEventAkComponentRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemPostEventAkComponentRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemPostEventAkComponentRetVal.OnScriptCallback));
				}
				FAudioSystemPostEventAkComponentRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemPostEventAkComponentRetVal.RegisterId);
		}

		// Token: 0x0601729F RID: 94879 RVA: 0x0021C39C File Offset: 0x0021A59C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(string EventName, [Nullable(2)] UAkComponent AkComponent)
		{
			FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams* ptr = stackalloc FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemPostEventAkComponentRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			ptr->AkComponent = ((AkComponent != null) ? AkComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FAudioSystemPostEventAkComponentRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060172A0 RID: 94880 RVA: 0x0021C40C File Offset: 0x0021A60C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, UAkComponent, int> func = target as Func<string, UAkComponent, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->EventName));
			UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->AkComponent);
			int _Result = func(arg, orCreateUObjectByNativePointer);
			((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400C8F5 RID: 51445
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8F6 RID: 51446
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemPostEventAkComponentRetVal__DelegateSignature";

		// Token: 0x0400C8F7 RID: 51447
		private static int RegisterId;

		// Token: 0x02002F8E RID: 12174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FAudioSystemPostEventAkComponentRetVal_DelegateParams
		{
			// Token: 0x04016B54 RID: 93012
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04016B55 RID: 93013
			[FieldOffset(16)]
			public IntPtr AkComponent;

			// Token: 0x04016B56 RID: 93014
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02002F8F RID: 12175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B57 RID: 93015
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
