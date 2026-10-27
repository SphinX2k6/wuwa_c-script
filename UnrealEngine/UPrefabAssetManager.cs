using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002656 RID: 9814
	[UnrealObjectPath("/Script/PrefabSystem.PrefabAssetManager")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UPrefabAssetManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060247A2 RID: 149410 RVA: 0x0035FF4A File Offset: 0x0035E14A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrefabAssetManager._ClassPtr;
		}

		// Token: 0x060247A3 RID: 149411 RVA: 0x0035FF58 File Offset: 0x0035E158
		public UPrefabAssetManager() : this(BuiltinUtils.AllocNativeUObject(UPrefabAssetManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247A4 RID: 149412 RVA: 0x0035FF80 File Offset: 0x0035E180
		[NullableContext(1)]
		public UPrefabAssetManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrefabAssetManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060247A5 RID: 149413 RVA: 0x0035FFB3 File Offset: 0x0035E1B3
		static UPrefabAssetManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PrefabSystem.PrefabAssetManager");
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x0035FFC1 File Offset: 0x0035E1C1
		protected UPrefabAssetManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013991 RID: 80273
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PrefabSystem.PrefabAssetManager";

		// Token: 0x04013992 RID: 80274
		private static IntPtr _ClassPtr;

		// Token: 0x04013993 RID: 80275
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
