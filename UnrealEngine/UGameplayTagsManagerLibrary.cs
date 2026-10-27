using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA2 RID: 7842
	[UnrealObjectPath("/Script/KuroUtility.GameplayTagsManagerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGameplayTagsManagerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DC7F RID: 121983 RVA: 0x002C037E File Offset: 0x002BE57E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsManagerLibrary._ClassPtr;
		}

		// Token: 0x0601DC80 RID: 121984 RVA: 0x002C038C File Offset: 0x002BE58C
		public UGameplayTagsManagerLibrary() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManagerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DC81 RID: 121985 RVA: 0x002C03B4 File Offset: 0x002BE5B4
		[NullableContext(1)]
		public UGameplayTagsManagerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManagerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DC82 RID: 121986 RVA: 0x002C03E8 File Offset: 0x002BE5E8
		[NullableContext(1)]
		public unsafe static string GetOriginalTag(in FName TagName)
		{
			fixed (FName* ptr = &TagName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(UGameplayTagsManagerLibrary.__GetOriginalTag_Internal(TagName));
			}
		}

		// Token: 0x0601DC83 RID: 121987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOriginalTag_Internal(in FName TagName);

		// Token: 0x0601DC84 RID: 121988 RVA: 0x002C0405 File Offset: 0x002BE605
		static UGameplayTagsManagerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.GameplayTagsManagerLibrary");
		}

		// Token: 0x0601DC85 RID: 121989 RVA: 0x002C0413 File Offset: 0x002BE613
		protected UGameplayTagsManagerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010235 RID: 66101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.GameplayTagsManagerLibrary";

		// Token: 0x04010236 RID: 66102
		private static IntPtr _ClassPtr;

		// Token: 0x04010237 RID: 66103
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
