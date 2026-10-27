using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018DF RID: 6367
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputKeyDelegateEvent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroInputKeyDelegateEvent : UKuroInputDelegateEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017954 RID: 96596 RVA: 0x002285F6 File Offset: 0x002267F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputKeyDelegateEvent._ClassPtr;
		}

		// Token: 0x06017955 RID: 96597 RVA: 0x00228604 File Offset: 0x00226804
		public UKuroInputKeyDelegateEvent() : this(BuiltinUtils.AllocNativeUObject(UKuroInputKeyDelegateEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017956 RID: 96598 RVA: 0x0022862C File Offset: 0x0022682C
		[NullableContext(1)]
		public UKuroInputKeyDelegateEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputKeyDelegateEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017957 RID: 96599 RVA: 0x00228660 File Offset: 0x00226860
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoKeyCallback(FKey Key)
		{
			UKuroInputKeyDelegateEvent.__DoKeyCallback_FunctionParams* ptr = stackalloc UKuroInputKeyDelegateEvent.__DoKeyCallback_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroInputKeyDelegateEvent.__DoKeyCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputKeyDelegateEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputKeyDelegateEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroInputKeyDelegateEvent.__DoKeyCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017958 RID: 96600 RVA: 0x002286D3 File Offset: 0x002268D3
		static UKuroInputKeyDelegateEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputKeyDelegateEvent");
		}

		// Token: 0x06017959 RID: 96601 RVA: 0x002286E1 File Offset: 0x002268E1
		protected UKuroInputKeyDelegateEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCC9 RID: 52425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputKeyDelegateEvent";

		// Token: 0x0400CCCA RID: 52426
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCCB RID: 52427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCCC RID: 52428
		private static IntPtr __DoKeyCallback_NativeFunctionPtr;

		// Token: 0x02002FC0 RID: 12224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __DoKeyCallback_FunctionParams
		{
			// Token: 0x04016BA5 RID: 93093
			[FieldOffset(0)]
			public byte Key;
		}
	}
}
