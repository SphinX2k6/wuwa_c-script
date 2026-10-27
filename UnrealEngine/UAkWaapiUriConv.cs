using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000257 RID: 599
	[UnrealObjectPath("/Script/AkAudio.AkWaapiUriConv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkWaapiUriConv : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002350 RID: 9040 RVA: 0x000343B5 File Offset: 0x000325B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWaapiUriConv._ClassPtr;
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000343C4 File Offset: 0x000325C4
		public UAkWaapiUriConv() : this(BuiltinUtils.AllocNativeUObject(UAkWaapiUriConv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x000343EC File Offset: 0x000325EC
		[NullableContext(1)]
		public UAkWaapiUriConv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWaapiUriConv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0003441F File Offset: 0x0003261F
		[NullableContext(1)]
		public static FText Conv_FAkWaapiUriToText([Nullable(2)] in FAkWaapiUri INAkWaapiUri)
		{
			return new FText(UAkWaapiUriConv.__Conv_FAkWaapiUriToText_Internal((INAkWaapiUri ?? new FAkWaapiUri()).NativePtr), null);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0003443C File Offset: 0x0003263C
		[NullableContext(1)]
		public static string Conv_FAkWaapiUriToString([Nullable(2)] in FAkWaapiUri INAkWaapiUri)
		{
			return FString.ToStringAndDeleteNativePtr(UAkWaapiUriConv.__Conv_FAkWaapiUriToString_Internal((INAkWaapiUri ?? new FAkWaapiUri()).NativePtr));
		}

		// Token: 0x06002355 RID: 9045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAkWaapiUriToText_Internal(IntPtr INAkWaapiUri);

		// Token: 0x06002356 RID: 9046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAkWaapiUriToString_Internal(IntPtr INAkWaapiUri);

		// Token: 0x06002357 RID: 9047 RVA: 0x00034458 File Offset: 0x00032658
		static UAkWaapiUriConv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWaapiUriConv");
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00034466 File Offset: 0x00032666
		protected UAkWaapiUriConv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C2D RID: 3117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWaapiUriConv";

		// Token: 0x04000C2E RID: 3118
		private static IntPtr _ClassPtr;

		// Token: 0x04000C2F RID: 3119
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
