using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029DC RID: 10716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.SlateVectorArtData")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class USlateVectorArtData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A74 RID: 162420 RVA: 0x003C783C File Offset: 0x003C5A3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateVectorArtData._ClassPtr;
		}

		// Token: 0x06027A75 RID: 162421 RVA: 0x003C7848 File Offset: 0x003C5A48
		public USlateVectorArtData() : this(BuiltinUtils.AllocNativeUObject(USlateVectorArtData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A76 RID: 162422 RVA: 0x003C7870 File Offset: 0x003C5A70
		public USlateVectorArtData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateVectorArtData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097E7 RID: 38887
		// (get) Token: 0x06027A77 RID: 162423 RVA: 0x003C78A4 File Offset: 0x003C5AA4
		// (set) Token: 0x06027A78 RID: 162424 RVA: 0x003C78DD File Offset: 0x003C5ADD
		public TArray<FSlateMeshVertex> VertexData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSlateMeshVertex> result;
				if ((result = this._VertexData) == null)
				{
					result = (this._VertexData = new TArray<FSlateMeshVertex>(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_VertexData, this));
				}
				return result;
			}
			set
			{
				this.VertexData.CopyAssign(value);
			}
		}

		// Token: 0x170097E8 RID: 38888
		// (get) Token: 0x06027A79 RID: 162425 RVA: 0x003C78EC File Offset: 0x003C5AEC
		// (set) Token: 0x06027A7A RID: 162426 RVA: 0x003C7925 File Offset: 0x003C5B25
		public TArray<uint> IndexData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._IndexData) == null)
				{
					result = (this._IndexData = new TArray<uint>(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_IndexData, this));
				}
				return result;
			}
			set
			{
				this.IndexData.CopyAssign(value);
			}
		}

		// Token: 0x170097E9 RID: 38889
		// (get) Token: 0x06027A7B RID: 162427 RVA: 0x003C7933 File Offset: 0x003C5B33
		// (set) Token: 0x06027A7C RID: 162428 RVA: 0x003C7947 File Offset: 0x003C5B47
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USlateVectorArtData.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USlateVectorArtData.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x170097EA RID: 38890
		// (get) Token: 0x06027A7D RID: 162429 RVA: 0x003C795C File Offset: 0x003C5B5C
		// (set) Token: 0x06027A7E RID: 162430 RVA: 0x003C7970 File Offset: 0x003C5B70
		public unsafe FVector2D ExtentMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_ExtentMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_ExtentMin) = value;
			}
		}

		// Token: 0x170097EB RID: 38891
		// (get) Token: 0x06027A7F RID: 162431 RVA: 0x003C7985 File Offset: 0x003C5B85
		// (set) Token: 0x06027A80 RID: 162432 RVA: 0x003C7999 File Offset: 0x003C5B99
		public unsafe FVector2D ExtentMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_ExtentMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateVectorArtData.__PropertyOffset_ExtentMax) = value;
			}
		}

		// Token: 0x06027A81 RID: 162433 RVA: 0x003C79AE File Offset: 0x003C5BAE
		static USlateVectorArtData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SlateVectorArtData");
		}

		// Token: 0x06027A82 RID: 162434 RVA: 0x003C79BC File Offset: 0x003C5BBC
		protected USlateVectorArtData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B81 RID: 88961
		public new const string __ObjectPath = "/Script/UMG.SlateVectorArtData";

		// Token: 0x04015B82 RID: 88962
		private static IntPtr _ClassPtr;

		// Token: 0x04015B83 RID: 88963
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B84 RID: 88964
		internal static int __PropertyOffset_VertexData;

		// Token: 0x04015B85 RID: 88965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSlateMeshVertex> _VertexData;

		// Token: 0x04015B86 RID: 88966
		internal static int __PropertyOffset_IndexData;

		// Token: 0x04015B87 RID: 88967
		[Nullable(2)]
		private TArray<uint> _IndexData;

		// Token: 0x04015B88 RID: 88968
		internal static int __PropertyOffset_Material;

		// Token: 0x04015B89 RID: 88969
		internal static int __PropertyOffset_ExtentMin;

		// Token: 0x04015B8A RID: 88970
		internal static int __PropertyOffset_ExtentMax;
	}
}
