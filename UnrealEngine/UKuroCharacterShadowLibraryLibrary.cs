using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001852 RID: 6226
	[UnrealObjectPath("/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCharacterShadowLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016EF8 RID: 93944 RVA: 0x00217757 File Offset: 0x00215957
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterShadowLibraryLibrary._ClassPtr;
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x00217764 File Offset: 0x00215964
		public UKuroCharacterShadowLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterShadowLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016EFA RID: 93946 RVA: 0x0021778C File Offset: 0x0021598C
		[NullableContext(1)]
		public UKuroCharacterShadowLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterShadowLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016EFB RID: 93947
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetR(FArrayBuffer R);

		// Token: 0x06016EFC RID: 93948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Set(FGuid Guid);

		// Token: 0x06016EFD RID: 93949 RVA: 0x002177BF File Offset: 0x002159BF
		static UKuroCharacterShadowLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary");
		}

		// Token: 0x06016EFE RID: 93950 RVA: 0x002177CD File Offset: 0x002159CD
		protected UKuroCharacterShadowLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C75A RID: 51034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary";

		// Token: 0x0400C75B RID: 51035
		private static IntPtr _ClassPtr;

		// Token: 0x0400C75C RID: 51036
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
