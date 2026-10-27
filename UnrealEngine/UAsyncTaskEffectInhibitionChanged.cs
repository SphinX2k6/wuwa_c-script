using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001952 RID: 6482
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectInhibitionChanged")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAsyncTaskEffectInhibitionChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018046 RID: 98374 RVA: 0x00233EB8 File Offset: 0x002320B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectInhibitionChanged._ClassPtr;
		}

		// Token: 0x06018047 RID: 98375 RVA: 0x00233EC4 File Offset: 0x002320C4
		public UAsyncTaskEffectInhibitionChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectInhibitionChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018048 RID: 98376 RVA: 0x00233EEC File Offset: 0x002320EC
		public UAsyncTaskEffectInhibitionChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectInhibitionChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x06018049 RID: 98377 RVA: 0x00233F20 File Offset: 0x00232120
		// (set) Token: 0x0601804A RID: 98378 RVA: 0x00233F59 File Offset: 0x00232159
		public FOnInhibitionChanged OnInhibitionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnInhibitionChanged result;
				if ((result = this._OnInhibitionChanged) == null)
				{
					result = (this._OnInhibitionChanged = new FOnInhibitionChanged(base.NativePtr + (IntPtr)UAsyncTaskEffectInhibitionChanged.__PropertyOffset_OnInhibitionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskEffectInhibitionChanged.__PropertyOffset_OnInhibitionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601804B RID: 98379 RVA: 0x00233F7C File Offset: 0x0023217C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskEffectInhibitionChanged ListenForInhibitionChanged(FActiveGameplayEffectHandle Handle)
		{
			UAsyncTaskEffectInhibitionChanged.__ListenForInhibitionChanged_FunctionParams* ptr = stackalloc UAsyncTaskEffectInhibitionChanged.__ListenForInhibitionChanged_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskEffectInhibitionChanged.__ListenForInhibitionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectInhibitionChanged.__ListenForInhibitionChanged_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectInhibitionChanged._ClassDefaultObjectPtr, UAsyncTaskEffectInhibitionChanged.__ListenForInhibitionChanged_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectInhibitionChanged>(ptr->__Result);
		}

		// Token: 0x0601804C RID: 98380 RVA: 0x00233FE8 File Offset: 0x002321E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectInhibitionChanged.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601804D RID: 98381 RVA: 0x00233FFD File Offset: 0x002321FD
		static UAsyncTaskEffectInhibitionChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectInhibitionChanged");
		}

		// Token: 0x0601804E RID: 98382 RVA: 0x0023400B File Offset: 0x0023220B
		protected UAsyncTaskEffectInhibitionChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFDD RID: 53213
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectInhibitionChanged";

		// Token: 0x0400CFDE RID: 53214
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFDF RID: 53215
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFE0 RID: 53216
		internal static int __PropertyOffset_OnInhibitionChanged;

		// Token: 0x0400CFE1 RID: 53217
		[Nullable(2)]
		private FOnInhibitionChanged _OnInhibitionChanged;

		// Token: 0x0400CFE2 RID: 53218
		private static IntPtr __ListenForInhibitionChanged_NativeFunctionPtr;

		// Token: 0x0400CFE3 RID: 53219
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003023 RID: 12323
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForInhibitionChanged_FunctionParams
		{
			// Token: 0x04016C5F RID: 93279
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016C60 RID: 93280
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
