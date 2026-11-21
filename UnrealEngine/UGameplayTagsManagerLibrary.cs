using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C5 RID: 1477
	[UnrealObjectPath("/Script/KuroUtility.GameplayTagsManagerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGameplayTagsManagerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008380 RID: 33664 RVA: 0x000C2B4A File Offset: 0x000C0D4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsManagerLibrary._ClassPtr;
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x000C2B58 File Offset: 0x000C0D58
		public UGameplayTagsManagerLibrary() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManagerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x000C2B80 File Offset: 0x000C0D80
		[NullableContext(1)]
		public UGameplayTagsManagerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManagerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x000C2BB4 File Offset: 0x000C0DB4
		[NullableContext(1)]
		public unsafe static string GetOriginalTag(in FName TagName)
		{
			fixed (FName* ptr = &TagName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(UGameplayTagsManagerLibrary.__GetOriginalTag_Internal(TagName));
			}
		}

		// Token: 0x06008384 RID: 33668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOriginalTag_Internal(in FName TagName);

		// Token: 0x06008385 RID: 33669 RVA: 0x000C2BD1 File Offset: 0x000C0DD1
		static UGameplayTagsManagerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.GameplayTagsManagerLibrary");
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x000C2BDF File Offset: 0x000C0DDF
		protected UGameplayTagsManagerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400396C RID: 14700
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.GameplayTagsManagerLibrary";

		// Token: 0x0400396D RID: 14701
		private static IntPtr _ClassPtr;

		// Token: 0x0400396E RID: 14702
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
