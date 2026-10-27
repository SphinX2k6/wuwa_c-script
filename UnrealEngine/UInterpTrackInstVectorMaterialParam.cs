using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAB RID: 3243
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackInstVectorMaterialParam")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UInterpTrackInstVectorMaterialParam : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A40D RID: 41997 RVA: 0x000E935D File Offset: 0x000E755D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstVectorMaterialParam._ClassPtr;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x000E936C File Offset: 0x000E756C
		public UInterpTrackInstVectorMaterialParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVectorMaterialParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x000E9394 File Offset: 0x000E7594
		public UInterpTrackInstVectorMaterialParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVectorMaterialParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600A410 RID: 42000 RVA: 0x000E93C8 File Offset: 0x000E75C8
		// (set) Token: 0x0600A411 RID: 42001 RVA: 0x000E9401 File Offset: 0x000E7601
		public TArray<UMaterialInstanceDynamic> MaterialInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstances) == null)
				{
					result = (this._MaterialInstances = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UInterpTrackInstVectorMaterialParam.__PropertyOffset_MaterialInstances, this));
				}
				return result;
			}
			set
			{
				this.MaterialInstances.CopyAssign(value);
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600A412 RID: 42002 RVA: 0x000E9410 File Offset: 0x000E7610
		// (set) Token: 0x0600A413 RID: 42003 RVA: 0x000E9449 File Offset: 0x000E7649
		public TArray<FVector> ResetVectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ResetVectors) == null)
				{
					result = (this._ResetVectors = new TArray<FVector>(base.NativePtr + (IntPtr)UInterpTrackInstVectorMaterialParam.__PropertyOffset_ResetVectors, this));
				}
				return result;
			}
			set
			{
				this.ResetVectors.CopyAssign(value);
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600A414 RID: 42004 RVA: 0x000E9458 File Offset: 0x000E7658
		// (set) Token: 0x0600A415 RID: 42005 RVA: 0x000E9491 File Offset: 0x000E7691
		public TArray<FPrimitiveMaterialRef> PrimitiveMaterialRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPrimitiveMaterialRef> result;
				if ((result = this._PrimitiveMaterialRefs) == null)
				{
					result = (this._PrimitiveMaterialRefs = new TArray<FPrimitiveMaterialRef>(base.NativePtr + (IntPtr)UInterpTrackInstVectorMaterialParam.__PropertyOffset_PrimitiveMaterialRefs, this));
				}
				return result;
			}
			set
			{
				this.PrimitiveMaterialRefs.CopyAssign(value);
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600A416 RID: 42006 RVA: 0x000E949F File Offset: 0x000E769F
		// (set) Token: 0x0600A417 RID: 42007 RVA: 0x000E94B3 File Offset: 0x000E76B3
		[Nullable(2)]
		public unsafe UInterpTrackVectorMaterialParam InstancedTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrackVectorMaterialParam>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstVectorMaterialParam.__PropertyOffset_InstancedTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstVectorMaterialParam.__PropertyOffset_InstancedTrack, value);
			}
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x000E94C8 File Offset: 0x000E76C8
		static UInterpTrackInstVectorMaterialParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstVectorMaterialParam");
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x000E94D6 File Offset: 0x000E76D6
		protected UInterpTrackInstVectorMaterialParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A2D RID: 23085
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstVectorMaterialParam";

		// Token: 0x04005A2E RID: 23086
		private static IntPtr _ClassPtr;

		// Token: 0x04005A2F RID: 23087
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A30 RID: 23088
		internal static int __PropertyOffset_MaterialInstances;

		// Token: 0x04005A31 RID: 23089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstances;

		// Token: 0x04005A32 RID: 23090
		internal static int __PropertyOffset_ResetVectors;

		// Token: 0x04005A33 RID: 23091
		[Nullable(2)]
		private TArray<FVector> _ResetVectors;

		// Token: 0x04005A34 RID: 23092
		internal static int __PropertyOffset_PrimitiveMaterialRefs;

		// Token: 0x04005A35 RID: 23093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPrimitiveMaterialRef> _PrimitiveMaterialRefs;

		// Token: 0x04005A36 RID: 23094
		internal static int __PropertyOffset_InstancedTrack;
	}
}
