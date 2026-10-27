using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E92 RID: 7826
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FClassLoadedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC47 RID: 121927 RVA: 0x002BFBEE File Offset: 0x002BDDEE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FClassLoadedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC48 RID: 121928 RVA: 0x002BFBFA File Offset: 0x002BDDFA
		private static IntPtr StaticFunctionPtr()
		{
			if (FClassLoadedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FClassLoadedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.ClassLoadedDelegate__DelegateSignature");
			}
			return FClassLoadedDelegate._FunctionPtr;
		}

		// Token: 0x0601DC49 RID: 121929 RVA: 0x002BFC1D File Offset: 0x002BDE1D
		public FClassLoadedDelegate()
		{
		}

		// Token: 0x0601DC4A RID: 121930 RVA: 0x002BFC25 File Offset: 0x002BDE25
		[NullableContext(2)]
		public FClassLoadedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC4B RID: 121931 RVA: 0x002BFC2F File Offset: 0x002BDE2F
		public FClassLoadedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC4C RID: 121932 RVA: 0x002BFC3A File Offset: 0x002BDE3A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate) ?? ((FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC4D RID: 121933 RVA: 0x002BFC6C File Offset: 0x002BDE6C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate Callback)
		{
			if (FClassLoadedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FClassLoadedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FClassLoadedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FClassLoadedDelegate.OnScriptCallback));
				}
				FClassLoadedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FClassLoadedDelegate.RegisterId);
		}

		// Token: 0x0601DC4E RID: 121934 RVA: 0x002BFCA6 File Offset: 0x002BDEA6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC4F RID: 121935 RVA: 0x002BFCB0 File Offset: 0x002BDEB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UClassStackOnlyPtr ClassLoaded, UObject UserData)
		{
			FClassLoadedDelegate.__FClassLoadedDelegate_DelegateParams* ptr = stackalloc FClassLoadedDelegate.__FClassLoadedDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FClassLoadedDelegate.__FClassLoadedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FClassLoadedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ClassLoaded = ClassLoaded;
			ptr->UserData = ((UserData != null) ? UserData.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601DC50 RID: 121936 RVA: 0x002BFD04 File Offset: 0x002BDF04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate fclassLoadedDelegate_ScriptDelegate = target as FClassLoadedDelegate.FClassLoadedDelegate_ScriptDelegate;
			if (fclassLoadedDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FClassLoadedDelegate.__FClassLoadedDelegate_DelegateParams*)__Parameters)->UserData);
			fclassLoadedDelegate_ScriptDelegate(((FClassLoadedDelegate.__FClassLoadedDelegate_DelegateParams*)__Parameters)->ClassLoaded, orCreateUObjectByNativePointer);
		}

		// Token: 0x040101D8 RID: 66008
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101D9 RID: 66009
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.ClassLoadedDelegate__DelegateSignature";

		// Token: 0x040101DA RID: 66010
		private static int RegisterId;

		// Token: 0x020032DE RID: 13022
		// (Invoke) Token: 0x060285A2 RID: 165282
		public delegate void FClassLoadedDelegate_ScriptDelegate(UClassStackOnlyPtr ClassLoaded, UObject UserData);

		// Token: 0x020032DF RID: 13023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FClassLoadedDelegate_DelegateParams
		{
			// Token: 0x0401718B RID: 94603
			[FieldOffset(0)]
			public UClassStackOnlyPtr ClassLoaded;

			// Token: 0x0401718C RID: 94604
			[FieldOffset(8)]
			public IntPtr UserData;
		}

		// Token: 0x020032E0 RID: 13024
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401718D RID: 94605
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
