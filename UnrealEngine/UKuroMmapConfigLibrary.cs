using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DE RID: 1502
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroMmapConfigLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMmapConfigLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084CE RID: 33998 RVA: 0x000C4FCC File Offset: 0x000C31CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMmapConfigLibrary._ClassPtr;
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x000C4FD8 File Offset: 0x000C31D8
		public UKuroMmapConfigLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMmapConfigLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x000C5000 File Offset: 0x000C3200
		public UKuroMmapConfigLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMmapConfigLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x000C5034 File Offset: 0x000C3234
		public unsafe static int UnmapConfig(string InPath, int PakChunkIndex)
		{
			FString fstring = FString.AllocTemp(InPath);
			int result = UKuroMmapConfigLibrary.__UnmapConfig_Internal(fstring, PakChunkIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060084D2 RID: 34002
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int UnmapAllConfigs();

		// Token: 0x060084D3 RID: 34003 RVA: 0x000C505C File Offset: 0x000C325C
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

		// Token: 0x060084D4 RID: 34004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __UnmapConfig_Internal(in FString InPath, int PakChunkIndex);

		// Token: 0x060084D5 RID: 34005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MapConfig_Internal(in FString InPath, int PakChunkIndex, ref long OutPtr, ref long OutLength);

		// Token: 0x060084D6 RID: 34006 RVA: 0x000C508F File Offset: 0x000C328F
		static UKuroMmapConfigLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMmapConfigLibrary");
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x000C509D File Offset: 0x000C329D
		protected UKuroMmapConfigLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A01 RID: 14849
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMmapConfigLibrary";

		// Token: 0x04003A02 RID: 14850
		private static IntPtr _ClassPtr;

		// Token: 0x04003A03 RID: 14851
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
