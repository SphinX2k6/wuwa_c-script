using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079F RID: 1951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.HudSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UHudSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060065C0 RID: 26048 RVA: 0x00091E42 File Offset: 0x00090042
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHudSettings._ClassPtr;
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00091E50 File Offset: 0x00090050
		public UHudSettings() : this(BuiltinUtils.AllocNativeUObject(UHudSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00091E78 File Offset: 0x00090078
		public UHudSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHudSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x00091EAB File Offset: 0x000900AB
		// (set) Token: 0x060065C4 RID: 26052 RVA: 0x00091EC4 File Offset: 0x000900C4
		public unsafe bool bShowHUD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHudSettings.__PropertyOffset_bShowHUD) & UHudSettings.__PropertyMask_bShowHUD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHudSettings.__PropertyOffset_bShowHUD) = ((*(base.NativePtr + (IntPtr)UHudSettings.__PropertyOffset_bShowHUD) & ~UHudSettings.__PropertyMask_bShowHUD) | (value ? UHudSettings.__PropertyMask_bShowHUD : 0));
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x00091EF4 File Offset: 0x000900F4
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x00091F2D File Offset: 0x0009012D
		public TArray<FName> DebugDisplay
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DebugDisplay) == null)
				{
					result = (this._DebugDisplay = new TArray<FName>(base.NativePtr + (IntPtr)UHudSettings.__PropertyOffset_DebugDisplay, this));
				}
				return result;
			}
			set
			{
				this.DebugDisplay.CopyAssign(value);
			}
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00091F3B File Offset: 0x0009013B
		static UHudSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.HudSettings");
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00091F49 File Offset: 0x00090149
		protected UHudSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003166 RID: 12646
		public new const string __ObjectPath = "/Script/EngineSettings.HudSettings";

		// Token: 0x04003167 RID: 12647
		private static IntPtr _ClassPtr;

		// Token: 0x04003168 RID: 12648
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003169 RID: 12649
		internal static int __PropertyOffset_bShowHUD;

		// Token: 0x0400316A RID: 12650
		internal static byte __PropertyMask_bShowHUD;

		// Token: 0x0400316B RID: 12651
		internal static int __PropertyOffset_DebugDisplay;

		// Token: 0x0400316C RID: 12652
		[Nullable(2)]
		private TArray<FName> _DebugDisplay;
	}
}
