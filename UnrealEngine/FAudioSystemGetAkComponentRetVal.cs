using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B2 RID: 946
	public sealed class FAudioSystemGetAkComponentRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D3A RID: 23866 RVA: 0x000835FC File Offset: 0x000817FC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemGetAkComponentRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x00083608 File Offset: 0x00081808
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemGetAkComponentRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemGetAkComponentRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemGetAkComponentRetVal__DelegateSignature");
			}
			return FAudioSystemGetAkComponentRetVal._FunctionPtr;
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x0008362B File Offset: 0x0008182B
		public FAudioSystemGetAkComponentRetVal()
		{
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00083633 File Offset: 0x00081833
		[NullableContext(2)]
		public FAudioSystemGetAkComponentRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x0008363D File Offset: 0x0008183D
		public FAudioSystemGetAkComponentRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x00083648 File Offset: 0x00081848
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool, AActor, UAkComponent>) ?? ((Func<bool, AActor, UAkComponent>)Delegate.CreateDelegate(typeof(Func<bool, AActor, UAkComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x0008367A File Offset: 0x0008187A
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

		// Token: 0x06005D41 RID: 23873 RVA: 0x000836B4 File Offset: 0x000818B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UAkComponent Execute(bool FromPrimaryRole, AActor Actor)
		{
			FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams* ptr = stackalloc FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FAudioSystemGetAkComponentRetVal.__FAudioSystemGetAkComponentRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemGetAkComponentRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FromPrimaryRole = FromPrimaryRole;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(ptr->__Result);
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00083714 File Offset: 0x00081914
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040026DB RID: 9947
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026DC RID: 9948
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemGetAkComponentRetVal__DelegateSignature";

		// Token: 0x040026DD RID: 9949
		private static int RegisterId;

		// Token: 0x02000AAF RID: 2735
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FAudioSystemGetAkComponentRetVal_DelegateParams
		{
			// Token: 0x04005B0D RID: 23309
			[FieldOffset(0)]
			public bool FromPrimaryRole;

			// Token: 0x04005B0E RID: 23310
			[FieldOffset(8)]
			public IntPtr Actor;

			// Token: 0x04005B0F RID: 23311
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000AB0 RID: 2736
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B10 RID: 23312
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
