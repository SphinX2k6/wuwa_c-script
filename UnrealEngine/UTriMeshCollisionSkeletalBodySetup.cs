using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001208 RID: 4616
	[UnrealObjectPath("/Script/Engine.TriMeshCollisionSkeletalBodySetup")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UTriMeshCollisionSkeletalBodySetup : USkeletalBodySetup, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06011016 RID: 69654 RVA: 0x0018F4BA File Offset: 0x0018D6BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTriMeshCollisionSkeletalBodySetup._ClassPtr;
		}

		// Token: 0x06011017 RID: 69655 RVA: 0x0018F4C6 File Offset: 0x0018D6C6
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UTriMeshCollisionSkeletalBodySetup.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x06011018 RID: 69656 RVA: 0x0018F4D0 File Offset: 0x0018D6D0
		public UTriMeshCollisionSkeletalBodySetup() : this(BuiltinUtils.AllocNativeUObject(UTriMeshCollisionSkeletalBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011019 RID: 69657 RVA: 0x0018F4F8 File Offset: 0x0018D6F8
		[NullableContext(1)]
		public UTriMeshCollisionSkeletalBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTriMeshCollisionSkeletalBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0601101A RID: 69658 RVA: 0x0018F52C File Offset: 0x0018D72C
		// (set) Token: 0x0601101B RID: 69659 RVA: 0x0018F565 File Offset: 0x0018D765
		[Nullable(1)]
		public FSerializedTriMeshCollisionData SerializedTriMeshCollisionData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSerializedTriMeshCollisionData result;
				if ((result = this._SerializedTriMeshCollisionData) == null)
				{
					result = (this._SerializedTriMeshCollisionData = new FSerializedTriMeshCollisionData(base.NativePtr + (IntPtr)UTriMeshCollisionSkeletalBodySetup.__PropertyOffset_SerializedTriMeshCollisionData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSerializedTriMeshCollisionData.StaticStruct(), base.NativePtr + (IntPtr)UTriMeshCollisionSkeletalBodySetup.__PropertyOffset_SerializedTriMeshCollisionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0601101C RID: 69660 RVA: 0x0018F586 File Offset: 0x0018D786
		// (set) Token: 0x0601101D RID: 69661 RVA: 0x0018F596 File Offset: 0x0018D796
		public unsafe bool bUseSerializedTriMeshCollisionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTriMeshCollisionSkeletalBodySetup.__PropertyOffset_bUseSerializedTriMeshCollisionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTriMeshCollisionSkeletalBodySetup.__PropertyOffset_bUseSerializedTriMeshCollisionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601101E RID: 69662 RVA: 0x0018F5A7 File Offset: 0x0018D7A7
		static UTriMeshCollisionSkeletalBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriMeshCollisionSkeletalBodySetup");
		}

		// Token: 0x0601101F RID: 69663 RVA: 0x0018F5B5 File Offset: 0x0018D7B5
		protected UTriMeshCollisionSkeletalBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091B3 RID: 37299
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x040091B4 RID: 37300
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriMeshCollisionSkeletalBodySetup";

		// Token: 0x040091B5 RID: 37301
		private static IntPtr _ClassPtr;

		// Token: 0x040091B6 RID: 37302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040091B7 RID: 37303
		internal static int __PropertyOffset_SerializedTriMeshCollisionData;

		// Token: 0x040091B8 RID: 37304
		[Nullable(2)]
		private FSerializedTriMeshCollisionData _SerializedTriMeshCollisionData;

		// Token: 0x040091B9 RID: 37305
		internal static int __PropertyOffset_bUseSerializedTriMeshCollisionData;
	}
}
