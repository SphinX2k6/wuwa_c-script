using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B5 RID: 5813
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridPlaceholderComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroBuildingGridPlaceholderComponent : UActorComponent, IUnrealUObject, IUnrealObject, IKuroBuildingGridPlaceholderInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601513F RID: 86335 RVA: 0x001EFA7A File Offset: 0x001EDC7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridPlaceholderComponent._ClassPtr;
		}

		// Token: 0x06015140 RID: 86336 RVA: 0x001EFA86 File Offset: 0x001EDC86
		int IKuroBuildingGridPlaceholderInterface.InterfaceOffset()
		{
			return UKuroBuildingGridPlaceholderComponent.__InterfaceOffset_IKuroBuildingGridPlaceholderInterface;
		}

		// Token: 0x06015141 RID: 86337 RVA: 0x001EFA90 File Offset: 0x001EDC90
		public UKuroBuildingGridPlaceholderComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridPlaceholderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015142 RID: 86338 RVA: 0x001EFAB8 File Offset: 0x001EDCB8
		[NullableContext(1)]
		public UKuroBuildingGridPlaceholderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridPlaceholderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x06015143 RID: 86339 RVA: 0x001EFAEB File Offset: 0x001EDCEB
		// (set) Token: 0x06015144 RID: 86340 RVA: 0x001EFAFF File Offset: 0x001EDCFF
		public unsafe FKuroBuildingGridCellVector GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBuildingGridPlaceholderComponent.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBuildingGridPlaceholderComponent.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x06015145 RID: 86341 RVA: 0x001EFB14 File Offset: 0x001EDD14
		static UKuroBuildingGridPlaceholderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridPlaceholderComponent");
		}

		// Token: 0x06015146 RID: 86342 RVA: 0x001EFB22 File Offset: 0x001EDD22
		protected UKuroBuildingGridPlaceholderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B78A RID: 46986
		internal static int __InterfaceOffset_IKuroBuildingGridPlaceholderInterface;

		// Token: 0x0400B78B RID: 46987
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridPlaceholderComponent";

		// Token: 0x0400B78C RID: 46988
		private static IntPtr _ClassPtr;

		// Token: 0x0400B78D RID: 46989
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B78E RID: 46990
		internal static int __PropertyOffset_GridSize;
	}
}
