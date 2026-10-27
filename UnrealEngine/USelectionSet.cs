using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001593 RID: 5523
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SelectionSet")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class USelectionSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EC7 RID: 81607 RVA: 0x001D419E File Offset: 0x001D239E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USelectionSet._ClassPtr;
		}

		// Token: 0x06013EC8 RID: 81608 RVA: 0x001D41AC File Offset: 0x001D23AC
		public USelectionSet() : this(BuiltinUtils.AllocNativeUObject(USelectionSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EC9 RID: 81609 RVA: 0x001D41D4 File Offset: 0x001D23D4
		[NullableContext(1)]
		public USelectionSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USelectionSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013ECA RID: 81610 RVA: 0x001D4207 File Offset: 0x001D2407
		static USelectionSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SelectionSet");
		}

		// Token: 0x06013ECB RID: 81611 RVA: 0x001D4215 File Offset: 0x001D2415
		protected USelectionSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC89 RID: 44169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SelectionSet";

		// Token: 0x0400AC8A RID: 44170
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC8B RID: 44171
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
