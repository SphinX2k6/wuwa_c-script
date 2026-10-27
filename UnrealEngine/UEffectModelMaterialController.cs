using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A4 RID: 6308
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelMaterialController")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UEffectModelMaterialController : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060173EA RID: 95210 RVA: 0x0021E951 File Offset: 0x0021CB51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelMaterialController._ClassPtr;
		}

		// Token: 0x060173EB RID: 95211 RVA: 0x0021E960 File Offset: 0x0021CB60
		public UEffectModelMaterialController() : this(BuiltinUtils.AllocNativeUObject(UEffectModelMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060173EC RID: 95212 RVA: 0x0021E988 File Offset: 0x0021CB88
		[NullableContext(1)]
		public UEffectModelMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x060173ED RID: 95213 RVA: 0x0021E9BB File Offset: 0x0021CBBB
		// (set) Token: 0x060173EE RID: 95214 RVA: 0x0021E9CF File Offset: 0x0021CBCF
		public unsafe UKuroMaterialControllerDataAsset MaterialControllerData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMaterialController.__PropertyOffset_MaterialControllerData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMaterialController.__PropertyOffset_MaterialControllerData, value);
			}
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x060173EF RID: 95215 RVA: 0x0021E9E4 File Offset: 0x0021CBE4
		// (set) Token: 0x060173F0 RID: 95216 RVA: 0x0021E9F8 File Offset: 0x0021CBF8
		public unsafe UKuroMaterialControllerDataAsset MaterialControllerGroupData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMaterialController.__PropertyOffset_MaterialControllerGroupData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMaterialController.__PropertyOffset_MaterialControllerGroupData, value);
			}
		}

		// Token: 0x060173F1 RID: 95217 RVA: 0x0021EA0D File Offset: 0x0021CC0D
		static UEffectModelMaterialController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelMaterialController");
		}

		// Token: 0x060173F2 RID: 95218 RVA: 0x0021EA1B File Offset: 0x0021CC1B
		protected UEffectModelMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C9CD RID: 51661
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelMaterialController";

		// Token: 0x0400C9CE RID: 51662
		private static IntPtr _ClassPtr;

		// Token: 0x0400C9CF RID: 51663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C9D0 RID: 51664
		internal static int __PropertyOffset_MaterialControllerData;

		// Token: 0x0400C9D1 RID: 51665
		internal static int __PropertyOffset_MaterialControllerGroupData;
	}
}
