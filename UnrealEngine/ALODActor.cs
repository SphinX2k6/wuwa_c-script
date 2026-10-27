using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D66 RID: 3430
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LODActor")]
	[UnrealStructLayout(1400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1400)]
	public class ALODActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B947 RID: 47431 RVA: 0x001079FB File Offset: 0x00105BFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALODActor._ClassPtr;
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x00107A08 File Offset: 0x00105C08
		public ALODActor() : this(BuiltinUtils.AllocNativeUObject(ALODActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x00107A30 File Offset: 0x00105C30
		public ALODActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALODActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0600B94A RID: 47434 RVA: 0x00107A63 File Offset: 0x00105C63
		// (set) Token: 0x0600B94B RID: 47435 RVA: 0x00107A77 File Offset: 0x00105C77
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALODActor.__PropertyOffset_StaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALODActor.__PropertyOffset_StaticMeshComponent, value);
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600B94C RID: 47436 RVA: 0x00107A8C File Offset: 0x00105C8C
		// (set) Token: 0x0600B94D RID: 47437 RVA: 0x00107AC5 File Offset: 0x00105CC5
		public TMap<FHLODInstancingKey, UInstancedStaticMeshComponent> InstancedStaticMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHLODInstancingKey, UInstancedStaticMeshComponent> result;
				if ((result = this._InstancedStaticMeshComponents) == null)
				{
					result = (this._InstancedStaticMeshComponents = new TMap<FHLODInstancingKey, UInstancedStaticMeshComponent>(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_InstancedStaticMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.InstancedStaticMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x00107AD3 File Offset: 0x00105CD3
		// (set) Token: 0x0600B94F RID: 47439 RVA: 0x00107AE7 File Offset: 0x00105CE7
		[Nullable(2)]
		public unsafe UHLODProxy Proxy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHLODProxy>(base.NativePtr / (IntPtr)sizeof(void*) + ALODActor.__PropertyOffset_Proxy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALODActor.__PropertyOffset_Proxy, value);
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600B950 RID: 47440 RVA: 0x00107AFC File Offset: 0x00105CFC
		// (set) Token: 0x0600B951 RID: 47441 RVA: 0x00107B10 File Offset: 0x00105D10
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x00107B25 File Offset: 0x00105D25
		// (set) Token: 0x0600B953 RID: 47443 RVA: 0x00107B35 File Offset: 0x00105D35
		public unsafe float LODDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_LODDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_LODDrawDistance) = value;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600B954 RID: 47444 RVA: 0x00107B46 File Offset: 0x00105D46
		// (set) Token: 0x0600B955 RID: 47445 RVA: 0x00107B56 File Offset: 0x00105D56
		public unsafe int LODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_LODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_LODLevel) = value;
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600B956 RID: 47446 RVA: 0x00107B68 File Offset: 0x00105D68
		// (set) Token: 0x0600B957 RID: 47447 RVA: 0x00107BA1 File Offset: 0x00105DA1
		public TArray<AActor> SubActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._SubActors) == null)
				{
					result = (this._SubActors = new TArray<AActor>(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_SubActors, this));
				}
				return result;
			}
			set
			{
				this.SubActors.CopyAssign(value);
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600B958 RID: 47448 RVA: 0x00107BAF File Offset: 0x00105DAF
		// (set) Token: 0x0600B959 RID: 47449 RVA: 0x00107BBF File Offset: 0x00105DBF
		public unsafe byte CachedNumHLODLevels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_CachedNumHLODLevels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALODActor.__PropertyOffset_CachedNumHLODLevels) = value;
			}
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x00107BD0 File Offset: 0x00105DD0
		static ALODActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LODActor");
		}

		// Token: 0x0600B95B RID: 47451 RVA: 0x00107BDE File Offset: 0x00105DDE
		protected ALODActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006112 RID: 24850
		public new const string __ObjectPath = "/Script/Engine.LODActor";

		// Token: 0x04006113 RID: 24851
		private static IntPtr _ClassPtr;

		// Token: 0x04006114 RID: 24852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006115 RID: 24853
		internal static int __PropertyOffset_StaticMeshComponent;

		// Token: 0x04006116 RID: 24854
		internal static int __PropertyOffset_InstancedStaticMeshComponents;

		// Token: 0x04006117 RID: 24855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FHLODInstancingKey, UInstancedStaticMeshComponent> _InstancedStaticMeshComponents;

		// Token: 0x04006118 RID: 24856
		internal static int __PropertyOffset_Proxy;

		// Token: 0x04006119 RID: 24857
		internal static int __PropertyOffset_Key;

		// Token: 0x0400611A RID: 24858
		internal static int __PropertyOffset_LODDrawDistance;

		// Token: 0x0400611B RID: 24859
		internal static int __PropertyOffset_LODLevel;

		// Token: 0x0400611C RID: 24860
		internal static int __PropertyOffset_SubActors;

		// Token: 0x0400611D RID: 24861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _SubActors;

		// Token: 0x0400611E RID: 24862
		internal static int __PropertyOffset_CachedNumHLODLevels;
	}
}
