using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200277B RID: 10107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BaseColorCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UBaseColorCaster : USimplygonColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025C8D RID: 154765 RVA: 0x00394770 File Offset: 0x00392970
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseColorCaster._ClassPtr;
		}

		// Token: 0x06025C8E RID: 154766 RVA: 0x0039477C File Offset: 0x0039297C
		public UBaseColorCaster() : this(BuiltinUtils.AllocNativeUObject(UBaseColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025C8F RID: 154767 RVA: 0x003947A4 File Offset: 0x003929A4
		public UBaseColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700917E RID: 37246
		// (get) Token: 0x06025C90 RID: 154768 RVA: 0x003947D8 File Offset: 0x003929D8
		// (set) Token: 0x06025C91 RID: 154769 RVA: 0x00394811 File Offset: 0x00392A11
		public FMaterialLODEditorInstanceSettings MaterialInstanceSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLODEditorInstanceSettings result;
				if ((result = this._MaterialInstanceSettings) == null)
				{
					result = (this._MaterialInstanceSettings = new FMaterialLODEditorInstanceSettings(base.NativePtr + (IntPtr)UBaseColorCaster.__PropertyOffset_MaterialInstanceSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLODEditorInstanceSettings.StaticStruct(), base.NativePtr + (IntPtr)UBaseColorCaster.__PropertyOffset_MaterialInstanceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025C92 RID: 154770 RVA: 0x00394832 File Offset: 0x00392A32
		static UBaseColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.BaseColorCaster");
		}

		// Token: 0x06025C93 RID: 154771 RVA: 0x00394840 File Offset: 0x00392A40
		protected UBaseColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401491C RID: 84252
		public new const string __ObjectPath = "/Script/SimplygonUObjects.BaseColorCaster";

		// Token: 0x0401491D RID: 84253
		private static IntPtr _ClassPtr;

		// Token: 0x0401491E RID: 84254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401491F RID: 84255
		internal static int __PropertyOffset_MaterialInstanceSettings;

		// Token: 0x04014920 RID: 84256
		[Nullable(2)]
		private FMaterialLODEditorInstanceSettings _MaterialInstanceSettings;
	}
}
