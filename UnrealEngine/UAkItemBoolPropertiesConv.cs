using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000212 RID: 530
	[UnrealObjectPath("/Script/AkAudio.AkItemBoolPropertiesConv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkItemBoolPropertiesConv : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F84 RID: 8068 RVA: 0x0002EA91 File Offset: 0x0002CC91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkItemBoolPropertiesConv._ClassPtr;
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		public UAkItemBoolPropertiesConv() : this(BuiltinUtils.AllocNativeUObject(UAkItemBoolPropertiesConv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		[NullableContext(1)]
		public UAkItemBoolPropertiesConv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkItemBoolPropertiesConv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0002EAFB File Offset: 0x0002CCFB
		[NullableContext(1)]
		public static FText Conv_FAkBoolPropertyToControlToText([Nullable(2)] in FAkBoolPropertyToControl INAkBoolPropertyToControl)
		{
			return new FText(UAkItemBoolPropertiesConv.__Conv_FAkBoolPropertyToControlToText_Internal((INAkBoolPropertyToControl ?? new FAkBoolPropertyToControl()).NativePtr), null);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0002EB18 File Offset: 0x0002CD18
		[NullableContext(1)]
		public static string Conv_FAkBoolPropertyToControlToString([Nullable(2)] in FAkBoolPropertyToControl INAkBoolPropertyToControl)
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemBoolPropertiesConv.__Conv_FAkBoolPropertyToControlToString_Internal((INAkBoolPropertyToControl ?? new FAkBoolPropertyToControl()).NativePtr));
		}

		// Token: 0x06001F89 RID: 8073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAkBoolPropertyToControlToText_Internal(IntPtr INAkBoolPropertyToControl);

		// Token: 0x06001F8A RID: 8074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAkBoolPropertyToControlToString_Internal(IntPtr INAkBoolPropertyToControl);

		// Token: 0x06001F8B RID: 8075 RVA: 0x0002EB34 File Offset: 0x0002CD34
		static UAkItemBoolPropertiesConv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkItemBoolPropertiesConv");
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0002EB42 File Offset: 0x0002CD42
		protected UAkItemBoolPropertiesConv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A6E RID: 2670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkItemBoolPropertiesConv";

		// Token: 0x04000A6F RID: 2671
		private static IntPtr _ClassPtr;

		// Token: 0x04000A70 RID: 2672
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
