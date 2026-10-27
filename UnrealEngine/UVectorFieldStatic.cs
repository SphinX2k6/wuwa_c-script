using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001223 RID: 4643
	[UnrealObjectPath("/Script/Engine.VectorFieldStatic")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UVectorFieldStatic : UVectorField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011177 RID: 70007 RVA: 0x001914EE File Offset: 0x0018F6EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVectorFieldStatic._ClassPtr;
		}

		// Token: 0x06011178 RID: 70008 RVA: 0x001914FC File Offset: 0x0018F6FC
		public UVectorFieldStatic() : this(BuiltinUtils.AllocNativeUObject(UVectorFieldStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011179 RID: 70009 RVA: 0x00191524 File Offset: 0x0018F724
		[NullableContext(1)]
		public UVectorFieldStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVectorFieldStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0601117A RID: 70010 RVA: 0x00191557 File Offset: 0x0018F757
		// (set) Token: 0x0601117B RID: 70011 RVA: 0x00191567 File Offset: 0x0018F767
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0601117C RID: 70012 RVA: 0x00191578 File Offset: 0x0018F778
		// (set) Token: 0x0601117D RID: 70013 RVA: 0x00191588 File Offset: 0x0018F788
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0601117E RID: 70014 RVA: 0x00191599 File Offset: 0x0018F799
		// (set) Token: 0x0601117F RID: 70015 RVA: 0x001915A9 File Offset: 0x0018F7A9
		public unsafe int SizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_SizeZ) = value;
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x06011180 RID: 70016 RVA: 0x001915BA File Offset: 0x0018F7BA
		// (set) Token: 0x06011181 RID: 70017 RVA: 0x001915CA File Offset: 0x0018F7CA
		public unsafe bool bAllowCPUAccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_bAllowCPUAccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldStatic.__PropertyOffset_bAllowCPUAccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011182 RID: 70018 RVA: 0x001915DB File Offset: 0x0018F7DB
		static UVectorFieldStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VectorFieldStatic");
		}

		// Token: 0x06011183 RID: 70019 RVA: 0x001915E9 File Offset: 0x0018F7E9
		protected UVectorFieldStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009268 RID: 37480
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorFieldStatic";

		// Token: 0x04009269 RID: 37481
		private static IntPtr _ClassPtr;

		// Token: 0x0400926A RID: 37482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400926B RID: 37483
		internal static int __PropertyOffset_SizeX;

		// Token: 0x0400926C RID: 37484
		internal static int __PropertyOffset_SizeY;

		// Token: 0x0400926D RID: 37485
		internal static int __PropertyOffset_SizeZ;

		// Token: 0x0400926E RID: 37486
		internal static int __PropertyOffset_bAllowCPUAccess;
	}
}
