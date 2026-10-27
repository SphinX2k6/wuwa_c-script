using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DC RID: 6108
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroJacobiClothSetDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroJacobiClothSetDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601689B RID: 92315 RVA: 0x0020E7E2 File Offset: 0x0020C9E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroJacobiClothSetDataAsset._ClassPtr;
		}

		// Token: 0x0601689C RID: 92316 RVA: 0x0020E7F0 File Offset: 0x0020C9F0
		public UKuroJacobiClothSetDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroJacobiClothSetDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601689D RID: 92317 RVA: 0x0020E818 File Offset: 0x0020CA18
		public UKuroJacobiClothSetDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroJacobiClothSetDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x0601689E RID: 92318 RVA: 0x0020E84C File Offset: 0x0020CA4C
		// (set) Token: 0x0601689F RID: 92319 RVA: 0x0020E885 File Offset: 0x0020CA85
		public TArray<FKuroJacobiClothSetMapping> ModelMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroJacobiClothSetMapping> result;
				if ((result = this._ModelMappings) == null)
				{
					result = (this._ModelMappings = new TArray<FKuroJacobiClothSetMapping>(base.NativePtr + (IntPtr)UKuroJacobiClothSetDataAsset.__PropertyOffset_ModelMappings, this));
				}
				return result;
			}
			set
			{
				this.ModelMappings.CopyAssign(value);
			}
		}

		// Token: 0x060168A0 RID: 92320 RVA: 0x0020E893 File Offset: 0x0020CA93
		[NullableContext(2)]
		public UKuroClothDataAsset FindProfileForMesh(UStaticMesh Mesh)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroClothDataAsset>(UKuroJacobiClothSetDataAsset.__FindProfileForMesh_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060168A1 RID: 92321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindProfileForMesh_Internal(IntPtr @this, IntPtr Mesh);

		// Token: 0x060168A2 RID: 92322 RVA: 0x0020E8B5 File Offset: 0x0020CAB5
		static UKuroJacobiClothSetDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroJacobiClothSetDataAsset");
		}

		// Token: 0x060168A3 RID: 92323 RVA: 0x0020E8C3 File Offset: 0x0020CAC3
		protected UKuroJacobiClothSetDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C3DF RID: 50143
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroJacobiClothSetDataAsset";

		// Token: 0x0400C3E0 RID: 50144
		private static IntPtr _ClassPtr;

		// Token: 0x0400C3E1 RID: 50145
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C3E2 RID: 50146
		internal static int __PropertyOffset_ModelMappings;

		// Token: 0x0400C3E3 RID: 50147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroJacobiClothSetMapping> _ModelMappings;
	}
}
