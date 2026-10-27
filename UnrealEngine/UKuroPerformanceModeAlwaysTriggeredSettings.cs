using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8B RID: 7051
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPerformanceModeAlwaysTriggeredSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroPerformanceModeAlwaysTriggeredSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AC12 RID: 109586 RVA: 0x00276DA5 File Offset: 0x00274FA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerformanceModeAlwaysTriggeredSettings._ClassPtr;
		}

		// Token: 0x0601AC13 RID: 109587 RVA: 0x00276DB4 File Offset: 0x00274FB4
		public UKuroPerformanceModeAlwaysTriggeredSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceModeAlwaysTriggeredSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AC14 RID: 109588 RVA: 0x00276DDC File Offset: 0x00274FDC
		public UKuroPerformanceModeAlwaysTriggeredSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceModeAlwaysTriggeredSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BA0 RID: 27552
		// (get) Token: 0x0601AC15 RID: 109589 RVA: 0x00276E10 File Offset: 0x00275010
		// (set) Token: 0x0601AC16 RID: 109590 RVA: 0x00276E49 File Offset: 0x00275049
		public TArray<string> AlwaysTriggeredCommand
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AlwaysTriggeredCommand) == null)
				{
					result = (this._AlwaysTriggeredCommand = new TArray<string>(base.NativePtr + (IntPtr)UKuroPerformanceModeAlwaysTriggeredSettings.__PropertyOffset_AlwaysTriggeredCommand, this));
				}
				return result;
			}
			set
			{
				this.AlwaysTriggeredCommand.CopyAssign(value);
			}
		}

		// Token: 0x0601AC17 RID: 109591 RVA: 0x00276E57 File Offset: 0x00275057
		static UKuroPerformanceModeAlwaysTriggeredSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPerformanceModeAlwaysTriggeredSettings");
		}

		// Token: 0x0601AC18 RID: 109592 RVA: 0x00276E65 File Offset: 0x00275065
		protected UKuroPerformanceModeAlwaysTriggeredSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E79A RID: 59290
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPerformanceModeAlwaysTriggeredSettings";

		// Token: 0x0400E79B RID: 59291
		private static IntPtr _ClassPtr;

		// Token: 0x0400E79C RID: 59292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E79D RID: 59293
		internal static int __PropertyOffset_AlwaysTriggeredCommand;

		// Token: 0x0400E79E RID: 59294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AlwaysTriggeredCommand;
	}
}
