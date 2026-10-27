using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A2 RID: 2466
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DebugCameraControllerSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UDebugCameraControllerSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B5E RID: 35678 RVA: 0x000C7B17 File Offset: 0x000C5D17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDebugCameraControllerSettings._ClassPtr;
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x000C7B24 File Offset: 0x000C5D24
		public UDebugCameraControllerSettings() : this(BuiltinUtils.AllocNativeUObject(UDebugCameraControllerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x000C7B4C File Offset: 0x000C5D4C
		public UDebugCameraControllerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDebugCameraControllerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06008B61 RID: 35681 RVA: 0x000C7B80 File Offset: 0x000C5D80
		// (set) Token: 0x06008B62 RID: 35682 RVA: 0x000C7BB9 File Offset: 0x000C5DB9
		public TArray<FDebugCameraControllerSettingsViewModeIndex> CycleViewModes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDebugCameraControllerSettingsViewModeIndex> result;
				if ((result = this._CycleViewModes) == null)
				{
					result = (this._CycleViewModes = new TArray<FDebugCameraControllerSettingsViewModeIndex>(base.NativePtr + (IntPtr)UDebugCameraControllerSettings.__PropertyOffset_CycleViewModes, this));
				}
				return result;
			}
			set
			{
				this.CycleViewModes.CopyAssign(value);
			}
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x000C7BC7 File Offset: 0x000C5DC7
		static UDebugCameraControllerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DebugCameraControllerSettings");
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x000C7BD5 File Offset: 0x000C5DD5
		protected UDebugCameraControllerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004234 RID: 16948
		public new const string __ObjectPath = "/Script/Engine.DebugCameraControllerSettings";

		// Token: 0x04004235 RID: 16949
		private static IntPtr _ClassPtr;

		// Token: 0x04004236 RID: 16950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004237 RID: 16951
		internal static int __PropertyOffset_CycleViewModes;

		// Token: 0x04004238 RID: 16952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDebugCameraControllerSettingsViewModeIndex> _CycleViewModes;
	}
}
