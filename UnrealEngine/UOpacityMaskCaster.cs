using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C5 RID: 10181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.OpacityMaskCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UOpacityMaskCaster : USimplygonOpacityCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F6D RID: 155501 RVA: 0x0039904C File Offset: 0x0039724C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMaskCaster._ClassPtr;
		}

		// Token: 0x06025F6E RID: 155502 RVA: 0x00399058 File Offset: 0x00397258
		public UOpacityMaskCaster() : this(BuiltinUtils.AllocNativeUObject(UOpacityMaskCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F6F RID: 155503 RVA: 0x00399080 File Offset: 0x00397280
		public UOpacityMaskCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMaskCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700926C RID: 37484
		// (get) Token: 0x06025F70 RID: 155504 RVA: 0x003990B4 File Offset: 0x003972B4
		// (set) Token: 0x06025F71 RID: 155505 RVA: 0x003990ED File Offset: 0x003972ED
		public FMaterialLODEditorInstanceSettings MaterialInstanceSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLODEditorInstanceSettings result;
				if ((result = this._MaterialInstanceSettings) == null)
				{
					result = (this._MaterialInstanceSettings = new FMaterialLODEditorInstanceSettings(base.NativePtr + (IntPtr)UOpacityMaskCaster.__PropertyOffset_MaterialInstanceSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLODEditorInstanceSettings.StaticStruct(), base.NativePtr + (IntPtr)UOpacityMaskCaster.__PropertyOffset_MaterialInstanceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025F72 RID: 155506 RVA: 0x0039910E File Offset: 0x0039730E
		static UOpacityMaskCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.OpacityMaskCaster");
		}

		// Token: 0x06025F73 RID: 155507 RVA: 0x0039911C File Offset: 0x0039731C
		protected UOpacityMaskCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B92 RID: 84882
		public new const string __ObjectPath = "/Script/SimplygonUObjects.OpacityMaskCaster";

		// Token: 0x04014B93 RID: 84883
		private static IntPtr _ClassPtr;

		// Token: 0x04014B94 RID: 84884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014B95 RID: 84885
		internal static int __PropertyOffset_MaterialInstanceSettings;

		// Token: 0x04014B96 RID: 84886
		[Nullable(2)]
		private FMaterialLODEditorInstanceSettings _MaterialInstanceSettings;
	}
}
