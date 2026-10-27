using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028FC RID: 10492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.TASaveConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UTASaveConfig : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026E87 RID: 159367 RVA: 0x003B5ACC File Offset: 0x003B3CCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTASaveConfig._ClassPtr;
		}

		// Token: 0x06026E88 RID: 159368 RVA: 0x003B5AD8 File Offset: 0x003B3CD8
		public UTASaveConfig() : this(BuiltinUtils.AllocNativeUObject(UTASaveConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026E89 RID: 159369 RVA: 0x003B5B00 File Offset: 0x003B3D00
		public UTASaveConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTASaveConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095E5 RID: 38373
		// (get) Token: 0x06026E8A RID: 159370 RVA: 0x003B5B33 File Offset: 0x003B3D33
		// (set) Token: 0x06026E8B RID: 159371 RVA: 0x003B5B43 File Offset: 0x003B3D43
		public unsafe int TrackState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTASaveConfig.__PropertyOffset_TrackState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTASaveConfig.__PropertyOffset_TrackState) = value;
			}
		}

		// Token: 0x170095E6 RID: 38374
		// (get) Token: 0x06026E8C RID: 159372 RVA: 0x003B5B54 File Offset: 0x003B3D54
		// (set) Token: 0x06026E8D RID: 159373 RVA: 0x003B5B68 File Offset: 0x003B3D68
		public unsafe string DistinctID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_DistinctID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_DistinctID)), value);
			}
		}

		// Token: 0x170095E7 RID: 38375
		// (get) Token: 0x06026E8E RID: 159374 RVA: 0x003B5B7D File Offset: 0x003B3D7D
		// (set) Token: 0x06026E8F RID: 159375 RVA: 0x003B5B91 File Offset: 0x003B3D91
		public unsafe string AccountID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_AccountID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_AccountID)), value);
			}
		}

		// Token: 0x170095E8 RID: 38376
		// (get) Token: 0x06026E90 RID: 159376 RVA: 0x003B5BA6 File Offset: 0x003B3DA6
		// (set) Token: 0x06026E91 RID: 159377 RVA: 0x003B5BBA File Offset: 0x003B3DBA
		public unsafe string SuperProperties
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_SuperProperties)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTASaveConfig.__PropertyOffset_SuperProperties)), value);
			}
		}

		// Token: 0x170095E9 RID: 38377
		// (get) Token: 0x06026E92 RID: 159378 RVA: 0x003B5BCF File Offset: 0x003B3DCF
		// (set) Token: 0x06026E93 RID: 159379 RVA: 0x003B5BDF File Offset: 0x003B3DDF
		public unsafe uint UserIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTASaveConfig.__PropertyOffset_UserIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTASaveConfig.__PropertyOffset_UserIndex) = (int)value;
			}
		}

		// Token: 0x06026E94 RID: 159380 RVA: 0x003B5BF0 File Offset: 0x003B3DF0
		static UTASaveConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.TASaveConfig");
		}

		// Token: 0x06026E95 RID: 159381 RVA: 0x003B5BFE File Offset: 0x003B3DFE
		protected UTASaveConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155CF RID: 87503
		public new const string __ObjectPath = "/Script/TASdkPlugin.TASaveConfig";

		// Token: 0x040155D0 RID: 87504
		private static IntPtr _ClassPtr;

		// Token: 0x040155D1 RID: 87505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155D2 RID: 87506
		internal static int __PropertyOffset_TrackState;

		// Token: 0x040155D3 RID: 87507
		internal static int __PropertyOffset_DistinctID;

		// Token: 0x040155D4 RID: 87508
		internal static int __PropertyOffset_AccountID;

		// Token: 0x040155D5 RID: 87509
		internal static int __PropertyOffset_SuperProperties;

		// Token: 0x040155D6 RID: 87510
		internal static int __PropertyOffset_UserIndex;
	}
}
