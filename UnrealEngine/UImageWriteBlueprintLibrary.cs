using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001519 RID: 5401
	[UnrealObjectPath("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UImageWriteBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013AB0 RID: 80560 RVA: 0x001CE37C File Offset: 0x001CC57C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageWriteBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06013AB1 RID: 80561 RVA: 0x001CE388 File Offset: 0x001CC588
		public UImageWriteBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UImageWriteBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013AB2 RID: 80562 RVA: 0x001CE3B0 File Offset: 0x001CC5B0
		[NullableContext(1)]
		public UImageWriteBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImageWriteBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013AB3 RID: 80563 RVA: 0x001CE3E4 File Offset: 0x001CC5E4
		[NullableContext(2)]
		public unsafe static void ExportToDisk(UTexture Texture, [Nullable(1)] string Filename, in FImageWriteOptions Options)
		{
			FString fstring = FString.AllocTemp(Filename);
			UImageWriteBlueprintLibrary.__ExportToDisk_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, fstring, (Options ?? new FImageWriteOptions()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06013AB4 RID: 80564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportToDisk_Internal(IntPtr Texture, in FString Filename, IntPtr Options);

		// Token: 0x06013AB5 RID: 80565 RVA: 0x001CE428 File Offset: 0x001CC628
		static UImageWriteBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImageWriteQueue.ImageWriteBlueprintLibrary");
		}

		// Token: 0x06013AB6 RID: 80566 RVA: 0x001CE436 File Offset: 0x001CC636
		protected UImageWriteBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A9E8 RID: 43496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImageWriteQueue.ImageWriteBlueprintLibrary";

		// Token: 0x0400A9E9 RID: 43497
		private static IntPtr _ClassPtr;

		// Token: 0x0400A9EA RID: 43498
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
