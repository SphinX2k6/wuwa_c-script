using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020ED RID: 8429
	public sealed class FLocalTextNewDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FBCE RID: 129998 RVA: 0x002F302A File Offset: 0x002F122A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLocalTextNewDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FBCF RID: 129999 RVA: 0x002F3036 File Offset: 0x002F1236
		private static IntPtr StaticFunctionPtr()
		{
			if (FLocalTextNewDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLocalTextNewDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LocalTextNewDelegate__DelegateSignature");
			}
			return FLocalTextNewDelegate._FunctionPtr;
		}

		// Token: 0x0601FBD0 RID: 130000 RVA: 0x002F3059 File Offset: 0x002F1259
		public FLocalTextNewDelegate()
		{
		}

		// Token: 0x0601FBD1 RID: 130001 RVA: 0x002F3061 File Offset: 0x002F1261
		[NullableContext(2)]
		public FLocalTextNewDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBD2 RID: 130002 RVA: 0x002F306B File Offset: 0x002F126B
		public FLocalTextNewDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBD3 RID: 130003 RVA: 0x002F3076 File Offset: 0x002F1276
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UUIText, bool, string>) ?? ((Func<string, UUIText, bool, string>)Delegate.CreateDelegate(typeof(Func<string, UUIText, bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FBD4 RID: 130004 RVA: 0x002F30A8 File Offset: 0x002F12A8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FBD5 RID: 130005 RVA: 0x002F30E4 File Offset: 0x002F12E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FBD6 RID: 130006 RVA: 0x002F3164 File Offset: 0x002F1364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040111C0 RID: 70080
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111C1 RID: 70081
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LocalTextNewDelegate__DelegateSignature";

		// Token: 0x040111C2 RID: 70082
		private static int RegisterId;

		// Token: 0x020034D5 RID: 13525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FLocalTextNewDelegate_DelegateParams
		{
			// Token: 0x040174E5 RID: 95461
			[FieldOffset(0)]
			public FString TextKey;

			// Token: 0x040174E6 RID: 95462
			[FieldOffset(16)]
			public IntPtr uiText;

			// Token: 0x040174E7 RID: 95463
			[FieldOffset(24)]
			public bool isMainText;

			// Token: 0x040174E8 RID: 95464
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x020034D6 RID: 13526
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174E9 RID: 95465
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
