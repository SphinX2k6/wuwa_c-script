using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C0 RID: 10176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.NormalCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UNormalCaster : USimplygonNormalCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F10 RID: 155408 RVA: 0x00398708 File Offset: 0x00396908
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNormalCaster._ClassPtr;
		}

		// Token: 0x06025F11 RID: 155409 RVA: 0x00398714 File Offset: 0x00396914
		public UNormalCaster() : this(BuiltinUtils.AllocNativeUObject(UNormalCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F12 RID: 155410 RVA: 0x0039873C File Offset: 0x0039693C
		public UNormalCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNormalCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700924D RID: 37453
		// (get) Token: 0x06025F13 RID: 155411 RVA: 0x00398770 File Offset: 0x00396970
		// (set) Token: 0x06025F14 RID: 155412 RVA: 0x003987A9 File Offset: 0x003969A9
		public FMaterialLODEditorInstanceSettings MaterialInstanceSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLODEditorInstanceSettings result;
				if ((result = this._MaterialInstanceSettings) == null)
				{
					result = (this._MaterialInstanceSettings = new FMaterialLODEditorInstanceSettings(base.NativePtr + (IntPtr)UNormalCaster.__PropertyOffset_MaterialInstanceSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLODEditorInstanceSettings.StaticStruct(), base.NativePtr + (IntPtr)UNormalCaster.__PropertyOffset_MaterialInstanceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025F15 RID: 155413 RVA: 0x003987CA File Offset: 0x003969CA
		static UNormalCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.NormalCaster");
		}

		// Token: 0x06025F16 RID: 155414 RVA: 0x003987D8 File Offset: 0x003969D8
		protected UNormalCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B5B RID: 84827
		public new const string __ObjectPath = "/Script/SimplygonUObjects.NormalCaster";

		// Token: 0x04014B5C RID: 84828
		private static IntPtr _ClassPtr;

		// Token: 0x04014B5D RID: 84829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014B5E RID: 84830
		internal static int __PropertyOffset_MaterialInstanceSettings;

		// Token: 0x04014B5F RID: 84831
		[Nullable(2)]
		private FMaterialLODEditorInstanceSettings _MaterialInstanceSettings;
	}
}
