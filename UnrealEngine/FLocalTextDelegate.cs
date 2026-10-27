using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020EC RID: 8428
	public sealed class FLocalTextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FBC5 RID: 129989 RVA: 0x002F2E7C File Offset: 0x002F107C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLocalTextDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FBC6 RID: 129990 RVA: 0x002F2E88 File Offset: 0x002F1088
		private static IntPtr StaticFunctionPtr()
		{
			if (FLocalTextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLocalTextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LocalTextDelegate__DelegateSignature");
			}
			return FLocalTextDelegate._FunctionPtr;
		}

		// Token: 0x0601FBC7 RID: 129991 RVA: 0x002F2EAB File Offset: 0x002F10AB
		public FLocalTextDelegate()
		{
		}

		// Token: 0x0601FBC8 RID: 129992 RVA: 0x002F2EB3 File Offset: 0x002F10B3
		[NullableContext(2)]
		public FLocalTextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBC9 RID: 129993 RVA: 0x002F2EBD File Offset: 0x002F10BD
		public FLocalTextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBCA RID: 129994 RVA: 0x002F2EC8 File Offset: 0x002F10C8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, int, UUIText, string>) ?? ((Func<string, int, UUIText, string>)Delegate.CreateDelegate(typeof(Func<string, int, UUIText, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FBCB RID: 129995 RVA: 0x002F2EFA File Offset: 0x002F10FA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FBCC RID: 129996 RVA: 0x002F2F34 File Offset: 0x002F1134
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FBCD RID: 129997 RVA: 0x002F2FB4 File Offset: 0x002F11B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040111BD RID: 70077
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111BE RID: 70078
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LocalTextDelegate__DelegateSignature";

		// Token: 0x040111BF RID: 70079
		private static int RegisterId;

		// Token: 0x020034D3 RID: 13523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FLocalTextDelegate_DelegateParams
		{
			// Token: 0x040174E0 RID: 95456
			[FieldOffset(0)]
			public FString TableName;

			// Token: 0x040174E1 RID: 95457
			[FieldOffset(16)]
			public int TextKey;

			// Token: 0x040174E2 RID: 95458
			[FieldOffset(24)]
			public IntPtr uiText;

			// Token: 0x040174E3 RID: 95459
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x020034D4 RID: 13524
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174E4 RID: 95460
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
