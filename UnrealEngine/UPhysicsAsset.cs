using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FDF RID: 4063
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsAsset")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UPhysicsAsset : UObject, IUnrealUObject, IUnrealObject, IInterface_PreviewMeshProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600DB76 RID: 56182 RVA: 0x00143531 File Offset: 0x00141731
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsAsset._ClassPtr;
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x0014353D File Offset: 0x0014173D
		int IInterface_PreviewMeshProvider.InterfaceOffset()
		{
			return UPhysicsAsset.__InterfaceOffset_IInterface_PreviewMeshProvider;
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x00143544 File Offset: 0x00141744
		public UPhysicsAsset() : this(BuiltinUtils.AllocNativeUObject(UPhysicsAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x0014356C File Offset: 0x0014176C
		public UPhysicsAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x001435A0 File Offset: 0x001417A0
		// (set) Token: 0x0600DB7B RID: 56187 RVA: 0x001435D9 File Offset: 0x001417D9
		public TArray<int> BoundsBodies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BoundsBodies) == null)
				{
					result = (this._BoundsBodies = new TArray<int>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_BoundsBodies, this));
				}
				return result;
			}
			set
			{
				this.BoundsBodies.CopyAssign(value);
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x001435E8 File Offset: 0x001417E8
		// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x00143621 File Offset: 0x00141821
		public TArray<USkeletalBodySetup> SkeletalBodySetups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalBodySetup> result;
				if ((result = this._SkeletalBodySetups) == null)
				{
					result = (this._SkeletalBodySetups = new TArray<USkeletalBodySetup>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_SkeletalBodySetups, this));
				}
				return result;
			}
			set
			{
				this.SkeletalBodySetups.CopyAssign(value);
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x00143630 File Offset: 0x00141830
		// (set) Token: 0x0600DB7F RID: 56191 RVA: 0x00143669 File Offset: 0x00141869
		public TArray<UPhysicsConstraintTemplate> ConstraintSetup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicsConstraintTemplate> result;
				if ((result = this._ConstraintSetup) == null)
				{
					result = (this._ConstraintSetup = new TArray<UPhysicsConstraintTemplate>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_ConstraintSetup, this));
				}
				return result;
			}
			set
			{
				this.ConstraintSetup.CopyAssign(value);
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600DB80 RID: 56192 RVA: 0x00143678 File Offset: 0x00141878
		// (set) Token: 0x0600DB81 RID: 56193 RVA: 0x001436B1 File Offset: 0x001418B1
		public FSolverIterations SolverIterations
		{
			get
			{
				base.FastCheckIsValid();
				FSolverIterations result;
				if ((result = this._SolverIterations) == null)
				{
					result = (this._SolverIterations = new FSolverIterations(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_SolverIterations, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverIterations.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_SolverIterations, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x001436D2 File Offset: 0x001418D2
		// (set) Token: 0x0600DB83 RID: 56195 RVA: 0x001436EB File Offset: 0x001418EB
		public unsafe bool bNotForDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) & UPhysicsAsset.__PropertyMask_bNotForDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) = ((*(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) & ~UPhysicsAsset.__PropertyMask_bNotForDedicatedServer) | (value ? UPhysicsAsset.__PropertyMask_bNotForDedicatedServer : 0));
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x0014371B File Offset: 0x0014191B
		// (set) Token: 0x0600DB85 RID: 56197 RVA: 0x0014372F File Offset: 0x0014192F
		[Nullable(2)]
		public unsafe UThumbnailInfo ThumbnailInfo
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UThumbnailInfo>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsAsset.__PropertyOffset_ThumbnailInfo);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsAsset.__PropertyOffset_ThumbnailInfo, value);
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600DB86 RID: 56198 RVA: 0x00143744 File Offset: 0x00141944
		// (set) Token: 0x0600DB87 RID: 56199 RVA: 0x0014377D File Offset: 0x0014197D
		public TArray<UBodySetup> BodySetup_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._BodySetup_DEPRECATED) == null)
				{
					result = (this._BodySetup_DEPRECATED = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_BodySetup_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.BodySetup_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x0600DB88 RID: 56200 RVA: 0x0014378B File Offset: 0x0014198B
		static UPhysicsAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsAsset");
		}

		// Token: 0x0600DB89 RID: 56201 RVA: 0x00143799 File Offset: 0x00141999
		protected UPhysicsAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076B8 RID: 30392
		internal static int __InterfaceOffset_IInterface_PreviewMeshProvider;

		// Token: 0x040076B9 RID: 30393
		public new const string __ObjectPath = "/Script/Engine.PhysicsAsset";

		// Token: 0x040076BA RID: 30394
		private static IntPtr _ClassPtr;

		// Token: 0x040076BB RID: 30395
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076BC RID: 30396
		internal static int __PropertyOffset_BoundsBodies;

		// Token: 0x040076BD RID: 30397
		[Nullable(2)]
		private TArray<int> _BoundsBodies;

		// Token: 0x040076BE RID: 30398
		internal static int __PropertyOffset_SkeletalBodySetups;

		// Token: 0x040076BF RID: 30399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalBodySetup> _SkeletalBodySetups;

		// Token: 0x040076C0 RID: 30400
		internal static int __PropertyOffset_ConstraintSetup;

		// Token: 0x040076C1 RID: 30401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicsConstraintTemplate> _ConstraintSetup;

		// Token: 0x040076C2 RID: 30402
		internal static int __PropertyOffset_SolverIterations;

		// Token: 0x040076C3 RID: 30403
		[Nullable(2)]
		private FSolverIterations _SolverIterations;

		// Token: 0x040076C4 RID: 30404
		internal static int __PropertyOffset_bNotForDedicatedServer;

		// Token: 0x040076C5 RID: 30405
		internal static byte __PropertyMask_bNotForDedicatedServer;

		// Token: 0x040076C6 RID: 30406
		internal static int __PropertyOffset_ThumbnailInfo;

		// Token: 0x040076C7 RID: 30407
		internal static int __PropertyOffset_BodySetup_DEPRECATED;

		// Token: 0x040076C8 RID: 30408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _BodySetup_DEPRECATED;
	}
}
