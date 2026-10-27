using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E2D RID: 7725
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2DComp")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_Shape2DComp : UKSC_SceneComp, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D71A RID: 120602 RVA: 0x002B7D2C File Offset: 0x002B5F2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2DComp._ClassPtr;
		}

		// Token: 0x0601D71B RID: 120603 RVA: 0x002B7D38 File Offset: 0x002B5F38
		public UKSC_Shape2DComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D71C RID: 120604 RVA: 0x002B7D60 File Offset: 0x002B5F60
		[NullableContext(1)]
		public UKSC_Shape2DComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076B0 RID: 30384
		// (get) Token: 0x0601D71D RID: 120605 RVA: 0x002B7D93 File Offset: 0x002B5F93
		// (set) Token: 0x0601D71E RID: 120606 RVA: 0x002B7DA7 File Offset: 0x002B5FA7
		[Nullable(2)]
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DComp.__PropertyOffset_KscShapeWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DComp.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x0601D71F RID: 120607 RVA: 0x002B7DBC File Offset: 0x002B5FBC
		static UKSC_Shape2DComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2DComp");
		}

		// Token: 0x0601D720 RID: 120608 RVA: 0x002B7DCA File Offset: 0x002B5FCA
		protected UKSC_Shape2DComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF73 RID: 65395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2DComp";

		// Token: 0x0400FF74 RID: 65396
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF75 RID: 65397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF76 RID: 65398
		internal static int __PropertyOffset_KscShapeWorld;
	}
}
