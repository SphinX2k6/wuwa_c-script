using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022E5 RID: 8933
	[UnrealObjectPath("/Script/MFRCModule.MFRCActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AMFRCActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E09 RID: 138761 RVA: 0x00320D3A File Offset: 0x0031EF3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMFRCActor._ClassPtr;
		}

		// Token: 0x06021E0A RID: 138762 RVA: 0x00320D48 File Offset: 0x0031EF48
		public AMFRCActor() : this(BuiltinUtils.AllocNativeUObject(AMFRCActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E0B RID: 138763 RVA: 0x00320D70 File Offset: 0x0031EF70
		[NullableContext(1)]
		public AMFRCActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMFRCActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700831D RID: 33565
		// (get) Token: 0x06021E0C RID: 138764 RVA: 0x00320DA3 File Offset: 0x0031EFA3
		// (set) Token: 0x06021E0D RID: 138765 RVA: 0x00320DB3 File Offset: 0x0031EFB3
		public unsafe MFRCActorState CurrentState
		{
			get
			{
				return (MFRCActorState)(*(base.NativePtr + (IntPtr)AMFRCActor.__PropertyOffset_CurrentState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMFRCActor.__PropertyOffset_CurrentState) = (byte)value;
			}
		}

		// Token: 0x06021E0E RID: 138766 RVA: 0x00320DC4 File Offset: 0x0031EFC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UseFrameBuffer(bool Enable)
		{
			AMFRCActor.__UseFrameBuffer_FunctionParams* ptr = stackalloc AMFRCActor.__UseFrameBuffer_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__UseFrameBuffer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__UseFrameBuffer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__UseFrameBuffer_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E0F RID: 138767 RVA: 0x00320E0C File Offset: 0x0031F00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsUseFramebufferColor()
		{
			AMFRCActor.__IsUseFramebufferColor_FunctionParams* ptr = stackalloc AMFRCActor.__IsUseFramebufferColor_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__IsUseFramebufferColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__IsUseFramebufferColor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__IsUseFramebufferColor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021E10 RID: 138768 RVA: 0x00320E54 File Offset: 0x0031F054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsEnableSplitUI()
		{
			AMFRCActor.__IsEnableSplitUI_FunctionParams* ptr = stackalloc AMFRCActor.__IsEnableSplitUI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__IsEnableSplitUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__IsEnableSplitUI_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__IsEnableSplitUI_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021E11 RID: 138769 RVA: 0x00320E9C File Offset: 0x0031F09C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsEnableDepthMotion()
		{
			AMFRCActor.__IsEnableDepthMotion_FunctionParams* ptr = stackalloc AMFRCActor.__IsEnableDepthMotion_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__IsEnableDepthMotion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__IsEnableDepthMotion_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__IsEnableDepthMotion_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021E12 RID: 138770 RVA: 0x00320EE4 File Offset: 0x0031F0E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableSplitUI(bool Enable)
		{
			AMFRCActor.__EnableSplitUI_FunctionParams* ptr = stackalloc AMFRCActor.__EnableSplitUI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__EnableSplitUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__EnableSplitUI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__EnableSplitUI_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E13 RID: 138771 RVA: 0x00320F2B File Offset: 0x0031F12B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EnableMFRC()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__EnableMFRC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021E14 RID: 138772 RVA: 0x00320F40 File Offset: 0x0031F140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableDrawDebugTexture(bool Enable)
		{
			AMFRCActor.__EnableDrawDebugTexture_FunctionParams* ptr = stackalloc AMFRCActor.__EnableDrawDebugTexture_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__EnableDrawDebugTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__EnableDrawDebugTexture_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__EnableDrawDebugTexture_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E15 RID: 138773 RVA: 0x00320F88 File Offset: 0x0031F188
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableDepthMotion(bool Enable)
		{
			AMFRCActor.__EnableDepthMotion_FunctionParams* ptr = stackalloc AMFRCActor.__EnableDepthMotion_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AMFRCActor.__EnableDepthMotion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AMFRCActor.__EnableDepthMotion_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__EnableDepthMotion_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E16 RID: 138774 RVA: 0x00320FCF File Offset: 0x0031F1CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DisableMFRC()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AMFRCActor.__DisableMFRC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021E17 RID: 138775 RVA: 0x00320FE4 File Offset: 0x0031F1E4
		static AMFRCActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MFRCModule.MFRCActor");
		}

		// Token: 0x06021E18 RID: 138776 RVA: 0x00320FF2 File Offset: 0x0031F1F2
		protected AMFRCActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012122 RID: 74018
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MFRCModule.MFRCActor";

		// Token: 0x04012123 RID: 74019
		private static IntPtr _ClassPtr;

		// Token: 0x04012124 RID: 74020
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012125 RID: 74021
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x04012126 RID: 74022
		private static IntPtr __UseFrameBuffer_NativeFunctionPtr;

		// Token: 0x04012127 RID: 74023
		private static IntPtr __IsUseFramebufferColor_NativeFunctionPtr;

		// Token: 0x04012128 RID: 74024
		private static IntPtr __IsEnableSplitUI_NativeFunctionPtr;

		// Token: 0x04012129 RID: 74025
		private static IntPtr __IsEnableDepthMotion_NativeFunctionPtr;

		// Token: 0x0401212A RID: 74026
		private static IntPtr __EnableSplitUI_NativeFunctionPtr;

		// Token: 0x0401212B RID: 74027
		private static IntPtr __EnableMFRC_NativeFunctionPtr;

		// Token: 0x0401212C RID: 74028
		private static IntPtr __EnableDrawDebugTexture_NativeFunctionPtr;

		// Token: 0x0401212D RID: 74029
		private static IntPtr __EnableDepthMotion_NativeFunctionPtr;

		// Token: 0x0401212E RID: 74030
		private static IntPtr __DisableMFRC_NativeFunctionPtr;

		// Token: 0x02003616 RID: 13846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UseFrameBuffer_FunctionParams
		{
			// Token: 0x040176A6 RID: 95910
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02003617 RID: 13847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsUseFramebufferColor_FunctionParams
		{
			// Token: 0x040176A7 RID: 95911
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003618 RID: 13848
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsEnableSplitUI_FunctionParams
		{
			// Token: 0x040176A8 RID: 95912
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003619 RID: 13849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsEnableDepthMotion_FunctionParams
		{
			// Token: 0x040176A9 RID: 95913
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200361A RID: 13850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableSplitUI_FunctionParams
		{
			// Token: 0x040176AA RID: 95914
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x0200361B RID: 13851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDrawDebugTexture_FunctionParams
		{
			// Token: 0x040176AB RID: 95915
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x0200361C RID: 13852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDepthMotion_FunctionParams
		{
			// Token: 0x040176AC RID: 95916
			[FieldOffset(0)]
			public bool Enable;
		}
	}
}
