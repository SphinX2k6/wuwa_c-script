using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194C RID: 6476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskAnyAttributeChanged")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskAnyAttributeChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018000 RID: 98304 RVA: 0x0023366D File Offset: 0x0023186D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskAnyAttributeChanged._ClassPtr;
		}

		// Token: 0x06018001 RID: 98305 RVA: 0x0023367C File Offset: 0x0023187C
		public UAsyncTaskAnyAttributeChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyAttributeChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018002 RID: 98306 RVA: 0x002336A4 File Offset: 0x002318A4
		public UAsyncTaskAnyAttributeChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyAttributeChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x06018003 RID: 98307 RVA: 0x002336D8 File Offset: 0x002318D8
		// (set) Token: 0x06018004 RID: 98308 RVA: 0x00233711 File Offset: 0x00231911
		public FOnAnyAttributeChanged OnAttributeChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnAnyAttributeChanged result;
				if ((result = this._OnAttributeChanged) == null)
				{
					result = (this._OnAttributeChanged = new FOnAnyAttributeChanged(base.NativePtr + (IntPtr)UAsyncTaskAnyAttributeChanged.__PropertyOffset_OnAttributeChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskAnyAttributeChanged.__PropertyOffset_OnAttributeChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x06018005 RID: 98309 RVA: 0x00233732 File Offset: 0x00231932
		// (set) Token: 0x06018006 RID: 98310 RVA: 0x00233746 File Offset: 0x00231946
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyAttributeChanged.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyAttributeChanged.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x06018007 RID: 98311 RVA: 0x0023375C File Offset: 0x0023195C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskAnyAttributeChanged ListenForAnyAttributeChange(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskAnyAttributeChanged.__ListenForAnyAttributeChange_FunctionParams* ptr = stackalloc UAsyncTaskAnyAttributeChanged.__ListenForAnyAttributeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskAnyAttributeChanged.__ListenForAnyAttributeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskAnyAttributeChanged.__ListenForAnyAttributeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskAnyAttributeChanged._ClassDefaultObjectPtr, UAsyncTaskAnyAttributeChanged.__ListenForAnyAttributeChange_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskAnyAttributeChanged>(ptr->__Result);
		}

		// Token: 0x06018008 RID: 98312 RVA: 0x002337BC File Offset: 0x002319BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskAnyAttributeChanged.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018009 RID: 98313 RVA: 0x002337D1 File Offset: 0x002319D1
		static UAsyncTaskAnyAttributeChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskAnyAttributeChanged");
		}

		// Token: 0x0601800A RID: 98314 RVA: 0x002337DF File Offset: 0x002319DF
		protected UAsyncTaskAnyAttributeChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFB1 RID: 53169
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskAnyAttributeChanged";

		// Token: 0x0400CFB2 RID: 53170
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFB3 RID: 53171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFB4 RID: 53172
		internal static int __PropertyOffset_OnAttributeChanged;

		// Token: 0x0400CFB5 RID: 53173
		[Nullable(2)]
		private FOnAnyAttributeChanged _OnAttributeChanged;

		// Token: 0x0400CFB6 RID: 53174
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400CFB7 RID: 53175
		private static IntPtr __ListenForAnyAttributeChange_NativeFunctionPtr;

		// Token: 0x0400CFB8 RID: 53176
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x0200301F RID: 12319
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForAnyAttributeChange_FunctionParams
		{
			// Token: 0x04016C55 RID: 93269
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016C56 RID: 93270
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
