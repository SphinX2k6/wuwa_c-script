using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E36 RID: 7734
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class AKSC_Shape2D_Entity_Enemy : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D785 RID: 120709 RVA: 0x002B84F4 File Offset: 0x002B66F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Enemy._ClassPtr;
		}

		// Token: 0x0601D786 RID: 120710 RVA: 0x002B8500 File Offset: 0x002B6700
		public AKSC_Shape2D_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D787 RID: 120711 RVA: 0x002B8528 File Offset: 0x002B6728
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D788 RID: 120712 RVA: 0x002B855B File Offset: 0x002B675B
		static AKSC_Shape2D_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy");
		}

		// Token: 0x0601D789 RID: 120713 RVA: 0x002B8569 File Offset: 0x002B6769
		protected AKSC_Shape2D_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFA4 RID: 65444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy";

		// Token: 0x0400FFA5 RID: 65445
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFA6 RID: 65446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
