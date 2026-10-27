using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039A RID: 922
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARCandidateObject")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UARCandidateObject : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003306 RID: 13062 RVA: 0x0004E47E File Offset: 0x0004C67E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARCandidateObject._ClassPtr;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0004E48C File Offset: 0x0004C68C
		public UARCandidateObject() : this(BuiltinUtils.AllocNativeUObject(UARCandidateObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
		public UARCandidateObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARCandidateObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x0004E4E8 File Offset: 0x0004C6E8
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x0004E521 File Offset: 0x0004C721
		public TArray<byte> CandidateObjectData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._CandidateObjectData) == null)
				{
					result = (this._CandidateObjectData = new TArray<byte>(base.NativePtr + (IntPtr)UARCandidateObject.__PropertyOffset_CandidateObjectData, this));
				}
				return result;
			}
			set
			{
				this.CandidateObjectData.CopyAssign(value);
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x0004E52F File Offset: 0x0004C72F
		// (set) Token: 0x0600330C RID: 13068 RVA: 0x0004E543 File Offset: 0x0004C743
		public unsafe string FriendlyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UARCandidateObject.__PropertyOffset_FriendlyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UARCandidateObject.__PropertyOffset_FriendlyName)), value);
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x0004E558 File Offset: 0x0004C758
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x0004E56C File Offset: 0x0004C76C
		public unsafe FBox BoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARCandidateObject.__PropertyOffset_BoundingBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARCandidateObject.__PropertyOffset_BoundingBox) = value;
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0004E584 File Offset: 0x0004C784
		public unsafe void SetFriendlyName(string NewName)
		{
			FString fstring = FString.AllocTemp(NewName);
			UARCandidateObject.__SetFriendlyName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0004E5AE File Offset: 0x0004C7AE
		[NullableContext(2)]
		public void SetCandidateObjectData(in TArray<byte> InCandidateObject)
		{
			UARCandidateObject.__SetCandidateObjectData_Internal(base.NativePtr, (InCandidateObject ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x0004E5CB File Offset: 0x0004C7CB
		public void SetBoundingBox(in FBox InBoundingBox)
		{
			UARCandidateObject.__SetBoundingBox_Internal(base.NativePtr, InBoundingBox);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0004E5D9 File Offset: 0x0004C7D9
		public string GetFriendlyName()
		{
			return FString.ToStringAndDeleteNativePtr(UARCandidateObject.__GetFriendlyName_Internal(base.NativePtr));
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0004E5EB File Offset: 0x0004C7EB
		public TArray<byte> GetCandidateObjectData()
		{
			return new TArray<byte>(UARCandidateObject.__GetCandidateObjectData_Internal(base.NativePtr), null);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0004E5FE File Offset: 0x0004C7FE
		public FBox GetBoundingBox()
		{
			return UARCandidateObject.__GetBoundingBox_Internal(base.NativePtr);
		}

		// Token: 0x06003315 RID: 13077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFriendlyName_Internal(IntPtr @this, in FString NewName);

		// Token: 0x06003316 RID: 13078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCandidateObjectData_Internal(IntPtr @this, IntPtr InCandidateObject);

		// Token: 0x06003317 RID: 13079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundingBox_Internal(IntPtr @this, in FBox InBoundingBox);

		// Token: 0x06003318 RID: 13080
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFriendlyName_Internal(IntPtr @this);

		// Token: 0x06003319 RID: 13081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCandidateObjectData_Internal(IntPtr @this);

		// Token: 0x0600331A RID: 13082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetBoundingBox_Internal(IntPtr @this);

		// Token: 0x0600331B RID: 13083 RVA: 0x0004E60B File Offset: 0x0004C80B
		static UARCandidateObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARCandidateObject");
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0004E619 File Offset: 0x0004C819
		protected UARCandidateObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001634 RID: 5684
		public new const string __ObjectPath = "/Script/AugmentedReality.ARCandidateObject";

		// Token: 0x04001635 RID: 5685
		private static IntPtr _ClassPtr;

		// Token: 0x04001636 RID: 5686
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001637 RID: 5687
		internal static int __PropertyOffset_CandidateObjectData;

		// Token: 0x04001638 RID: 5688
		[Nullable(2)]
		private TArray<byte> _CandidateObjectData;

		// Token: 0x04001639 RID: 5689
		internal static int __PropertyOffset_FriendlyName;

		// Token: 0x0400163A RID: 5690
		internal static int __PropertyOffset_BoundingBox;
	}
}
