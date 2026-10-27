using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022BA RID: 8890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActivatorLogic")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UMeshBlendActivatorLogic : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C56 RID: 138326 RVA: 0x0031ED9A File Offset: 0x0031CF9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshBlendActivatorLogic._ClassPtr;
		}

		// Token: 0x06021C57 RID: 138327 RVA: 0x0031EDA8 File Offset: 0x0031CFA8
		public UMeshBlendActivatorLogic() : this(BuiltinUtils.AllocNativeUObject(UMeshBlendActivatorLogic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C58 RID: 138328 RVA: 0x0031EDD0 File Offset: 0x0031CFD0
		public UMeshBlendActivatorLogic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshBlendActivatorLogic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082FC RID: 33532
		// (get) Token: 0x06021C59 RID: 138329 RVA: 0x0031EE03 File Offset: 0x0031D003
		// (set) Token: 0x06021C5A RID: 138330 RVA: 0x0031EE13 File Offset: 0x0031D013
		public unsafe float ProcessBudget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_ProcessBudget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_ProcessBudget) = value;
			}
		}

		// Token: 0x170082FD RID: 33533
		// (get) Token: 0x06021C5B RID: 138331 RVA: 0x0031EE24 File Offset: 0x0031D024
		// (set) Token: 0x06021C5C RID: 138332 RVA: 0x0031EE34 File Offset: 0x0031D034
		public unsafe bool IsBlendingEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_IsBlendingEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_IsBlendingEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082FE RID: 33534
		// (get) Token: 0x06021C5D RID: 138333 RVA: 0x0031EE45 File Offset: 0x0031D045
		// (set) Token: 0x06021C5E RID: 138334 RVA: 0x0031EE59 File Offset: 0x0031D059
		[Nullable(2)]
		public unsafe UMeshBlendProcessor MeshBlendProcessor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMeshBlendProcessor>(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendActivatorLogic.__PropertyOffset_MeshBlendProcessor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendActivatorLogic.__PropertyOffset_MeshBlendProcessor, value);
			}
		}

		// Token: 0x170082FF RID: 33535
		// (get) Token: 0x06021C5F RID: 138335 RVA: 0x0031EE6E File Offset: 0x0031D06E
		// (set) Token: 0x06021C60 RID: 138336 RVA: 0x0031EE7E File Offset: 0x0031D07E
		public unsafe float CurrentMaxRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_CurrentMaxRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_CurrentMaxRadius) = value;
			}
		}

		// Token: 0x17008300 RID: 33536
		// (get) Token: 0x06021C61 RID: 138337 RVA: 0x0031EE8F File Offset: 0x0031D08F
		// (set) Token: 0x06021C62 RID: 138338 RVA: 0x0031EE9F File Offset: 0x0031D09F
		public unsafe EMeshBlendProcessStage CurrentProcessStage
		{
			get
			{
				return (EMeshBlendProcessStage)(*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_CurrentProcessStage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_CurrentProcessStage) = (byte)value;
			}
		}

		// Token: 0x17008301 RID: 33537
		// (get) Token: 0x06021C63 RID: 138339 RVA: 0x0031EEB0 File Offset: 0x0031D0B0
		// (set) Token: 0x06021C64 RID: 138340 RVA: 0x0031EEE9 File Offset: 0x0031D0E9
		public FMeshBlendPooledActors PooledActors
		{
			get
			{
				base.FastCheckIsValid();
				FMeshBlendPooledActors result;
				if ((result = this._PooledActors) == null)
				{
					result = (this._PooledActors = new FMeshBlendPooledActors(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_PooledActors, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshBlendPooledActors.StaticStruct(), base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_PooledActors, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008302 RID: 33538
		// (get) Token: 0x06021C65 RID: 138341 RVA: 0x0031EF0C File Offset: 0x0031D10C
		// (set) Token: 0x06021C66 RID: 138342 RVA: 0x0031EF45 File Offset: 0x0031D145
		public FMeshBlendPCGHelper MeshBlendPCGHelper
		{
			get
			{
				base.FastCheckIsValid();
				FMeshBlendPCGHelper result;
				if ((result = this._MeshBlendPCGHelper) == null)
				{
					result = (this._MeshBlendPCGHelper = new FMeshBlendPCGHelper(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_MeshBlendPCGHelper, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshBlendPCGHelper.StaticStruct(), base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_MeshBlendPCGHelper, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008303 RID: 33539
		// (get) Token: 0x06021C67 RID: 138343 RVA: 0x0031EF68 File Offset: 0x0031D168
		// (set) Token: 0x06021C68 RID: 138344 RVA: 0x0031EFA1 File Offset: 0x0031D1A1
		public TSet<string> MaterialsMissingAutoBlendID
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._MaterialsMissingAutoBlendID) == null)
				{
					result = (this._MaterialsMissingAutoBlendID = new TSet<string>(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_MaterialsMissingAutoBlendID, this));
				}
				return result;
			}
			set
			{
				this.MaterialsMissingAutoBlendID.CopyAssign(value);
			}
		}

		// Token: 0x17008304 RID: 33540
		// (get) Token: 0x06021C69 RID: 138345 RVA: 0x0031EFAF File Offset: 0x0031D1AF
		// (set) Token: 0x06021C6A RID: 138346 RVA: 0x0031EFBF File Offset: 0x0031D1BF
		public unsafe bool IsInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_IsInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_IsInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008305 RID: 33541
		// (get) Token: 0x06021C6B RID: 138347 RVA: 0x0031EFD0 File Offset: 0x0031D1D0
		// (set) Token: 0x06021C6C RID: 138348 RVA: 0x0031EFE0 File Offset: 0x0031D1E0
		public unsafe bool bDisableRestrictions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_bDisableRestrictions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorLogic.__PropertyOffset_bDisableRestrictions) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021C6D RID: 138349 RVA: 0x0031EFF1 File Offset: 0x0031D1F1
		static UMeshBlendActivatorLogic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendActivatorLogic");
		}

		// Token: 0x06021C6E RID: 138350 RVA: 0x0031EFFF File Offset: 0x0031D1FF
		protected UMeshBlendActivatorLogic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012057 RID: 73815
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendActivatorLogic";

		// Token: 0x04012058 RID: 73816
		private static IntPtr _ClassPtr;

		// Token: 0x04012059 RID: 73817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401205A RID: 73818
		internal static int __PropertyOffset_ProcessBudget;

		// Token: 0x0401205B RID: 73819
		internal static int __PropertyOffset_IsBlendingEnabled;

		// Token: 0x0401205C RID: 73820
		internal static int __PropertyOffset_MeshBlendProcessor;

		// Token: 0x0401205D RID: 73821
		internal static int __PropertyOffset_CurrentMaxRadius;

		// Token: 0x0401205E RID: 73822
		internal static int __PropertyOffset_CurrentProcessStage;

		// Token: 0x0401205F RID: 73823
		internal static int __PropertyOffset_PooledActors;

		// Token: 0x04012060 RID: 73824
		[Nullable(2)]
		private FMeshBlendPooledActors _PooledActors;

		// Token: 0x04012061 RID: 73825
		internal static int __PropertyOffset_MeshBlendPCGHelper;

		// Token: 0x04012062 RID: 73826
		[Nullable(2)]
		private FMeshBlendPCGHelper _MeshBlendPCGHelper;

		// Token: 0x04012063 RID: 73827
		internal static int __PropertyOffset_MaterialsMissingAutoBlendID;

		// Token: 0x04012064 RID: 73828
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _MaterialsMissingAutoBlendID;

		// Token: 0x04012065 RID: 73829
		internal static int __PropertyOffset_IsInitialized;

		// Token: 0x04012066 RID: 73830
		internal static int __PropertyOffset_bDisableRestrictions;
	}
}
