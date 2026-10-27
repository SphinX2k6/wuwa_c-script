using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002114 RID: 8468
	[UnrealObjectPath("/Script/LGUI.TextureTransitionUtil")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTextureTransitionUtil : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FDD5 RID: 130517 RVA: 0x002F6756 File Offset: 0x002F4956
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureTransitionUtil._ClassPtr;
		}

		// Token: 0x0601FDD6 RID: 130518 RVA: 0x002F6764 File Offset: 0x002F4964
		public UTextureTransitionUtil() : this(BuiltinUtils.AllocNativeUObject(UTextureTransitionUtil.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FDD7 RID: 130519 RVA: 0x002F678C File Offset: 0x002F498C
		[NullableContext(1)]
		public UTextureTransitionUtil(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureTransitionUtil.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FDD8 RID: 130520 RVA: 0x002F67C0 File Offset: 0x002F49C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetTextureSize(UUITexture Texture, bool bIsSnapSize, float Width = 0f, float Height = 0f)
		{
			UTextureTransitionUtil.__SetTextureSize_FunctionParams* ptr = stackalloc UTextureTransitionUtil.__SetTextureSize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTextureTransitionUtil.__SetTextureSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTextureTransitionUtil.__SetTextureSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->bIsSnapSize = bIsSnapSize;
			ptr->Width = Width;
			ptr->Height = Height;
			UnrealReflectionUtils.CallUFunction(UTextureTransitionUtil._ClassDefaultObjectPtr, UTextureTransitionUtil.__SetTextureSize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FDD9 RID: 130521 RVA: 0x002F682C File Offset: 0x002F4A2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetTextureByTransitionInfo(UUITexture Texture, in FTextureTransitionOfState Info)
		{
			UTextureTransitionUtil.__SetTextureByTransitionInfo_FunctionParams* ptr = stackalloc UTextureTransitionUtil.__SetTextureByTransitionInfo_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTextureTransitionUtil.__SetTextureByTransitionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTextureTransitionUtil.__SetTextureByTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			if (Info != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), &ptr->Info, Info.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UTextureTransitionUtil._ClassDefaultObjectPtr, UTextureTransitionUtil.__SetTextureByTransitionInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTextureTransitionUtil.__SetTextureByTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FDDA RID: 130522 RVA: 0x002F68B6 File Offset: 0x002F4AB6
		static UTextureTransitionUtil()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.TextureTransitionUtil");
		}

		// Token: 0x0601FDDB RID: 130523 RVA: 0x002F68C4 File Offset: 0x002F4AC4
		protected UTextureTransitionUtil(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112BF RID: 70335
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.TextureTransitionUtil";

		// Token: 0x040112C0 RID: 70336
		private static IntPtr _ClassPtr;

		// Token: 0x040112C1 RID: 70337
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112C2 RID: 70338
		private static IntPtr __SetTextureSize_NativeFunctionPtr;

		// Token: 0x040112C3 RID: 70339
		private static IntPtr __SetTextureByTransitionInfo_NativeFunctionPtr;

		// Token: 0x020034E9 RID: 13545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetTextureSize_FunctionParams
		{
			// Token: 0x04017503 RID: 95491
			[FieldOffset(0)]
			public IntPtr Texture;

			// Token: 0x04017504 RID: 95492
			[FieldOffset(8)]
			public bool bIsSnapSize;

			// Token: 0x04017505 RID: 95493
			[FieldOffset(12)]
			public float Width;

			// Token: 0x04017506 RID: 95494
			[FieldOffset(16)]
			public float Height;
		}

		// Token: 0x020034EA RID: 13546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetTextureByTransitionInfo_FunctionParams
		{
			// Token: 0x04017507 RID: 95495
			[FieldOffset(0)]
			public IntPtr Texture;

			// Token: 0x04017508 RID: 95496
			[FieldOffset(8)]
			public byte Info;
		}
	}
}
