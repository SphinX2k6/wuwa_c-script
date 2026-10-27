using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200093C RID: 2364
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CloudStorageBase")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UCloudStorageBase : UPlatformInterfaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060085A6 RID: 34214 RVA: 0x000BE8E5 File Offset: 0x000BCAE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCloudStorageBase._ClassPtr;
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x000BE8F4 File Offset: 0x000BCAF4
		public UCloudStorageBase() : this(BuiltinUtils.AllocNativeUObject(UCloudStorageBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x000BE91C File Offset: 0x000BCB1C
		public UCloudStorageBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCloudStorageBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x000BE950 File Offset: 0x000BCB50
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x000BE989 File Offset: 0x000BCB89
		public TArray<string> LocalCloudFiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LocalCloudFiles) == null)
				{
					result = (this._LocalCloudFiles = new TArray<string>(base.NativePtr + (IntPtr)UCloudStorageBase.__PropertyOffset_LocalCloudFiles, this));
				}
				return result;
			}
			set
			{
				this.LocalCloudFiles.CopyAssign(value);
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x000BE997 File Offset: 0x000BCB97
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		public unsafe bool bSuppressDelegateCalls
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCloudStorageBase.__PropertyOffset_bSuppressDelegateCalls) & UCloudStorageBase.__PropertyMask_bSuppressDelegateCalls) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCloudStorageBase.__PropertyOffset_bSuppressDelegateCalls) = ((*(base.NativePtr + (IntPtr)UCloudStorageBase.__PropertyOffset_bSuppressDelegateCalls) & ~UCloudStorageBase.__PropertyMask_bSuppressDelegateCalls) | (value ? UCloudStorageBase.__PropertyMask_bSuppressDelegateCalls : 0));
			}
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x000BE9E0 File Offset: 0x000BCBE0
		static UCloudStorageBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CloudStorageBase");
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x000BE9EE File Offset: 0x000BCBEE
		protected UCloudStorageBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F99 RID: 16281
		public new const string __ObjectPath = "/Script/Engine.CloudStorageBase";

		// Token: 0x04003F9A RID: 16282
		private static IntPtr _ClassPtr;

		// Token: 0x04003F9B RID: 16283
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F9C RID: 16284
		internal static int __PropertyOffset_LocalCloudFiles;

		// Token: 0x04003F9D RID: 16285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LocalCloudFiles;

		// Token: 0x04003F9E RID: 16286
		internal static int __PropertyOffset_bSuppressDelegateCalls;

		// Token: 0x04003F9F RID: 16287
		internal static byte __PropertyMask_bSuppressDelegateCalls;
	}
}
