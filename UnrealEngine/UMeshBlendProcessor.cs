using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022C5 RID: 8901
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendProcessor")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMeshBlendProcessor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CDF RID: 138463 RVA: 0x0031F80B File Offset: 0x0031DA0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshBlendProcessor._ClassPtr;
		}

		// Token: 0x06021CE0 RID: 138464 RVA: 0x0031F818 File Offset: 0x0031DA18
		public UMeshBlendProcessor() : this(BuiltinUtils.AllocNativeUObject(UMeshBlendProcessor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CE1 RID: 138465 RVA: 0x0031F840 File Offset: 0x0031DA40
		public UMeshBlendProcessor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshBlendProcessor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008313 RID: 33555
		// (get) Token: 0x06021CE2 RID: 138466 RVA: 0x0031F874 File Offset: 0x0031DA74
		// (set) Token: 0x06021CE3 RID: 138467 RVA: 0x0031F8AD File Offset: 0x0031DAAD
		public TMap<byte, FBlendValueBucket> BlendValueBucket
		{
			get
			{
				base.FastCheckIsValid();
				TMap<byte, FBlendValueBucket> result;
				if ((result = this._BlendValueBucket) == null)
				{
					result = (this._BlendValueBucket = new TMap<byte, FBlendValueBucket>(base.NativePtr + (IntPtr)UMeshBlendProcessor.__PropertyOffset_BlendValueBucket, this));
				}
				return result;
			}
			set
			{
				this.BlendValueBucket.CopyAssign(value);
			}
		}

		// Token: 0x17008314 RID: 33556
		// (get) Token: 0x06021CE4 RID: 138468 RVA: 0x0031F8BC File Offset: 0x0031DABC
		// (set) Token: 0x06021CE5 RID: 138469 RVA: 0x0031F8F5 File Offset: 0x0031DAF5
		public FMeshBlendPrimitiveDataIndexHelper PrimitiveDataIndexHelper
		{
			get
			{
				base.FastCheckIsValid();
				FMeshBlendPrimitiveDataIndexHelper result;
				if ((result = this._PrimitiveDataIndexHelper) == null)
				{
					result = (this._PrimitiveDataIndexHelper = new FMeshBlendPrimitiveDataIndexHelper(base.NativePtr + (IntPtr)UMeshBlendProcessor.__PropertyOffset_PrimitiveDataIndexHelper, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshBlendPrimitiveDataIndexHelper.StaticStruct(), base.NativePtr + (IntPtr)UMeshBlendProcessor.__PropertyOffset_PrimitiveDataIndexHelper, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021CE6 RID: 138470 RVA: 0x0031F916 File Offset: 0x0031DB16
		static UMeshBlendProcessor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendProcessor");
		}

		// Token: 0x06021CE7 RID: 138471 RVA: 0x0031F924 File Offset: 0x0031DB24
		protected UMeshBlendProcessor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401208E RID: 73870
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendProcessor";

		// Token: 0x0401208F RID: 73871
		private static IntPtr _ClassPtr;

		// Token: 0x04012090 RID: 73872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012091 RID: 73873
		internal static int __PropertyOffset_BlendValueBucket;

		// Token: 0x04012092 RID: 73874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<byte, FBlendValueBucket> _BlendValueBucket;

		// Token: 0x04012093 RID: 73875
		internal static int __PropertyOffset_PrimitiveDataIndexHelper;

		// Token: 0x04012094 RID: 73876
		[Nullable(2)]
		private FMeshBlendPrimitiveDataIndexHelper _PrimitiveDataIndexHelper;
	}
}
