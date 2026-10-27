using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F79 RID: 8057
	[UnrealObjectPath("/Script/Landscape.LandscapeInfoMap")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class ULandscapeInfoMap : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E924 RID: 125220 RVA: 0x002D6F52 File Offset: 0x002D5152
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeInfoMap._ClassPtr;
		}

		// Token: 0x0601E925 RID: 125221 RVA: 0x002D6F60 File Offset: 0x002D5160
		public ULandscapeInfoMap() : this(BuiltinUtils.AllocNativeUObject(ULandscapeInfoMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E926 RID: 125222 RVA: 0x002D6F88 File Offset: 0x002D5188
		[NullableContext(1)]
		public ULandscapeInfoMap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeInfoMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E927 RID: 125223 RVA: 0x002D6FBB File Offset: 0x002D51BB
		static ULandscapeInfoMap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeInfoMap");
		}

		// Token: 0x0601E928 RID: 125224 RVA: 0x002D6FC9 File Offset: 0x002D51C9
		protected ULandscapeInfoMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010857 RID: 67671
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeInfoMap";

		// Token: 0x04010858 RID: 67672
		private static IntPtr _ClassPtr;

		// Token: 0x04010859 RID: 67673
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
