using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C7 RID: 967
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelMaterialController")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UEffectModelMaterialController : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E8D RID: 24205 RVA: 0x00085D2C File Offset: 0x00083F2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelMaterialController._ClassPtr;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x00085D38 File Offset: 0x00083F38
		public UEffectModelMaterialController() : this(BuiltinUtils.AllocNativeUObject(UEffectModelMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x00085D60 File Offset: 0x00083F60
		[NullableContext(1)]
		public UEffectModelMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x00085D93 File Offset: 0x00083F93
		// (set) Token: 0x06005E91 RID: 24209 RVA: 0x00085DA7 File Offset: 0x00083FA7
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

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06005E92 RID: 24210 RVA: 0x00085DBC File Offset: 0x00083FBC
		// (set) Token: 0x06005E93 RID: 24211 RVA: 0x00085DD0 File Offset: 0x00083FD0
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

		// Token: 0x06005E94 RID: 24212 RVA: 0x00085DE5 File Offset: 0x00083FE5
		static UEffectModelMaterialController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelMaterialController");
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x00085DF3 File Offset: 0x00083FF3
		protected UEffectModelMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002797 RID: 10135
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelMaterialController";

		// Token: 0x04002798 RID: 10136
		private static IntPtr _ClassPtr;

		// Token: 0x04002799 RID: 10137
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400279A RID: 10138
		internal static int __PropertyOffset_MaterialControllerData;

		// Token: 0x0400279B RID: 10139
		internal static int __PropertyOffset_MaterialControllerGroupData;
	}
}
