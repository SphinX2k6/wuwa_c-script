using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001081 RID: 4225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RenderSwitchSettings")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class URenderSwitchSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F19A RID: 61850 RVA: 0x00166859 File Offset: 0x00164A59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URenderSwitchSettings._ClassPtr;
		}

		// Token: 0x0600F19B RID: 61851 RVA: 0x00166868 File Offset: 0x00164A68
		public URenderSwitchSettings() : this(BuiltinUtils.AllocNativeUObject(URenderSwitchSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F19C RID: 61852 RVA: 0x00166890 File Offset: 0x00164A90
		public URenderSwitchSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URenderSwitchSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600F19D RID: 61853 RVA: 0x001668C4 File Offset: 0x00164AC4
		// (set) Token: 0x0600F19E RID: 61854 RVA: 0x001668FD File Offset: 0x00164AFD
		public TArray<string> SceneMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SceneMaterials) == null)
				{
					result = (this._SceneMaterials = new TArray<string>(base.NativePtr + (IntPtr)URenderSwitchSettings.__PropertyOffset_SceneMaterials, this));
				}
				return result;
			}
			set
			{
				this.SceneMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600F19F RID: 61855 RVA: 0x0016690C File Offset: 0x00164B0C
		// (set) Token: 0x0600F1A0 RID: 61856 RVA: 0x00166945 File Offset: 0x00164B45
		public TArray<string> HLODMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HLODMaterials) == null)
				{
					result = (this._HLODMaterials = new TArray<string>(base.NativePtr + (IntPtr)URenderSwitchSettings.__PropertyOffset_HLODMaterials, this));
				}
				return result;
			}
			set
			{
				this.HLODMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x00166954 File Offset: 0x00164B54
		// (set) Token: 0x0600F1A2 RID: 61858 RVA: 0x0016698D File Offset: 0x00164B8D
		public TArray<string> TerrainHLODMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TerrainHLODMaterials) == null)
				{
					result = (this._TerrainHLODMaterials = new TArray<string>(base.NativePtr + (IntPtr)URenderSwitchSettings.__PropertyOffset_TerrainHLODMaterials, this));
				}
				return result;
			}
			set
			{
				this.TerrainHLODMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600F1A3 RID: 61859 RVA: 0x0016699C File Offset: 0x00164B9C
		// (set) Token: 0x0600F1A4 RID: 61860 RVA: 0x001669D5 File Offset: 0x00164BD5
		public TArray<string> DecalMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DecalMaterials) == null)
				{
					result = (this._DecalMaterials = new TArray<string>(base.NativePtr + (IntPtr)URenderSwitchSettings.__PropertyOffset_DecalMaterials, this));
				}
				return result;
			}
			set
			{
				this.DecalMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600F1A5 RID: 61861 RVA: 0x001669E4 File Offset: 0x00164BE4
		// (set) Token: 0x0600F1A6 RID: 61862 RVA: 0x00166A1D File Offset: 0x00164C1D
		public TArray<string> OtherMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OtherMaterials) == null)
				{
					result = (this._OtherMaterials = new TArray<string>(base.NativePtr + (IntPtr)URenderSwitchSettings.__PropertyOffset_OtherMaterials, this));
				}
				return result;
			}
			set
			{
				this.OtherMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0600F1A7 RID: 61863 RVA: 0x00166A2B File Offset: 0x00164C2B
		static URenderSwitchSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RenderSwitchSettings");
		}

		// Token: 0x0600F1A8 RID: 61864 RVA: 0x00166A39 File Offset: 0x00164C39
		protected URenderSwitchSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008300 RID: 33536
		public new const string __ObjectPath = "/Script/Engine.RenderSwitchSettings";

		// Token: 0x04008301 RID: 33537
		private static IntPtr _ClassPtr;

		// Token: 0x04008302 RID: 33538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008303 RID: 33539
		internal static int __PropertyOffset_SceneMaterials;

		// Token: 0x04008304 RID: 33540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SceneMaterials;

		// Token: 0x04008305 RID: 33541
		internal static int __PropertyOffset_HLODMaterials;

		// Token: 0x04008306 RID: 33542
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HLODMaterials;

		// Token: 0x04008307 RID: 33543
		internal static int __PropertyOffset_TerrainHLODMaterials;

		// Token: 0x04008308 RID: 33544
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TerrainHLODMaterials;

		// Token: 0x04008309 RID: 33545
		internal static int __PropertyOffset_DecalMaterials;

		// Token: 0x0400830A RID: 33546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DecalMaterials;

		// Token: 0x0400830B RID: 33547
		internal static int __PropertyOffset_OtherMaterials;

		// Token: 0x0400830C RID: 33548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OtherMaterials;
	}
}
