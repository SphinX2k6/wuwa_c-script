using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000187 RID: 391
	[UnrealObjectPath("/Script/Engine.BakedBoneInstanceDataAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBakedBoneInstanceDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001927 RID: 6439 RVA: 0x000261F6 File Offset: 0x000243F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneInstanceDataAsset._ClassPtr;
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00026204 File Offset: 0x00024404
		public UBakedBoneInstanceDataAsset() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneInstanceDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0002622C File Offset: 0x0002442C
		[NullableContext(1)]
		public UBakedBoneInstanceDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneInstanceDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0002625F File Offset: 0x0002445F
		static UBakedBoneInstanceDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneInstanceDataAsset");
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0002626D File Offset: 0x0002446D
		protected UBakedBoneInstanceDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000815 RID: 2069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BakedBoneInstanceDataAsset";

		// Token: 0x04000816 RID: 2070
		private static IntPtr _ClassPtr;

		// Token: 0x04000817 RID: 2071
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
