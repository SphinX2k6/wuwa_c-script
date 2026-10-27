using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002682 RID: 9858
	[UnrealObjectPath("/Script/ReactUMG.ReactWidget")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class UReactWidget : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249CC RID: 149964 RVA: 0x00363308 File Offset: 0x00361508
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReactWidget._ClassPtr;
		}

		// Token: 0x060249CD RID: 149965 RVA: 0x00363314 File Offset: 0x00361514
		public UReactWidget() : this(BuiltinUtils.AllocNativeUObject(UReactWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249CE RID: 149966 RVA: 0x0036333C File Offset: 0x0036153C
		[NullableContext(1)]
		public UReactWidget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReactWidget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060249CF RID: 149967 RVA: 0x00363370 File Offset: 0x00361570
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool RemoveChild(UWidget Content)
		{
			UReactWidget.__RemoveChild_FunctionParams* ptr = stackalloc UReactWidget.__RemoveChild_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UReactWidget.__RemoveChild_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UReactWidget.__RemoveChild_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Content = ((Content != null) ? Content.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UReactWidget.__RemoveChild_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060249D0 RID: 149968 RVA: 0x003633CC File Offset: 0x003615CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UPanelSlot AddChild(UWidget Content)
		{
			UReactWidget.__AddChild_FunctionParams* ptr = stackalloc UReactWidget.__AddChild_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UReactWidget.__AddChild_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UReactWidget.__AddChild_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Content = ((Content != null) ? Content.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UReactWidget.__AddChild_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelSlot>(ptr->__Result);
		}

		// Token: 0x060249D1 RID: 149969 RVA: 0x0036342D File Offset: 0x0036162D
		static UReactWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ReactUMG.ReactWidget");
		}

		// Token: 0x060249D2 RID: 149970 RVA: 0x0036343B File Offset: 0x0036163B
		protected UReactWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013ADA RID: 80602
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ReactUMG.ReactWidget";

		// Token: 0x04013ADB RID: 80603
		private static IntPtr _ClassPtr;

		// Token: 0x04013ADC RID: 80604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013ADD RID: 80605
		private static IntPtr __RemoveChild_NativeFunctionPtr;

		// Token: 0x04013ADE RID: 80606
		private static IntPtr __AddChild_NativeFunctionPtr;

		// Token: 0x0200368E RID: 13966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveChild_FunctionParams
		{
			// Token: 0x0401777C RID: 96124
			[FieldOffset(0)]
			public IntPtr Content;

			// Token: 0x0401777D RID: 96125
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200368F RID: 13967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AddChild_FunctionParams
		{
			// Token: 0x0401777E RID: 96126
			[FieldOffset(0)]
			public IntPtr Content;

			// Token: 0x0401777F RID: 96127
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
