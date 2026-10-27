using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C32 RID: 7218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.TODPPVManagerSubsystem")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UTODPPVManagerSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BF8A RID: 114570 RVA: 0x0029286F File Offset: 0x00290A6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTODPPVManagerSubsystem._ClassPtr;
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x0029287C File Offset: 0x00290A7C
		public UTODPPVManagerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UTODPPVManagerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BF8C RID: 114572 RVA: 0x002928A4 File Offset: 0x00290AA4
		public UTODPPVManagerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTODPPVManagerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070FD RID: 28925
		// (get) Token: 0x0601BF8D RID: 114573 RVA: 0x002928D8 File Offset: 0x00290AD8
		// (set) Token: 0x0601BF8E RID: 114574 RVA: 0x00292911 File Offset: 0x00290B11
		public TMap<AKuroPostProcessVolume, float> ProxiesToDayPPV
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKuroPostProcessVolume, float> result;
				if ((result = this._ProxiesToDayPPV) == null)
				{
					result = (this._ProxiesToDayPPV = new TMap<AKuroPostProcessVolume, float>(base.NativePtr + (IntPtr)UTODPPVManagerSubsystem.__PropertyOffset_ProxiesToDayPPV, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToDayPPV.CopyAssign(value);
			}
		}

		// Token: 0x170070FE RID: 28926
		// (get) Token: 0x0601BF8F RID: 114575 RVA: 0x00292920 File Offset: 0x00290B20
		// (set) Token: 0x0601BF90 RID: 114576 RVA: 0x00292959 File Offset: 0x00290B59
		public TMap<AKuroPostProcessVolume, float> ProxiesToNightPPV
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKuroPostProcessVolume, float> result;
				if ((result = this._ProxiesToNightPPV) == null)
				{
					result = (this._ProxiesToNightPPV = new TMap<AKuroPostProcessVolume, float>(base.NativePtr + (IntPtr)UTODPPVManagerSubsystem.__PropertyOffset_ProxiesToNightPPV, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToNightPPV.CopyAssign(value);
			}
		}

		// Token: 0x0601BF91 RID: 114577 RVA: 0x00292967 File Offset: 0x00290B67
		static UTODPPVManagerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.TODPPVManagerSubsystem");
		}

		// Token: 0x0601BF92 RID: 114578 RVA: 0x00292975 File Offset: 0x00290B75
		protected UTODPPVManagerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F056 RID: 61526
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.TODPPVManagerSubsystem";

		// Token: 0x0400F057 RID: 61527
		private static IntPtr _ClassPtr;

		// Token: 0x0400F058 RID: 61528
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F059 RID: 61529
		internal static int __PropertyOffset_ProxiesToDayPPV;

		// Token: 0x0400F05A RID: 61530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AKuroPostProcessVolume, float> _ProxiesToDayPPV;

		// Token: 0x0400F05B RID: 61531
		internal static int __PropertyOffset_ProxiesToNightPPV;

		// Token: 0x0400F05C RID: 61532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AKuroPostProcessVolume, float> _ProxiesToNightPPV;
	}
}
