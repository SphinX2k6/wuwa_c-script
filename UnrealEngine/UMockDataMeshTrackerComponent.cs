using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200246A RID: 9322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MRMesh.MockDataMeshTrackerComponent")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public class UMockDataMeshTrackerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E71 RID: 142961 RVA: 0x0033996D File Offset: 0x00337B6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMockDataMeshTrackerComponent._ClassPtr;
		}

		// Token: 0x06022E72 RID: 142962 RVA: 0x0033997C File Offset: 0x00337B7C
		public UMockDataMeshTrackerComponent() : this(BuiltinUtils.AllocNativeUObject(UMockDataMeshTrackerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E73 RID: 142963 RVA: 0x003399A4 File Offset: 0x00337BA4
		public UMockDataMeshTrackerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMockDataMeshTrackerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008616 RID: 34326
		// (get) Token: 0x06022E74 RID: 142964 RVA: 0x003399D8 File Offset: 0x00337BD8
		// (set) Token: 0x06022E75 RID: 142965 RVA: 0x00339A11 File Offset: 0x00337C11
		public FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FOnMockDataMeshTrackerUpdated result;
				if ((result = this._OnMeshTrackerUpdated) == null)
				{
					result = (this._OnMeshTrackerUpdated = new FOnMockDataMeshTrackerUpdated(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_OnMeshTrackerUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_OnMeshTrackerUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008617 RID: 34327
		// (get) Token: 0x06022E76 RID: 142966 RVA: 0x00339A32 File Offset: 0x00337C32
		// (set) Token: 0x06022E77 RID: 142967 RVA: 0x00339A42 File Offset: 0x00337C42
		public unsafe bool ScanWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_ScanWorld) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_ScanWorld) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008618 RID: 34328
		// (get) Token: 0x06022E78 RID: 142968 RVA: 0x00339A53 File Offset: 0x00337C53
		// (set) Token: 0x06022E79 RID: 142969 RVA: 0x00339A63 File Offset: 0x00337C63
		public unsafe bool RequestNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_RequestNormals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_RequestNormals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008619 RID: 34329
		// (get) Token: 0x06022E7A RID: 142970 RVA: 0x00339A74 File Offset: 0x00337C74
		// (set) Token: 0x06022E7B RID: 142971 RVA: 0x00339A84 File Offset: 0x00337C84
		public unsafe bool RequestVertexConfidence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_RequestVertexConfidence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_RequestVertexConfidence) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700861A RID: 34330
		// (get) Token: 0x06022E7C RID: 142972 RVA: 0x00339A95 File Offset: 0x00337C95
		// (set) Token: 0x06022E7D RID: 142973 RVA: 0x00339AA5 File Offset: 0x00337CA5
		public unsafe EMeshTrackerVertexColorMode VertexColorMode
		{
			get
			{
				return (EMeshTrackerVertexColorMode)(*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorMode) = (byte)value;
			}
		}

		// Token: 0x1700861B RID: 34331
		// (get) Token: 0x06022E7E RID: 142974 RVA: 0x00339AB8 File Offset: 0x00337CB8
		// (set) Token: 0x06022E7F RID: 142975 RVA: 0x00339AF1 File Offset: 0x00337CF1
		public TArray<FColor> BlockVertexColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._BlockVertexColors) == null)
				{
					result = (this._BlockVertexColors = new TArray<FColor>(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_BlockVertexColors, this));
				}
				return result;
			}
			set
			{
				this.BlockVertexColors.CopyAssign(value);
			}
		}

		// Token: 0x1700861C RID: 34332
		// (get) Token: 0x06022E80 RID: 142976 RVA: 0x00339AFF File Offset: 0x00337CFF
		// (set) Token: 0x06022E81 RID: 142977 RVA: 0x00339B13 File Offset: 0x00337D13
		public unsafe FLinearColor VertexColorFromConfidenceZero
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorFromConfidenceZero);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorFromConfidenceZero) = value;
			}
		}

		// Token: 0x1700861D RID: 34333
		// (get) Token: 0x06022E82 RID: 142978 RVA: 0x00339B28 File Offset: 0x00337D28
		// (set) Token: 0x06022E83 RID: 142979 RVA: 0x00339B3C File Offset: 0x00337D3C
		public unsafe FLinearColor VertexColorFromConfidenceOne
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorFromConfidenceOne);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_VertexColorFromConfidenceOne) = value;
			}
		}

		// Token: 0x1700861E RID: 34334
		// (get) Token: 0x06022E84 RID: 142980 RVA: 0x00339B51 File Offset: 0x00337D51
		// (set) Token: 0x06022E85 RID: 142981 RVA: 0x00339B61 File Offset: 0x00337D61
		public unsafe float UpdateInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_UpdateInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMockDataMeshTrackerComponent.__PropertyOffset_UpdateInterval) = value;
			}
		}

		// Token: 0x1700861F RID: 34335
		// (get) Token: 0x06022E86 RID: 142982 RVA: 0x00339B72 File Offset: 0x00337D72
		// (set) Token: 0x06022E87 RID: 142983 RVA: 0x00339B86 File Offset: 0x00337D86
		[Nullable(2)]
		public unsafe UMRMeshComponent MRMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMRMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UMockDataMeshTrackerComponent.__PropertyOffset_MRMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMockDataMeshTrackerComponent.__PropertyOffset_MRMesh, value);
			}
		}

		// Token: 0x06022E88 RID: 142984 RVA: 0x00339B9B File Offset: 0x00337D9B
		[NullableContext(2)]
		public void DisconnectMRMesh(UMRMeshComponent InMRMeshPtr)
		{
			UMockDataMeshTrackerComponent.__DisconnectMRMesh_Internal(base.NativePtr, (InMRMeshPtr != null) ? InMRMeshPtr.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06022E89 RID: 142985 RVA: 0x00339BB8 File Offset: 0x00337DB8
		[NullableContext(2)]
		public void ConnectMRMesh(UMRMeshComponent InMRMeshPtr)
		{
			UMockDataMeshTrackerComponent.__ConnectMRMesh_Internal(base.NativePtr, (InMRMeshPtr != null) ? InMRMeshPtr.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06022E8A RID: 142986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisconnectMRMesh_Internal(IntPtr @this, IntPtr InMRMeshPtr);

		// Token: 0x06022E8B RID: 142987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConnectMRMesh_Internal(IntPtr @this, IntPtr InMRMeshPtr);

		// Token: 0x06022E8C RID: 142988 RVA: 0x00339BD5 File Offset: 0x00337DD5
		static UMockDataMeshTrackerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MRMesh.MockDataMeshTrackerComponent");
		}

		// Token: 0x06022E8D RID: 142989 RVA: 0x00339BE3 File Offset: 0x00337DE3
		protected UMockDataMeshTrackerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A1A RID: 76314
		public new const string __ObjectPath = "/Script/MRMesh.MockDataMeshTrackerComponent";

		// Token: 0x04012A1B RID: 76315
		private static IntPtr _ClassPtr;

		// Token: 0x04012A1C RID: 76316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A1D RID: 76317
		public static IntPtr __OnMockDataMeshTrackerUpdated__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012A1E RID: 76318
		internal static int __PropertyOffset_OnMeshTrackerUpdated;

		// Token: 0x04012A1F RID: 76319
		[Nullable(2)]
		private FOnMockDataMeshTrackerUpdated _OnMeshTrackerUpdated;

		// Token: 0x04012A20 RID: 76320
		internal static int __PropertyOffset_ScanWorld;

		// Token: 0x04012A21 RID: 76321
		internal static int __PropertyOffset_RequestNormals;

		// Token: 0x04012A22 RID: 76322
		internal static int __PropertyOffset_RequestVertexConfidence;

		// Token: 0x04012A23 RID: 76323
		internal static int __PropertyOffset_VertexColorMode;

		// Token: 0x04012A24 RID: 76324
		internal static int __PropertyOffset_BlockVertexColors;

		// Token: 0x04012A25 RID: 76325
		[Nullable(2)]
		private TArray<FColor> _BlockVertexColors;

		// Token: 0x04012A26 RID: 76326
		internal static int __PropertyOffset_VertexColorFromConfidenceZero;

		// Token: 0x04012A27 RID: 76327
		internal static int __PropertyOffset_VertexColorFromConfidenceOne;

		// Token: 0x04012A28 RID: 76328
		internal static int __PropertyOffset_UpdateInterval;

		// Token: 0x04012A29 RID: 76329
		internal static int __PropertyOffset_MRMesh;
	}
}
