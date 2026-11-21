using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D0 RID: 1744
	public sealed class FLocalTextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094AE RID: 38062 RVA: 0x000E021B File Offset: 0x000DE41B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLocalTextDelegate.StaticFunctionPtr();
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x000E0227 File Offset: 0x000DE427
		private static IntPtr StaticFunctionPtr()
		{
			if (FLocalTextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLocalTextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LocalTextDelegate__DelegateSignature");
			}
			return FLocalTextDelegate._FunctionPtr;
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x000E024A File Offset: 0x000DE44A
		public FLocalTextDelegate()
		{
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x000E0252 File Offset: 0x000DE452
		[NullableContext(2)]
		public FLocalTextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x000E025C File Offset: 0x000DE45C
		public FLocalTextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x000E0267 File Offset: 0x000DE467
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, int, UUIText, string>) ?? ((Func<string, int, UUIText, string>)Delegate.CreateDelegate(typeof(Func<string, int, UUIText, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x000E0299 File Offset: 0x000DE499
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<string, int, UUIText, string> Callback)
		{
			if (FLocalTextDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLocalTextDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLocalTextDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLocalTextDelegate.OnScriptCallback));
				}
				FLocalTextDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLocalTextDelegate.RegisterId);
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x000E02D4 File Offset: 0x000DE4D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string Execute(string TableName, int TextKey, [Nullable(2)] UUIText uiText)
		{
			FLocalTextDelegate.__FLocalTextDelegate_DelegateParams* ptr = stackalloc FLocalTextDelegate.__FLocalTextDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FLocalTextDelegate.__FLocalTextDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLocalTextDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->TableName), TableName);
			ptr->TextKey = TextKey;
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(FLocalTextDelegate._FunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x000E0354 File Offset: 0x000DE554
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, int, UUIText, string> func = target as Func<string, int, UUIText, string>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLocalTextDelegate.__FLocalTextDelegate_DelegateParams*)__Parameters)->TableName));
			UUIText orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(((FLocalTextDelegate.__FLocalTextDelegate_DelegateParams*)__Parameters)->uiText);
			string src = func(arg, ((FLocalTextDelegate.__FLocalTextDelegate_DelegateParams*)__Parameters)->TextKey, orCreateUObjectByNativePointer);
			FString.CopyFrom((void*)(&((FLocalTextDelegate.__FLocalTextDelegate_DelegateParams*)__Parameters)->__Result), src);
		}

		// Token: 0x040040AE RID: 16558
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040AF RID: 16559
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LocalTextDelegate__DelegateSignature";

		// Token: 0x040040B0 RID: 16560
		private static int RegisterId;

		// Token: 0x02000EFF RID: 3839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FLocalTextDelegate_DelegateParams
		{
			// Token: 0x040062C5 RID: 25285
			[FieldOffset(0)]
			public FString TableName;

			// Token: 0x040062C6 RID: 25286
			[FieldOffset(16)]
			public int TextKey;

			// Token: 0x040062C7 RID: 25287
			[FieldOffset(24)]
			public IntPtr uiText;

			// Token: 0x040062C8 RID: 25288
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x02000F00 RID: 3840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062C9 RID: 25289
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
