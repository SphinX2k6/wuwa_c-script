using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E3C RID: 7740
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds_Item")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Shape2D_WorldBounds_Item : UObject, IUnrealUObject, IUnrealObject, IKSC_ShapeCollisionInterface, IUnrealNativeInterface, IUnrealInterface, IKuroFastCollisionInterface_Shape
	{
		// Token: 0x0601D7F1 RID: 120817 RVA: 0x002B8D1C File Offset: 0x002B6F1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2D_WorldBounds_Item._ClassPtr;
		}

		// Token: 0x0601D7F2 RID: 120818 RVA: 0x002B8D28 File Offset: 0x002B6F28
		int IKSC_ShapeCollisionInterface.InterfaceOffset()
		{
			return UKSC_Shape2D_WorldBounds_Item.__InterfaceOffset_IKSC_ShapeCollisionInterface;
		}

		// Token: 0x0601D7F3 RID: 120819 RVA: 0x002B8D2F File Offset: 0x002B6F2F
		int IKuroFastCollisionInterface_Shape.InterfaceOffset()
		{
			return UKSC_Shape2D_WorldBounds_Item.__InterfaceOffset_IKuroFastCollisionInterface_Shape;
		}

		// Token: 0x0601D7F4 RID: 120820 RVA: 0x002B8D38 File Offset: 0x002B6F38
		public UKSC_Shape2D_WorldBounds_Item() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_WorldBounds_Item.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7F5 RID: 120821 RVA: 0x002B8D60 File Offset: 0x002B6F60
		[NullableContext(1)]
		public UKSC_Shape2D_WorldBounds_Item(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_WorldBounds_Item.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D7F6 RID: 120822 RVA: 0x002B8D93 File Offset: 0x002B6F93
		static UKSC_Shape2D_WorldBounds_Item()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds_Item");
		}

		// Token: 0x0601D7F7 RID: 120823 RVA: 0x002B8DA1 File Offset: 0x002B6FA1
		protected UKSC_Shape2D_WorldBounds_Item(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFCB RID: 65483
		internal static int __InterfaceOffset_IKSC_ShapeCollisionInterface;

		// Token: 0x0400FFCC RID: 65484
		internal static int __InterfaceOffset_IKuroFastCollisionInterface_Shape;

		// Token: 0x0400FFCD RID: 65485
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds_Item";

		// Token: 0x0400FFCE RID: 65486
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFCF RID: 65487
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
