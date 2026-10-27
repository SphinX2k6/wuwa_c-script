using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000214 RID: 532
	[UnrealObjectPath("/Script/AkAudio.AkItemPropertiesConv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkItemPropertiesConv : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F9C RID: 8092 RVA: 0x0002ECD1 File Offset: 0x0002CED1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkItemPropertiesConv._ClassPtr;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		public UAkItemPropertiesConv() : this(BuiltinUtils.AllocNativeUObject(UAkItemPropertiesConv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0002ED08 File Offset: 0x0002CF08
		[NullableContext(1)]
		public UAkItemPropertiesConv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkItemPropertiesConv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0002ED3B File Offset: 0x0002CF3B
		[NullableContext(1)]
		public static FText Conv_FAkPropertyToControlToText([Nullable(2)] in FAkPropertyToControl INAkPropertyToControl)
		{
			return new FText(UAkItemPropertiesConv.__Conv_FAkPropertyToControlToText_Internal((INAkPropertyToControl ?? new FAkPropertyToControl()).NativePtr), null);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0002ED58 File Offset: 0x0002CF58
		[NullableContext(1)]
		public static string Conv_FAkPropertyToControlToString([Nullable(2)] in FAkPropertyToControl INAkPropertyToControl)
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemPropertiesConv.__Conv_FAkPropertyToControlToString_Internal((INAkPropertyToControl ?? new FAkPropertyToControl()).NativePtr));
		}

		// Token: 0x06001FA1 RID: 8097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAkPropertyToControlToText_Internal(IntPtr INAkPropertyToControl);

		// Token: 0x06001FA2 RID: 8098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAkPropertyToControlToString_Internal(IntPtr INAkPropertyToControl);

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0002ED74 File Offset: 0x0002CF74
		static UAkItemPropertiesConv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkItemPropertiesConv");
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0002ED82 File Offset: 0x0002CF82
		protected UAkItemPropertiesConv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A78 RID: 2680
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkItemPropertiesConv";

		// Token: 0x04000A79 RID: 2681
		private static IntPtr _ClassPtr;

		// Token: 0x04000A7A RID: 2682
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
