using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001197 RID: 4503
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshSocket")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UStaticMeshSocket : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601096E RID: 67950 RVA: 0x00185C7C File Offset: 0x00183E7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMeshSocket._ClassPtr;
		}

		// Token: 0x0601096F RID: 67951 RVA: 0x00185C88 File Offset: 0x00183E88
		public UStaticMeshSocket() : this(BuiltinUtils.AllocNativeUObject(UStaticMeshSocket.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010970 RID: 67952 RVA: 0x00185CB0 File Offset: 0x00183EB0
		public UStaticMeshSocket(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMeshSocket.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x06010971 RID: 67953 RVA: 0x00185CE3 File Offset: 0x00183EE3
		// (set) Token: 0x06010972 RID: 67954 RVA: 0x00185CF7 File Offset: 0x00183EF7
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x06010973 RID: 67955 RVA: 0x00185D0C File Offset: 0x00183F0C
		// (set) Token: 0x06010974 RID: 67956 RVA: 0x00185D20 File Offset: 0x00183F20
		public unsafe FVector RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeLocation) = value;
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x06010975 RID: 67957 RVA: 0x00185D35 File Offset: 0x00183F35
		// (set) Token: 0x06010976 RID: 67958 RVA: 0x00185D49 File Offset: 0x00183F49
		public unsafe FRotator RelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeRotation) = value;
			}
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x06010977 RID: 67959 RVA: 0x00185D5E File Offset: 0x00183F5E
		// (set) Token: 0x06010978 RID: 67960 RVA: 0x00185D72 File Offset: 0x00183F72
		public unsafe FVector RelativeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSocket.__PropertyOffset_RelativeScale) = value;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x06010979 RID: 67961 RVA: 0x00185D87 File Offset: 0x00183F87
		// (set) Token: 0x0601097A RID: 67962 RVA: 0x00185D9B File Offset: 0x00183F9B
		public unsafe string Tag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UStaticMeshSocket.__PropertyOffset_Tag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UStaticMeshSocket.__PropertyOffset_Tag)), value);
			}
		}

		// Token: 0x0601097B RID: 67963 RVA: 0x00185DB0 File Offset: 0x00183FB0
		static UStaticMeshSocket()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMeshSocket");
		}

		// Token: 0x0601097C RID: 67964 RVA: 0x00185DBE File Offset: 0x00183FBE
		protected UStaticMeshSocket(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008DFB RID: 36347
		public new const string __ObjectPath = "/Script/Engine.StaticMeshSocket";

		// Token: 0x04008DFC RID: 36348
		private static IntPtr _ClassPtr;

		// Token: 0x04008DFD RID: 36349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008DFE RID: 36350
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04008DFF RID: 36351
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x04008E00 RID: 36352
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x04008E01 RID: 36353
		internal static int __PropertyOffset_RelativeScale;

		// Token: 0x04008E02 RID: 36354
		internal static int __PropertyOffset_Tag;
	}
}
