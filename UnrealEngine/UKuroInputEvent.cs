using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018DE RID: 6366
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputEvent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroInputEvent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601794B RID: 96587 RVA: 0x002283F1 File Offset: 0x002265F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputEvent._ClassPtr;
		}

		// Token: 0x0601794C RID: 96588 RVA: 0x00228400 File Offset: 0x00226600
		public UKuroInputEvent() : this(BuiltinUtils.AllocNativeUObject(UKuroInputEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601794D RID: 96589 RVA: 0x00228428 File Offset: 0x00226628
		[NullableContext(1)]
		public UKuroInputEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601794E RID: 96590 RVA: 0x0022845C File Offset: 0x0022665C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoTouchCallback(ETouchIndex touchIndex, FVector position)
		{
			UKuroInputEvent.__DoTouchCallback_FunctionParams* ptr = stackalloc UKuroInputEvent.__DoTouchCallback_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroInputEvent.__DoTouchCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputEvent.__DoTouchCallback_NativeFunctionPtr, (void*)ptr, 1);
			ptr->touchIndex = touchIndex;
			ptr->position = position;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputEvent.__DoTouchCallback_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601794F RID: 96591 RVA: 0x002284B0 File Offset: 0x002266B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoKeyCallback(FKey Key)
		{
			UKuroInputEvent.__DoKeyCallback_FunctionParams* ptr = stackalloc UKuroInputEvent.__DoKeyCallback_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroInputEvent.__DoKeyCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroInputEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017950 RID: 96592 RVA: 0x00228524 File Offset: 0x00226724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoAxisCallback(float value)
		{
			UKuroInputEvent.__DoAxisCallback_FunctionParams* ptr = stackalloc UKuroInputEvent.__DoAxisCallback_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroInputEvent.__DoAxisCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputEvent.__DoAxisCallback_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputEvent.__DoAxisCallback_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017951 RID: 96593 RVA: 0x0022856C File Offset: 0x0022676C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoActionCallback(FKey Key)
		{
			UKuroInputEvent.__DoActionCallback_FunctionParams* ptr = stackalloc UKuroInputEvent.__DoActionCallback_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroInputEvent.__DoActionCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroInputEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017952 RID: 96594 RVA: 0x002285DF File Offset: 0x002267DF
		static UKuroInputEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputEvent");
		}

		// Token: 0x06017953 RID: 96595 RVA: 0x002285ED File Offset: 0x002267ED
		protected UKuroInputEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCC2 RID: 52418
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputEvent";

		// Token: 0x0400CCC3 RID: 52419
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCC4 RID: 52420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCC5 RID: 52421
		private static IntPtr __DoTouchCallback_NativeFunctionPtr;

		// Token: 0x0400CCC6 RID: 52422
		private static IntPtr __DoKeyCallback_NativeFunctionPtr;

		// Token: 0x0400CCC7 RID: 52423
		private static IntPtr __DoAxisCallback_NativeFunctionPtr;

		// Token: 0x0400CCC8 RID: 52424
		private static IntPtr __DoActionCallback_NativeFunctionPtr;

		// Token: 0x02002FBC RID: 12220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __DoTouchCallback_FunctionParams
		{
			// Token: 0x04016BA0 RID: 93088
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04016BA1 RID: 93089
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x02002FBD RID: 12221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __DoKeyCallback_FunctionParams
		{
			// Token: 0x04016BA2 RID: 93090
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02002FBE RID: 12222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DoAxisCallback_FunctionParams
		{
			// Token: 0x04016BA3 RID: 93091
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x02002FBF RID: 12223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __DoActionCallback_FunctionParams
		{
			// Token: 0x04016BA4 RID: 93092
			[FieldOffset(0)]
			public byte Key;
		}
	}
}
