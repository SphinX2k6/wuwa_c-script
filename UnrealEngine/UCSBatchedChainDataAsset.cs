using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001773 RID: 6003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.CSBatchedChainDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UCSBatchedChainDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060159EE RID: 88558 RVA: 0x001FCB00 File Offset: 0x001FAD00
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCSBatchedChainDataAsset._ClassPtr;
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x001FCB0C File Offset: 0x001FAD0C
		public UCSBatchedChainDataAsset() : this(BuiltinUtils.AllocNativeUObject(UCSBatchedChainDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x001FCB34 File Offset: 0x001FAD34
		public UCSBatchedChainDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCSBatchedChainDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x060159F1 RID: 88561 RVA: 0x001FCB68 File Offset: 0x001FAD68
		// (set) Token: 0x060159F2 RID: 88562 RVA: 0x001FCBA1 File Offset: 0x001FADA1
		public TArray<FCSBatchedChainModelMapping> ModelMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCSBatchedChainModelMapping> result;
				if ((result = this._ModelMappings) == null)
				{
					result = (this._ModelMappings = new TArray<FCSBatchedChainModelMapping>(base.NativePtr + (IntPtr)UCSBatchedChainDataAsset.__PropertyOffset_ModelMappings, this));
				}
				return result;
			}
			set
			{
				this.ModelMappings.CopyAssign(value);
			}
		}

		// Token: 0x060159F3 RID: 88563 RVA: 0x001FCBAF File Offset: 0x001FADAF
		[NullableContext(2)]
		public UJacobiChainAsset FindProfileForMesh(UStaticMesh Mesh)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UJacobiChainAsset>(UCSBatchedChainDataAsset.__FindProfileForMesh_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060159F4 RID: 88564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindProfileForMesh_Internal(IntPtr @this, IntPtr Mesh);

		// Token: 0x060159F5 RID: 88565 RVA: 0x001FCBD1 File Offset: 0x001FADD1
		static UCSBatchedChainDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.CSBatchedChainDataAsset");
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x001FCBDF File Offset: 0x001FADDF
		protected UCSBatchedChainDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BCAE RID: 48302
		public new const string __ObjectPath = "/Script/KuroComputeShader.CSBatchedChainDataAsset";

		// Token: 0x0400BCAF RID: 48303
		private static IntPtr _ClassPtr;

		// Token: 0x0400BCB0 RID: 48304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BCB1 RID: 48305
		internal static int __PropertyOffset_ModelMappings;

		// Token: 0x0400BCB2 RID: 48306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCSBatchedChainModelMapping> _ModelMappings;
	}
}
