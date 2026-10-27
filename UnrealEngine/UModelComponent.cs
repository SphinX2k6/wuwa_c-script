using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB2 RID: 3762
	[UnrealObjectPath("/Script/Engine.ModelComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UModelComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600CBA1 RID: 52129 RVA: 0x00128DA6 File Offset: 0x00126FA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UModelComponent._ClassPtr;
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x00128DB2 File Offset: 0x00126FB2
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UModelComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x00128DBC File Offset: 0x00126FBC
		public UModelComponent() : this(BuiltinUtils.AllocNativeUObject(UModelComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x00128DE4 File Offset: 0x00126FE4
		[NullableContext(1)]
		public UModelComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UModelComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600CBA5 RID: 52133 RVA: 0x00128E17 File Offset: 0x00127017
		// (set) Token: 0x0600CBA6 RID: 52134 RVA: 0x00128E2B File Offset: 0x0012702B
		[Nullable(2)]
		public unsafe UBodySetup ModelBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UModelComponent.__PropertyOffset_ModelBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UModelComponent.__PropertyOffset_ModelBodySetup, value);
			}
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x00128E40 File Offset: 0x00127040
		static UModelComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ModelComponent");
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x00128E4E File Offset: 0x0012704E
		protected UModelComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DB9 RID: 28089
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04006DBA RID: 28090
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ModelComponent";

		// Token: 0x04006DBB RID: 28091
		private static IntPtr _ClassPtr;

		// Token: 0x04006DBC RID: 28092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DBD RID: 28093
		internal static int __PropertyOffset_ModelBodySetup;
	}
}
