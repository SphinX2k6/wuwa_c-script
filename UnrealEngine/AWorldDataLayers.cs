using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200124C RID: 4684
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldDataLayers")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2152)]
	public class AWorldDataLayers : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060113C4 RID: 70596 RVA: 0x001949D4 File Offset: 0x00192BD4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldDataLayers._ClassPtr;
		}

		// Token: 0x060113C5 RID: 70597 RVA: 0x001949E0 File Offset: 0x00192BE0
		public AWorldDataLayers() : this(BuiltinUtils.AllocNativeUObject(AWorldDataLayers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060113C6 RID: 70598 RVA: 0x00194A08 File Offset: 0x00192C08
		public AWorldDataLayers(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldDataLayers.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x060113C7 RID: 70599 RVA: 0x00194A3C File Offset: 0x00192C3C
		// (set) Token: 0x060113C8 RID: 70600 RVA: 0x00194A75 File Offset: 0x00192C75
		public TSet<UDataLayer> WorldDataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UDataLayer> result;
				if ((result = this._WorldDataLayers) == null)
				{
					result = (this._WorldDataLayers = new TSet<UDataLayer>(base.NativePtr + (IntPtr)AWorldDataLayers.__PropertyOffset_WorldDataLayers, this));
				}
				return result;
			}
			set
			{
				this.WorldDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x060113C9 RID: 70601 RVA: 0x00194A84 File Offset: 0x00192C84
		// (set) Token: 0x060113CA RID: 70602 RVA: 0x00194ABD File Offset: 0x00192CBD
		public TSet<UDataLayerInstance> DataLayerInstances
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UDataLayerInstance> result;
				if ((result = this._DataLayerInstances) == null)
				{
					result = (this._DataLayerInstances = new TSet<UDataLayerInstance>(base.NativePtr + (IntPtr)AWorldDataLayers.__PropertyOffset_DataLayerInstances, this));
				}
				return result;
			}
			set
			{
				this.DataLayerInstances.CopyAssign(value);
			}
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x060113CB RID: 70603 RVA: 0x00194ACC File Offset: 0x00192CCC
		// (set) Token: 0x060113CC RID: 70604 RVA: 0x00194B05 File Offset: 0x00192D05
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<FName, TWeakObjectPtr<UDataLayerInstance>> DeprecatedDataLayerNameToDataLayerInstance
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TWeakObjectPtr<UDataLayerInstance>> result;
				if ((result = this._DeprecatedDataLayerNameToDataLayerInstance) == null)
				{
					result = (this._DeprecatedDataLayerNameToDataLayerInstance = new TMap<FName, TWeakObjectPtr<UDataLayerInstance>>(base.NativePtr + (IntPtr)AWorldDataLayers.__PropertyOffset_DeprecatedDataLayerNameToDataLayerInstance, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DeprecatedDataLayerNameToDataLayerInstance.CopyAssign(value);
			}
		}

		// Token: 0x060113CD RID: 70605 RVA: 0x00194B13 File Offset: 0x00192D13
		static AWorldDataLayers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldDataLayers");
		}

		// Token: 0x060113CE RID: 70606 RVA: 0x00194B21 File Offset: 0x00192D21
		protected AWorldDataLayers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400937B RID: 37755
		public new const string __ObjectPath = "/Script/Engine.WorldDataLayers";

		// Token: 0x0400937C RID: 37756
		private static IntPtr _ClassPtr;

		// Token: 0x0400937D RID: 37757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400937E RID: 37758
		internal static int __PropertyOffset_WorldDataLayers;

		// Token: 0x0400937F RID: 37759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UDataLayer> _WorldDataLayers;

		// Token: 0x04009380 RID: 37760
		internal static int __PropertyOffset_DataLayerInstances;

		// Token: 0x04009381 RID: 37761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UDataLayerInstance> _DataLayerInstances;

		// Token: 0x04009382 RID: 37762
		internal static int __PropertyOffset_DeprecatedDataLayerNameToDataLayerInstance;

		// Token: 0x04009383 RID: 37763
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<FName, TWeakObjectPtr<UDataLayerInstance>> _DeprecatedDataLayerNameToDataLayerInstance;
	}
}
