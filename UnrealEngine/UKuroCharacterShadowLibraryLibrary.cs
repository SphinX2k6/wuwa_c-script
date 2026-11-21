using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038E RID: 910
	[UnrealObjectPath("/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCharacterShadowLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005B0B RID: 23307 RVA: 0x0008096F File Offset: 0x0007EB6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterShadowLibraryLibrary._ClassPtr;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x0008097C File Offset: 0x0007EB7C
		public UKuroCharacterShadowLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterShadowLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x000809A4 File Offset: 0x0007EBA4
		[NullableContext(1)]
		public UKuroCharacterShadowLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterShadowLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005B0E RID: 23310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetR(FArrayBuffer R);

		// Token: 0x06005B0F RID: 23311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Set(FGuid Guid);

		// Token: 0x06005B10 RID: 23312 RVA: 0x000809D7 File Offset: 0x0007EBD7
		static UKuroCharacterShadowLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary");
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x000809E5 File Offset: 0x0007EBE5
		protected UKuroCharacterShadowLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025D4 RID: 9684
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFuncOpenLibrary.KuroCharacterShadowLibraryLibrary";

		// Token: 0x040025D5 RID: 9685
		private static IntPtr _ClassPtr;

		// Token: 0x040025D6 RID: 9686
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
