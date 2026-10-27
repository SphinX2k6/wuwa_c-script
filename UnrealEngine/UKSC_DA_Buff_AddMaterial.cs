using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D51 RID: 7505
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AddMaterial")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_AddMaterial : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBDE RID: 117726 RVA: 0x002A7C0C File Offset: 0x002A5E0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AddMaterial._ClassPtr;
		}

		// Token: 0x0601CBDF RID: 117727 RVA: 0x002A7C18 File Offset: 0x002A5E18
		public UKSC_DA_Buff_AddMaterial() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBE0 RID: 117728 RVA: 0x002A7C40 File Offset: 0x002A5E40
		[NullableContext(1)]
		public UKSC_DA_Buff_AddMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073A8 RID: 29608
		// (get) Token: 0x0601CBE1 RID: 117729 RVA: 0x002A7C73 File Offset: 0x002A5E73
		// (set) Token: 0x0601CBE2 RID: 117730 RVA: 0x002A7C87 File Offset: 0x002A5E87
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset DataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_AddMaterial.__PropertyOffset_DataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_AddMaterial.__PropertyOffset_DataAsset, value);
			}
		}

		// Token: 0x170073A9 RID: 29609
		// (get) Token: 0x0601CBE3 RID: 117731 RVA: 0x002A7C9C File Offset: 0x002A5E9C
		// (set) Token: 0x0601CBE4 RID: 117732 RVA: 0x002A7CAC File Offset: 0x002A5EAC
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddMaterial.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddMaterial.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x002A7CBD File Offset: 0x002A5EBD
		static UKSC_DA_Buff_AddMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AddMaterial");
		}

		// Token: 0x0601CBE6 RID: 117734 RVA: 0x002A7CCB File Offset: 0x002A5ECB
		protected UKSC_DA_Buff_AddMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F959 RID: 63833
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AddMaterial";

		// Token: 0x0400F95A RID: 63834
		private static IntPtr _ClassPtr;

		// Token: 0x0400F95B RID: 63835
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F95C RID: 63836
		internal static int __PropertyOffset_DataAsset;

		// Token: 0x0400F95D RID: 63837
		internal static int __PropertyOffset_bLoop;
	}
}
