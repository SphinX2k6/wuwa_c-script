using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E5 RID: 5349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniOutput")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UHoudiniOutput : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060135C8 RID: 79304 RVA: 0x001C782A File Offset: 0x001C5A2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniOutput._ClassPtr;
		}

		// Token: 0x060135C9 RID: 79305 RVA: 0x001C7838 File Offset: 0x001C5A38
		public UHoudiniOutput() : this(BuiltinUtils.AllocNativeUObject(UHoudiniOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060135CA RID: 79306 RVA: 0x001C7860 File Offset: 0x001C5A60
		public UHoudiniOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x060135CB RID: 79307 RVA: 0x001C7893 File Offset: 0x001C5A93
		// (set) Token: 0x060135CC RID: 79308 RVA: 0x001C78A3 File Offset: 0x001C5AA3
		public unsafe EHoudiniOutputType Type
		{
			get
			{
				return (EHoudiniOutputType)(*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x060135CD RID: 79309 RVA: 0x001C78B4 File Offset: 0x001C5AB4
		// (set) Token: 0x060135CE RID: 79310 RVA: 0x001C78ED File Offset: 0x001C5AED
		public TArray<FHoudiniGeoPartObject> HoudiniGeoPartObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHoudiniGeoPartObject> result;
				if ((result = this._HoudiniGeoPartObjects) == null)
				{
					result = (this._HoudiniGeoPartObjects = new TArray<FHoudiniGeoPartObject>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_HoudiniGeoPartObjects, this));
				}
				return result;
			}
			set
			{
				this.HoudiniGeoPartObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x060135CF RID: 79311 RVA: 0x001C78FC File Offset: 0x001C5AFC
		// (set) Token: 0x060135D0 RID: 79312 RVA: 0x001C7935 File Offset: 0x001C5B35
		public TMap<FHoudiniOutputObjectIdentifier, FHoudiniOutputObject> OutputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHoudiniOutputObjectIdentifier, FHoudiniOutputObject> result;
				if ((result = this._OutputObjects) == null)
				{
					result = (this._OutputObjects = new TMap<FHoudiniOutputObjectIdentifier, FHoudiniOutputObject>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_OutputObjects, this));
				}
				return result;
			}
			set
			{
				this.OutputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x060135D1 RID: 79313 RVA: 0x001C7944 File Offset: 0x001C5B44
		// (set) Token: 0x060135D2 RID: 79314 RVA: 0x001C797D File Offset: 0x001C5B7D
		public TMap<FHoudiniOutputObjectIdentifier, FHoudiniInstancedOutput> InstancedOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHoudiniOutputObjectIdentifier, FHoudiniInstancedOutput> result;
				if ((result = this._InstancedOutputs) == null)
				{
					result = (this._InstancedOutputs = new TMap<FHoudiniOutputObjectIdentifier, FHoudiniInstancedOutput>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_InstancedOutputs, this));
				}
				return result;
			}
			set
			{
				this.InstancedOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x060135D3 RID: 79315 RVA: 0x001C798C File Offset: 0x001C5B8C
		// (set) Token: 0x060135D4 RID: 79316 RVA: 0x001C79C5 File Offset: 0x001C5BC5
		public TMap<string, UMaterialInterface> AssignementMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterialInterface> result;
				if ((result = this._AssignementMaterials) == null)
				{
					result = (this._AssignementMaterials = new TMap<string, UMaterialInterface>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_AssignementMaterials, this));
				}
				return result;
			}
			set
			{
				this.AssignementMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x060135D5 RID: 79317 RVA: 0x001C79D4 File Offset: 0x001C5BD4
		// (set) Token: 0x060135D6 RID: 79318 RVA: 0x001C7A0D File Offset: 0x001C5C0D
		public TMap<string, UMaterialInterface> ReplacementMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterialInterface> result;
				if ((result = this._ReplacementMaterials) == null)
				{
					result = (this._ReplacementMaterials = new TMap<string, UMaterialInterface>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_ReplacementMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReplacementMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x060135D7 RID: 79319 RVA: 0x001C7A1B File Offset: 0x001C5C1B
		// (set) Token: 0x060135D8 RID: 79320 RVA: 0x001C7A2B File Offset: 0x001C5C2B
		public unsafe bool bLandscapeWorldComposition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bLandscapeWorldComposition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bLandscapeWorldComposition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x060135D9 RID: 79321 RVA: 0x001C7A3C File Offset: 0x001C5C3C
		// (set) Token: 0x060135DA RID: 79322 RVA: 0x001C7A75 File Offset: 0x001C5C75
		public TArray<AActor> HoudiniCreatedSocketActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HoudiniCreatedSocketActors) == null)
				{
					result = (this._HoudiniCreatedSocketActors = new TArray<AActor>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_HoudiniCreatedSocketActors, this));
				}
				return result;
			}
			set
			{
				this.HoudiniCreatedSocketActors.CopyAssign(value);
			}
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x060135DB RID: 79323 RVA: 0x001C7A84 File Offset: 0x001C5C84
		// (set) Token: 0x060135DC RID: 79324 RVA: 0x001C7ABD File Offset: 0x001C5CBD
		public TArray<AActor> HoudiniAttachedSocketActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HoudiniAttachedSocketActors) == null)
				{
					result = (this._HoudiniAttachedSocketActors = new TArray<AActor>(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_HoudiniAttachedSocketActors, this));
				}
				return result;
			}
			set
			{
				this.HoudiniAttachedSocketActors.CopyAssign(value);
			}
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x060135DD RID: 79325 RVA: 0x001C7ACB File Offset: 0x001C5CCB
		// (set) Token: 0x060135DE RID: 79326 RVA: 0x001C7ADB File Offset: 0x001C5CDB
		public unsafe bool bIsEditableNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bIsEditableNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bIsEditableNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x060135DF RID: 79327 RVA: 0x001C7AEC File Offset: 0x001C5CEC
		// (set) Token: 0x060135E0 RID: 79328 RVA: 0x001C7AFC File Offset: 0x001C5CFC
		public unsafe bool bHasEditableNodeBuilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bHasEditableNodeBuilt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bHasEditableNodeBuilt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x060135E1 RID: 79329 RVA: 0x001C7B0D File Offset: 0x001C5D0D
		// (set) Token: 0x060135E2 RID: 79330 RVA: 0x001C7B1D File Offset: 0x001C5D1D
		public unsafe bool bIsUpdating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bIsUpdating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bIsUpdating) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x060135E3 RID: 79331 RVA: 0x001C7B2E File Offset: 0x001C5D2E
		// (set) Token: 0x060135E4 RID: 79332 RVA: 0x001C7B3E File Offset: 0x001C5D3E
		public unsafe bool bCanDeleteHoudiniNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bCanDeleteHoudiniNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniOutput.__PropertyOffset_bCanDeleteHoudiniNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x060135E5 RID: 79333 RVA: 0x001C7B4F File Offset: 0x001C5D4F
		static UHoudiniOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniOutput");
		}

		// Token: 0x060135E6 RID: 79334 RVA: 0x001C7B5D File Offset: 0x001C5D5D
		protected UHoudiniOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A75A RID: 42842
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniOutput";

		// Token: 0x0400A75B RID: 42843
		private static IntPtr _ClassPtr;

		// Token: 0x0400A75C RID: 42844
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A75D RID: 42845
		internal static int __PropertyOffset_Type;

		// Token: 0x0400A75E RID: 42846
		internal static int __PropertyOffset_HoudiniGeoPartObjects;

		// Token: 0x0400A75F RID: 42847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHoudiniGeoPartObject> _HoudiniGeoPartObjects;

		// Token: 0x0400A760 RID: 42848
		internal static int __PropertyOffset_OutputObjects;

		// Token: 0x0400A761 RID: 42849
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FHoudiniOutputObjectIdentifier, FHoudiniOutputObject> _OutputObjects;

		// Token: 0x0400A762 RID: 42850
		internal static int __PropertyOffset_InstancedOutputs;

		// Token: 0x0400A763 RID: 42851
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FHoudiniOutputObjectIdentifier, FHoudiniInstancedOutput> _InstancedOutputs;

		// Token: 0x0400A764 RID: 42852
		internal static int __PropertyOffset_AssignementMaterials;

		// Token: 0x0400A765 RID: 42853
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterialInterface> _AssignementMaterials;

		// Token: 0x0400A766 RID: 42854
		internal static int __PropertyOffset_ReplacementMaterials;

		// Token: 0x0400A767 RID: 42855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterialInterface> _ReplacementMaterials;

		// Token: 0x0400A768 RID: 42856
		internal static int __PropertyOffset_bLandscapeWorldComposition;

		// Token: 0x0400A769 RID: 42857
		internal static int __PropertyOffset_HoudiniCreatedSocketActors;

		// Token: 0x0400A76A RID: 42858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HoudiniCreatedSocketActors;

		// Token: 0x0400A76B RID: 42859
		internal static int __PropertyOffset_HoudiniAttachedSocketActors;

		// Token: 0x0400A76C RID: 42860
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HoudiniAttachedSocketActors;

		// Token: 0x0400A76D RID: 42861
		internal static int __PropertyOffset_bIsEditableNode;

		// Token: 0x0400A76E RID: 42862
		internal static int __PropertyOffset_bHasEditableNodeBuilt;

		// Token: 0x0400A76F RID: 42863
		internal static int __PropertyOffset_bIsUpdating;

		// Token: 0x0400A770 RID: 42864
		internal static int __PropertyOffset_bCanDeleteHoudiniNodes;
	}
}
