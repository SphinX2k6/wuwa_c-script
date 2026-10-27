using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200110A RID: 4362
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSocket")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USkeletalMeshSocket : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FD15 RID: 64789 RVA: 0x00175BBF File Offset: 0x00173DBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshSocket._ClassPtr;
		}

		// Token: 0x0600FD16 RID: 64790 RVA: 0x00175BCC File Offset: 0x00173DCC
		public USkeletalMeshSocket() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSocket.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FD17 RID: 64791 RVA: 0x00175BF4 File Offset: 0x00173DF4
		[NullableContext(1)]
		public USkeletalMeshSocket(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSocket.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600FD18 RID: 64792 RVA: 0x00175C27 File Offset: 0x00173E27
		// (set) Token: 0x0600FD19 RID: 64793 RVA: 0x00175C3B File Offset: 0x00173E3B
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600FD1A RID: 64794 RVA: 0x00175C50 File Offset: 0x00173E50
		// (set) Token: 0x0600FD1B RID: 64795 RVA: 0x00175C64 File Offset: 0x00173E64
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600FD1C RID: 64796 RVA: 0x00175C79 File Offset: 0x00173E79
		// (set) Token: 0x0600FD1D RID: 64797 RVA: 0x00175C8D File Offset: 0x00173E8D
		public unsafe FVector RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeLocation) = value;
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600FD1E RID: 64798 RVA: 0x00175CA2 File Offset: 0x00173EA2
		// (set) Token: 0x0600FD1F RID: 64799 RVA: 0x00175CB6 File Offset: 0x00173EB6
		public unsafe FRotator RelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeRotation) = value;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600FD20 RID: 64800 RVA: 0x00175CCB File Offset: 0x00173ECB
		// (set) Token: 0x0600FD21 RID: 64801 RVA: 0x00175CDF File Offset: 0x00173EDF
		public unsafe FVector RelativeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_RelativeScale) = value;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600FD22 RID: 64802 RVA: 0x00175CF4 File Offset: 0x00173EF4
		// (set) Token: 0x0600FD23 RID: 64803 RVA: 0x00175D04 File Offset: 0x00173F04
		public unsafe bool bForceAlwaysAnimated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_bForceAlwaysAnimated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSocket.__PropertyOffset_bForceAlwaysAnimated) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600FD24 RID: 64804 RVA: 0x00175D15 File Offset: 0x00173F15
		[NullableContext(2)]
		public void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp, FVector WorldLocation, FVector WorldNormal)
		{
			USkeletalMeshSocket.__InitializeSocketFromLocation_Internal(base.NativePtr, (SkelComp != null) ? SkelComp.NativePtr : IntPtr.Zero, WorldLocation, WorldNormal);
		}

		// Token: 0x0600FD25 RID: 64805 RVA: 0x00175D34 File Offset: 0x00173F34
		[NullableContext(2)]
		public FVector GetSocketLocation(USkeletalMeshComponent SkelComp)
		{
			return USkeletalMeshSocket.__GetSocketLocation_Internal(base.NativePtr, (SkelComp != null) ? SkelComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FD26 RID: 64806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeSocketFromLocation_Internal(IntPtr @this, IntPtr SkelComp, FVector WorldLocation, FVector WorldNormal);

		// Token: 0x0600FD27 RID: 64807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSocketLocation_Internal(IntPtr @this, IntPtr SkelComp);

		// Token: 0x0600FD28 RID: 64808 RVA: 0x00175D51 File Offset: 0x00173F51
		static USkeletalMeshSocket()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshSocket");
		}

		// Token: 0x0600FD29 RID: 64809 RVA: 0x00175D5F File Offset: 0x00173F5F
		protected USkeletalMeshSocket(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008868 RID: 34920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshSocket";

		// Token: 0x04008869 RID: 34921
		private static IntPtr _ClassPtr;

		// Token: 0x0400886A RID: 34922
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400886B RID: 34923
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0400886C RID: 34924
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400886D RID: 34925
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x0400886E RID: 34926
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x0400886F RID: 34927
		internal static int __PropertyOffset_RelativeScale;

		// Token: 0x04008870 RID: 34928
		internal static int __PropertyOffset_bForceAlwaysAnimated;
	}
}
