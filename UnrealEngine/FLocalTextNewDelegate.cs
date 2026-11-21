using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D1 RID: 1745
	public sealed class FLocalTextNewDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094B7 RID: 38071 RVA: 0x000E03CA File Offset: 0x000DE5CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLocalTextNewDelegate.StaticFunctionPtr();
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x000E03D6 File Offset: 0x000DE5D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLocalTextNewDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLocalTextNewDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LocalTextNewDelegate__DelegateSignature");
			}
			return FLocalTextNewDelegate._FunctionPtr;
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x000E03F9 File Offset: 0x000DE5F9
		public FLocalTextNewDelegate()
		{
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x000E0401 File Offset: 0x000DE601
		[NullableContext(2)]
		public FLocalTextNewDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x000E040B File Offset: 0x000DE60B
		public FLocalTextNewDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x000E0416 File Offset: 0x000DE616
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UUIText, bool, string>) ?? ((Func<string, UUIText, bool, string>)Delegate.CreateDelegate(typeof(Func<string, UUIText, bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x000E0448 File Offset: 0x000DE648
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<string, UUIText, bool, string> Callback)
		{
			if (FLocalTextNewDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLocalTextNewDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLocalTextNewDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLocalTextNewDelegate.OnScriptCallback));
				}
				FLocalTextNewDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLocalTextNewDelegate.RegisterId);
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x000E0484 File Offset: 0x000DE684
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string Execute(string TextKey, [Nullable(2)] UUIText uiText, bool isMainText)
		{
			FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams* ptr = stackalloc FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLocalTextNewDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->TextKey), TextKey);
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			ptr->isMainText = isMainText;
			base.ExecuteInternal((void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(FLocalTextNewDelegate._FunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x000E0504 File Offset: 0x000DE704
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, UUIText, bool, string> func = target as Func<string, UUIText, bool, string>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams*)__Parameters)->TextKey));
			UUIText orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(((FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams*)__Parameters)->uiText);
			string src = func(arg, orCreateUObjectByNativePointer, ((FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams*)__Parameters)->isMainText);
			FString.CopyFrom((void*)(&((FLocalTextNewDelegate.__FLocalTextNewDelegate_DelegateParams*)__Parameters)->__Result), src);
		}

		// Token: 0x040040B1 RID: 16561
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040B2 RID: 16562
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LocalTextNewDelegate__DelegateSignature";

		// Token: 0x040040B3 RID: 16563
		private static int RegisterId;

		// Token: 0x02000F01 RID: 3841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FLocalTextNewDelegate_DelegateParams
		{
			// Token: 0x040062CA RID: 25290
			[FieldOffset(0)]
			public FString TextKey;

			// Token: 0x040062CB RID: 25291
			[FieldOffset(16)]
			public IntPtr uiText;

			// Token: 0x040062CC RID: 25292
			[FieldOffset(24)]
			public bool isMainText;

			// Token: 0x040062CD RID: 25293
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x02000F02 RID: 3842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062CE RID: 25294
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
