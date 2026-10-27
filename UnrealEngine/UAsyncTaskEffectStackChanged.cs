using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001953 RID: 6483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectStackChanged")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAsyncTaskEffectStackChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601804F RID: 98383 RVA: 0x00234014 File Offset: 0x00232214
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectStackChanged._ClassPtr;
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x00234020 File Offset: 0x00232220
		public UAsyncTaskEffectStackChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectStackChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018051 RID: 98385 RVA: 0x00234048 File Offset: 0x00232248
		public UAsyncTaskEffectStackChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectStackChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x06018052 RID: 98386 RVA: 0x0023407C File Offset: 0x0023227C
		// (set) Token: 0x06018053 RID: 98387 RVA: 0x002340B5 File Offset: 0x002322B5
		public FOnStackChanged OnStackChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnStackChanged result;
				if ((result = this._OnStackChanged) == null)
				{
					result = (this._OnStackChanged = new FOnStackChanged(base.NativePtr + (IntPtr)UAsyncTaskEffectStackChanged.__PropertyOffset_OnStackChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskEffectStackChanged.__PropertyOffset_OnStackChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06018054 RID: 98388 RVA: 0x002340D8 File Offset: 0x002322D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskEffectStackChanged ListenForStackChanged(FActiveGameplayEffectHandle Handle)
		{
			UAsyncTaskEffectStackChanged.__ListenForStackChanged_FunctionParams* ptr = stackalloc UAsyncTaskEffectStackChanged.__ListenForStackChanged_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskEffectStackChanged.__ListenForStackChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectStackChanged.__ListenForStackChanged_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectStackChanged._ClassDefaultObjectPtr, UAsyncTaskEffectStackChanged.__ListenForStackChanged_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectStackChanged>(ptr->__Result);
		}

		// Token: 0x06018055 RID: 98389 RVA: 0x00234144 File Offset: 0x00232344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectStackChanged.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018056 RID: 98390 RVA: 0x00234159 File Offset: 0x00232359
		static UAsyncTaskEffectStackChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectStackChanged");
		}

		// Token: 0x06018057 RID: 98391 RVA: 0x00234167 File Offset: 0x00232367
		protected UAsyncTaskEffectStackChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFE4 RID: 53220
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectStackChanged";

		// Token: 0x0400CFE5 RID: 53221
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFE6 RID: 53222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFE7 RID: 53223
		internal static int __PropertyOffset_OnStackChanged;

		// Token: 0x0400CFE8 RID: 53224
		[Nullable(2)]
		private FOnStackChanged _OnStackChanged;

		// Token: 0x0400CFE9 RID: 53225
		private static IntPtr __ListenForStackChanged_NativeFunctionPtr;

		// Token: 0x0400CFEA RID: 53226
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003024 RID: 12324
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForStackChanged_FunctionParams
		{
			// Token: 0x04016C61 RID: 93281
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016C62 RID: 93282
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
