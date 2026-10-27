using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CED RID: 3309
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroFoliageTypeFolderCheckConfig")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FKuroFoliageTypeFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF95 RID: 44949 RVA: 0x000F9044 File Offset: 0x000F7244
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFoliageTypeFolderCheckConfig._ScriptStructPtr != 0) ? FKuroFoliageTypeFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroFoliageTypeFolderCheckConfig", ref FKuroFoliageTypeFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600AF96 RID: 44950 RVA: 0x000F9068 File Offset: 0x000F7268
		// (set) Token: 0x0600AF97 RID: 44951 RVA: 0x000F90AB File Offset: 0x000F72AB
		public TArray<string> StaticMeshRefFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshRefFolder) == null)
				{
					result = (this._StaticMeshRefFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_StaticMeshRefFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshRefFolder.CopyAssign(value);
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x000F90B9 File Offset: 0x000F72B9
		// (set) Token: 0x0600AF99 RID: 44953 RVA: 0x000F90C9 File Offset: 0x000F72C9
		public unsafe float DensityLowDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityLowDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityLowDefault) = value;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0600AF9A RID: 44954 RVA: 0x000F90DA File Offset: 0x000F72DA
		// (set) Token: 0x0600AF9B RID: 44955 RVA: 0x000F90EA File Offset: 0x000F72EA
		public unsafe float DensityMidDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityMidDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityMidDefault) = value;
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x000F90FB File Offset: 0x000F72FB
		// (set) Token: 0x0600AF9D RID: 44957 RVA: 0x000F910B File Offset: 0x000F730B
		public unsafe float DensityHighDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityHighDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_DensityHighDefault) = value;
			}
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x000F911C File Offset: 0x000F731C
		// (set) Token: 0x0600AF9F RID: 44959 RVA: 0x000F915F File Offset: 0x000F735F
		public TArray<string> PlatformSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PlatformSetting) == null)
				{
					result = (this._PlatformSetting = new TArray<string>(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_PlatformSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformSetting.CopyAssign(value);
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600AFA0 RID: 44960 RVA: 0x000F9170 File Offset: 0x000F7370
		// (set) Token: 0x0600AFA1 RID: 44961 RVA: 0x000F91B3 File Offset: 0x000F73B3
		public TArray<float> PlatformDensityLow
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PlatformDensityLow) == null)
				{
					result = (this._PlatformDensityLow = new TArray<float>(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_PlatformDensityLow, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformDensityLow.CopyAssign(value);
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x0600AFA2 RID: 44962 RVA: 0x000F91C4 File Offset: 0x000F73C4
		// (set) Token: 0x0600AFA3 RID: 44963 RVA: 0x000F9207 File Offset: 0x000F7407
		public TArray<float> PlatformDensityMid
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PlatformDensityMid) == null)
				{
					result = (this._PlatformDensityMid = new TArray<float>(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_PlatformDensityMid, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformDensityMid.CopyAssign(value);
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x000F9218 File Offset: 0x000F7418
		// (set) Token: 0x0600AFA5 RID: 44965 RVA: 0x000F925B File Offset: 0x000F745B
		public TArray<float> PlatformDensityHigh
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PlatformDensityHigh) == null)
				{
					result = (this._PlatformDensityHigh = new TArray<float>(base.NativePtr + (IntPtr)FKuroFoliageTypeFolderCheckConfig.__PropertyOffset_PlatformDensityHigh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformDensityHigh.CopyAssign(value);
			}
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x000F9269 File Offset: 0x000F7469
		public FKuroFoliageTypeFolderCheckConfig()
		{
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x000F9274 File Offset: 0x000F7474
		public FKuroFoliageTypeFolderCheckConfig(TArray<string> StaticMeshRefFolder, float DensityLowDefault, float DensityMidDefault, float DensityHighDefault, TArray<string> PlatformSetting, TArray<float> PlatformDensityLow, TArray<float> PlatformDensityMid, TArray<float> PlatformDensityHigh, string Regex, int MatchingPriority)
		{
			this.StaticMeshRefFolder = StaticMeshRefFolder;
			this.DensityLowDefault = DensityLowDefault;
			this.DensityMidDefault = DensityMidDefault;
			this.DensityHighDefault = DensityHighDefault;
			this.PlatformSetting = PlatformSetting;
			this.PlatformDensityLow = PlatformDensityLow;
			this.PlatformDensityMid = PlatformDensityMid;
			this.PlatformDensityHigh = PlatformDensityHigh;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x000F92D4 File Offset: 0x000F74D4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFoliageTypeFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x000F92E0 File Offset: 0x000F74E0
		[NullableContext(2)]
		public FKuroFoliageTypeFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AFAA RID: 44970 RVA: 0x000F92EA File Offset: 0x000F74EA
		public FKuroFoliageTypeFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x000F92F5 File Offset: 0x000F74F5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFoliageTypeFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x000F92FF File Offset: 0x000F74FF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFoliageTypeFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BEC RID: 23532
		public new const string __ObjectPath = "/Script/Engine.KuroFoliageTypeFolderCheckConfig";

		// Token: 0x04005BED RID: 23533
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BEE RID: 23534
		internal static int __PropertyOffset_StaticMeshRefFolder;

		// Token: 0x04005BEF RID: 23535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshRefFolder;

		// Token: 0x04005BF0 RID: 23536
		internal static int __PropertyOffset_DensityLowDefault;

		// Token: 0x04005BF1 RID: 23537
		internal static int __PropertyOffset_DensityMidDefault;

		// Token: 0x04005BF2 RID: 23538
		internal static int __PropertyOffset_DensityHighDefault;

		// Token: 0x04005BF3 RID: 23539
		internal static int __PropertyOffset_PlatformSetting;

		// Token: 0x04005BF4 RID: 23540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PlatformSetting;

		// Token: 0x04005BF5 RID: 23541
		internal static int __PropertyOffset_PlatformDensityLow;

		// Token: 0x04005BF6 RID: 23542
		[Nullable(2)]
		private TArray<float> _PlatformDensityLow;

		// Token: 0x04005BF7 RID: 23543
		internal static int __PropertyOffset_PlatformDensityMid;

		// Token: 0x04005BF8 RID: 23544
		[Nullable(2)]
		private TArray<float> _PlatformDensityMid;

		// Token: 0x04005BF9 RID: 23545
		internal static int __PropertyOffset_PlatformDensityHigh;

		// Token: 0x04005BFA RID: 23546
		[Nullable(2)]
		private TArray<float> _PlatformDensityHigh;
	}
}
