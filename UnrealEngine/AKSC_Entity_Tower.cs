using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE1 RID: 7649
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Tower")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class AKSC_Entity_Tower : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D3A5 RID: 119717 RVA: 0x002B2A9E File Offset: 0x002B0C9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Tower._ClassPtr;
		}

		// Token: 0x0601D3A6 RID: 119718 RVA: 0x002B2AAC File Offset: 0x002B0CAC
		public AKSC_Entity_Tower() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Tower.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D3A7 RID: 119719 RVA: 0x002B2AD4 File Offset: 0x002B0CD4
		[NullableContext(1)]
		public AKSC_Entity_Tower(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Tower.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007603 RID: 30211
		// (get) Token: 0x0601D3A8 RID: 119720 RVA: 0x002B2B07 File Offset: 0x002B0D07
		// (set) Token: 0x0601D3A9 RID: 119721 RVA: 0x002B2B1B File Offset: 0x002B0D1B
		[Nullable(2)]
		public unsafe UKSC_DA_Entity_Tower DaEntity_Tower_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity_Tower>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity_Tower.__PropertyOffset_DaEntity_Tower_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity_Tower.__PropertyOffset_DaEntity_Tower_, value);
			}
		}

		// Token: 0x0601D3AA RID: 119722 RVA: 0x002B2B30 File Offset: 0x002B0D30
		static AKSC_Entity_Tower()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Tower");
		}

		// Token: 0x0601D3AB RID: 119723 RVA: 0x002B2B3E File Offset: 0x002B0D3E
		protected AKSC_Entity_Tower(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDC9 RID: 64969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Tower";

		// Token: 0x0400FDCA RID: 64970
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDCB RID: 64971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDCC RID: 64972
		internal static int __PropertyOffset_DaEntity_Tower_;
	}
}
