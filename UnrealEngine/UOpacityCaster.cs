using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C3 RID: 10179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.OpacityCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UOpacityCaster : USimplygonOpacityCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F44 RID: 155460 RVA: 0x00398C62 File Offset: 0x00396E62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityCaster._ClassPtr;
		}

		// Token: 0x06025F45 RID: 155461 RVA: 0x00398C70 File Offset: 0x00396E70
		public UOpacityCaster() : this(BuiltinUtils.AllocNativeUObject(UOpacityCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F46 RID: 155462 RVA: 0x00398C98 File Offset: 0x00396E98
		public UOpacityCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700925E RID: 37470
		// (get) Token: 0x06025F47 RID: 155463 RVA: 0x00398CCC File Offset: 0x00396ECC
		// (set) Token: 0x06025F48 RID: 155464 RVA: 0x00398D05 File Offset: 0x00396F05
		public FMaterialLODEditorInstanceSettings MaterialInstanceSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLODEditorInstanceSettings result;
				if ((result = this._MaterialInstanceSettings) == null)
				{
					result = (this._MaterialInstanceSettings = new FMaterialLODEditorInstanceSettings(base.NativePtr + (IntPtr)UOpacityCaster.__PropertyOffset_MaterialInstanceSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLODEditorInstanceSettings.StaticStruct(), base.NativePtr + (IntPtr)UOpacityCaster.__PropertyOffset_MaterialInstanceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025F49 RID: 155465 RVA: 0x00398D26 File Offset: 0x00396F26
		static UOpacityCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.OpacityCaster");
		}

		// Token: 0x06025F4A RID: 155466 RVA: 0x00398D34 File Offset: 0x00396F34
		protected UOpacityCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B7B RID: 84859
		public new const string __ObjectPath = "/Script/SimplygonUObjects.OpacityCaster";

		// Token: 0x04014B7C RID: 84860
		private static IntPtr _ClassPtr;

		// Token: 0x04014B7D RID: 84861
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014B7E RID: 84862
		internal static int __PropertyOffset_MaterialInstanceSettings;

		// Token: 0x04014B7F RID: 84863
		[Nullable(2)]
		private FMaterialLODEditorInstanceSettings _MaterialInstanceSettings;
	}
}
