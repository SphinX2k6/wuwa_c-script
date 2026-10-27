using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200210F RID: 8463
	[UnrealObjectPath("/Script/LGUI.SpriteTransitionUtil")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USpriteTransitionUtil : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD7D RID: 130429 RVA: 0x002F5CE2 File Offset: 0x002F3EE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpriteTransitionUtil._ClassPtr;
		}

		// Token: 0x0601FD7E RID: 130430 RVA: 0x002F5CF0 File Offset: 0x002F3EF0
		public USpriteTransitionUtil() : this(BuiltinUtils.AllocNativeUObject(USpriteTransitionUtil.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD7F RID: 130431 RVA: 0x002F5D18 File Offset: 0x002F3F18
		[NullableContext(1)]
		public USpriteTransitionUtil(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpriteTransitionUtil.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FD80 RID: 130432 RVA: 0x002F5D4C File Offset: 0x002F3F4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSpriteSize(UUISprite Sprite, bool bSnapSize, float Width = 0f, float Height = 0f)
		{
			USpriteTransitionUtil.__SetSpriteSize_FunctionParams* ptr = stackalloc USpriteTransitionUtil.__SetSpriteSize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USpriteTransitionUtil.__SetSpriteSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USpriteTransitionUtil.__SetSpriteSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Sprite = ((Sprite != null) ? Sprite.NativePtr : IntPtr.Zero);
			ptr->bSnapSize = bSnapSize;
			ptr->Width = Width;
			ptr->Height = Height;
			UnrealReflectionUtils.CallUFunction(USpriteTransitionUtil._ClassDefaultObjectPtr, USpriteTransitionUtil.__SetSpriteSize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FD81 RID: 130433 RVA: 0x002F5DB8 File Offset: 0x002F3FB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSpriteByTransitionInfo(UUISprite Sprite, in FSpriteTransitionOfState Info)
		{
			USpriteTransitionUtil.__SetSpriteByTransitionInfo_FunctionParams* ptr = stackalloc USpriteTransitionUtil.__SetSpriteByTransitionInfo_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(USpriteTransitionUtil.__SetSpriteByTransitionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USpriteTransitionUtil.__SetSpriteByTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Sprite = ((Sprite != null) ? Sprite.NativePtr : IntPtr.Zero);
			if (Info != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), &ptr->Info, Info.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(USpriteTransitionUtil._ClassDefaultObjectPtr, USpriteTransitionUtil.__SetSpriteByTransitionInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USpriteTransitionUtil.__SetSpriteByTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FD82 RID: 130434 RVA: 0x002F5E44 File Offset: 0x002F4044
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetColorTweener(UUISprite Sprite, in FSpriteTransitionOfState Info, ref ULTweener Tweener)
		{
			USpriteTransitionUtil.__SetColorTweener_FunctionParams* ptr = stackalloc USpriteTransitionUtil.__SetColorTweener_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(USpriteTransitionUtil.__SetColorTweener_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USpriteTransitionUtil.__SetColorTweener_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Sprite = ((Sprite != null) ? Sprite.NativePtr : IntPtr.Zero);
			if (Info != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), &ptr->Info, Info.NativePtr, 1, false);
			}
			ref USpriteTransitionUtil.__SetColorTweener_FunctionParams ptr2 = ref *ptr;
			ULTweener ultweener = Tweener;
			ptr2.Tweener = ((ultweener != null) ? ultweener.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(USpriteTransitionUtil._ClassDefaultObjectPtr, USpriteTransitionUtil.__SetColorTweener_NativeFunctionPtr, (void*)ptr, 0);
			Tweener = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ptr->Tweener);
			UnrealReflectionUtils.DestroyStruct(USpriteTransitionUtil.__SetColorTweener_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FD83 RID: 130435 RVA: 0x002F5EF3 File Offset: 0x002F40F3
		static USpriteTransitionUtil()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SpriteTransitionUtil");
		}

		// Token: 0x0601FD84 RID: 130436 RVA: 0x002F5F01 File Offset: 0x002F4101
		protected USpriteTransitionUtil(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401128E RID: 70286
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.SpriteTransitionUtil";

		// Token: 0x0401128F RID: 70287
		private static IntPtr _ClassPtr;

		// Token: 0x04011290 RID: 70288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011291 RID: 70289
		private static IntPtr __SetSpriteSize_NativeFunctionPtr;

		// Token: 0x04011292 RID: 70290
		private static IntPtr __SetSpriteByTransitionInfo_NativeFunctionPtr;

		// Token: 0x04011293 RID: 70291
		private static IntPtr __SetColorTweener_NativeFunctionPtr;

		// Token: 0x020034E6 RID: 13542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetSpriteSize_FunctionParams
		{
			// Token: 0x040174FA RID: 95482
			[FieldOffset(0)]
			public IntPtr Sprite;

			// Token: 0x040174FB RID: 95483
			[FieldOffset(8)]
			public bool bSnapSize;

			// Token: 0x040174FC RID: 95484
			[FieldOffset(12)]
			public float Width;

			// Token: 0x040174FD RID: 95485
			[FieldOffset(16)]
			public float Height;
		}

		// Token: 0x020034E7 RID: 13543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetSpriteByTransitionInfo_FunctionParams
		{
			// Token: 0x040174FE RID: 95486
			[FieldOffset(0)]
			public IntPtr Sprite;

			// Token: 0x040174FF RID: 95487
			[FieldOffset(8)]
			public byte Info;
		}

		// Token: 0x020034E8 RID: 13544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetColorTweener_FunctionParams
		{
			// Token: 0x04017500 RID: 95488
			[FieldOffset(0)]
			public IntPtr Sprite;

			// Token: 0x04017501 RID: 95489
			[FieldOffset(8)]
			public byte Info;

			// Token: 0x04017502 RID: 95490
			[FieldOffset(56)]
			public IntPtr Tweener;
		}
	}
}
