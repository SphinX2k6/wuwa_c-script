using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E1 RID: 6369
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputTouchDelegateEvent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroInputTouchDelegateEvent : UKuroInputDelegateEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017962 RID: 96610 RVA: 0x00228809 File Offset: 0x00226A09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputTouchDelegateEvent._ClassPtr;
		}

		// Token: 0x06017963 RID: 96611 RVA: 0x00228818 File Offset: 0x00226A18
		public UKuroInputTouchDelegateEvent() : this(BuiltinUtils.AllocNativeUObject(UKuroInputTouchDelegateEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017964 RID: 96612 RVA: 0x00228840 File Offset: 0x00226A40
		[NullableContext(1)]
		public UKuroInputTouchDelegateEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputTouchDelegateEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017965 RID: 96613 RVA: 0x00228874 File Offset: 0x00226A74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoTouchCallback(ETouchIndex TouchIndex, FVector Position)
		{
			UKuroInputTouchDelegateEvent.__DoTouchCallback_FunctionParams* ptr = stackalloc UKuroInputTouchDelegateEvent.__DoTouchCallback_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroInputTouchDelegateEvent.__DoTouchCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputTouchDelegateEvent.__DoTouchCallback_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TouchIndex = TouchIndex;
			ptr->Position = Position;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputTouchDelegateEvent.__DoTouchCallback_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017966 RID: 96614 RVA: 0x002288C7 File Offset: 0x00226AC7
		static UKuroInputTouchDelegateEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputTouchDelegateEvent");
		}

		// Token: 0x06017967 RID: 96615 RVA: 0x002288D5 File Offset: 0x00226AD5
		protected UKuroInputTouchDelegateEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCD3 RID: 52435
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputTouchDelegateEvent";

		// Token: 0x0400CCD4 RID: 52436
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCD5 RID: 52437
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCD6 RID: 52438
		private static IntPtr __DoTouchCallback_NativeFunctionPtr;

		// Token: 0x02002FC2 RID: 12226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __DoTouchCallback_FunctionParams
		{
			// Token: 0x04016BA7 RID: 93095
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> TouchIndex;

			// Token: 0x04016BA8 RID: 93096
			[FieldOffset(4)]
			public FVector Position;
		}
	}
}
