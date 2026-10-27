using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC3 RID: 7875
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroMmapConfigLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMmapConfigLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE1A RID: 122394 RVA: 0x002C32DC File Offset: 0x002C14DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMmapConfigLibrary._ClassPtr;
		}

		// Token: 0x0601DE1B RID: 122395 RVA: 0x002C32E8 File Offset: 0x002C14E8
		public UKuroMmapConfigLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMmapConfigLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE1C RID: 122396 RVA: 0x002C3310 File Offset: 0x002C1510
		public UKuroMmapConfigLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMmapConfigLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE1D RID: 122397 RVA: 0x002C3344 File Offset: 0x002C1544
		public unsafe static int UnmapConfig(string InPath, int PakChunkIndex)
		{
			FString fstring = FString.AllocTemp(InPath);
			int result = UKuroMmapConfigLibrary.__UnmapConfig_Internal(fstring, PakChunkIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DE1E RID: 122398
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int UnmapAllConfigs();

		// Token: 0x0601DE1F RID: 122399 RVA: 0x002C336C File Offset: 0x002C156C
		public unsafe static bool MapConfig(string InPath, int PakChunkIndex, ref long OutPtr, ref long OutLength)
		{
			FString fstring = FString.AllocTemp(InPath);
			fixed (long* ptr = &OutPtr)
			{
				void* ptr2 = (void*)ptr;
				fixed (long* ptr3 = &OutLength)
				{
					void* ptr4 = (void*)ptr3;
					bool result = UKuroMmapConfigLibrary.__MapConfig_Internal(fstring, PakChunkIndex, ref OutPtr, ref OutLength);
					FString.NativeDestruct(&fstring, 1);
					return result;
				}
			}
		}

		// Token: 0x0601DE20 RID: 122400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __UnmapConfig_Internal(in FString InPath, int PakChunkIndex);

		// Token: 0x0601DE21 RID: 122401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MapConfig_Internal(in FString InPath, int PakChunkIndex, ref long OutPtr, ref long OutLength);

		// Token: 0x0601DE22 RID: 122402 RVA: 0x002C339F File Offset: 0x002C159F
		static UKuroMmapConfigLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMmapConfigLibrary");
		}

		// Token: 0x0601DE23 RID: 122403 RVA: 0x002C33AD File Offset: 0x002C15AD
		protected UKuroMmapConfigLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102F8 RID: 66296
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMmapConfigLibrary";

		// Token: 0x040102F9 RID: 66297
		private static IntPtr _ClassPtr;

		// Token: 0x040102FA RID: 66298
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
