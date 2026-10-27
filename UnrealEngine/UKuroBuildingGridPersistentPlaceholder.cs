using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B4 RID: 5812
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridPersistentPlaceholder")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroBuildingGridPersistentPlaceholder : UObject, IUnrealUObject, IUnrealObject, IKuroBuildingGridPlaceholderInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06015139 RID: 86329 RVA: 0x001EF9F2 File Offset: 0x001EDBF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridPersistentPlaceholder._ClassPtr;
		}

		// Token: 0x0601513A RID: 86330 RVA: 0x001EF9FE File Offset: 0x001EDBFE
		int IKuroBuildingGridPlaceholderInterface.InterfaceOffset()
		{
			return UKuroBuildingGridPersistentPlaceholder.__InterfaceOffset_IKuroBuildingGridPlaceholderInterface;
		}

		// Token: 0x0601513B RID: 86331 RVA: 0x001EFA08 File Offset: 0x001EDC08
		public UKuroBuildingGridPersistentPlaceholder() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridPersistentPlaceholder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601513C RID: 86332 RVA: 0x001EFA30 File Offset: 0x001EDC30
		[NullableContext(1)]
		public UKuroBuildingGridPersistentPlaceholder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridPersistentPlaceholder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601513D RID: 86333 RVA: 0x001EFA63 File Offset: 0x001EDC63
		static UKuroBuildingGridPersistentPlaceholder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridPersistentPlaceholder");
		}

		// Token: 0x0601513E RID: 86334 RVA: 0x001EFA71 File Offset: 0x001EDC71
		protected UKuroBuildingGridPersistentPlaceholder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B786 RID: 46982
		internal static int __InterfaceOffset_IKuroBuildingGridPlaceholderInterface;

		// Token: 0x0400B787 RID: 46983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridPersistentPlaceholder";

		// Token: 0x0400B788 RID: 46984
		private static IntPtr _ClassPtr;

		// Token: 0x0400B789 RID: 46985
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
