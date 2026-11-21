using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051D RID: 1309
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroSceneMatModifyDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A9C RID: 31388 RVA: 0x000B3D1C File Offset: 0x000B1F1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneMatModifyDataAsset._ClassPtr;
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x000B3D28 File Offset: 0x000B1F28
		public UKuroSceneMatModifyDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneMatModifyDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x000B3D50 File Offset: 0x000B1F50
		[NullableContext(1)]
		public UKuroSceneMatModifyDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneMatModifyDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x000B3D83 File Offset: 0x000B1F83
		static UKuroSceneMatModifyDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset");
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x000B3D91 File Offset: 0x000B1F91
		protected UKuroSceneMatModifyDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003424 RID: 13348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset";

		// Token: 0x04003425 RID: 13349
		private static IntPtr _ClassPtr;

		// Token: 0x04003426 RID: 13350
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
