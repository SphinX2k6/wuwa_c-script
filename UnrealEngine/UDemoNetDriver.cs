using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B2 RID: 2482
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DemoNetDriver")]
	[UnrealStructLayout(4888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4888)]
	public class UDemoNetDriver : UNetDriver, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C57 RID: 35927 RVA: 0x000C8DB2 File Offset: 0x000C6FB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDemoNetDriver._ClassPtr;
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		public UDemoNetDriver() : this(BuiltinUtils.AllocNativeUObject(UDemoNetDriver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x000C8DE8 File Offset: 0x000C6FE8
		public UDemoNetDriver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDemoNetDriver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06008C5A RID: 35930 RVA: 0x000C8E1C File Offset: 0x000C701C
		// (set) Token: 0x06008C5B RID: 35931 RVA: 0x000C8E55 File Offset: 0x000C7055
		public TMap<string, FRollbackNetStartupActorInfo> RollbackNetStartupActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FRollbackNetStartupActorInfo> result;
				if ((result = this._RollbackNetStartupActors) == null)
				{
					result = (this._RollbackNetStartupActors = new TMap<string, FRollbackNetStartupActorInfo>(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_RollbackNetStartupActors, this));
				}
				return result;
			}
			set
			{
				this.RollbackNetStartupActors.CopyAssign(value);
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06008C5C RID: 35932 RVA: 0x000C8E63 File Offset: 0x000C7063
		// (set) Token: 0x06008C5D RID: 35933 RVA: 0x000C8E73 File Offset: 0x000C7073
		public unsafe float CheckpointSaveMaxMSPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_CheckpointSaveMaxMSPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_CheckpointSaveMaxMSPerFrame) = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06008C5E RID: 35934 RVA: 0x000C8E84 File Offset: 0x000C7084
		// (set) Token: 0x06008C5F RID: 35935 RVA: 0x000C8EBD File Offset: 0x000C70BD
		public TArray<FMulticastRecordOptions> MulticastRecordOptions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMulticastRecordOptions> result;
				if ((result = this._MulticastRecordOptions) == null)
				{
					result = (this._MulticastRecordOptions = new TArray<FMulticastRecordOptions>(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_MulticastRecordOptions, this));
				}
				return result;
			}
			set
			{
				this.MulticastRecordOptions.CopyAssign(value);
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x000C8ECB File Offset: 0x000C70CB
		// (set) Token: 0x06008C61 RID: 35937 RVA: 0x000C8EDB File Offset: 0x000C70DB
		public unsafe bool bIsLocalReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_bIsLocalReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_bIsLocalReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x000C8EEC File Offset: 0x000C70EC
		// (set) Token: 0x06008C63 RID: 35939 RVA: 0x000C8F25 File Offset: 0x000C7125
		public TArray<APlayerController> SpectatorControllers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerController> result;
				if ((result = this._SpectatorControllers) == null)
				{
					result = (this._SpectatorControllers = new TArray<APlayerController>(base.NativePtr + (IntPtr)UDemoNetDriver.__PropertyOffset_SpectatorControllers, this));
				}
				return result;
			}
			set
			{
				this.SpectatorControllers.CopyAssign(value);
			}
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x000C8F33 File Offset: 0x000C7133
		static UDemoNetDriver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DemoNetDriver");
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x000C8F41 File Offset: 0x000C7141
		protected UDemoNetDriver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400429C RID: 17052
		public new const string __ObjectPath = "/Script/Engine.DemoNetDriver";

		// Token: 0x0400429D RID: 17053
		private static IntPtr _ClassPtr;

		// Token: 0x0400429E RID: 17054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400429F RID: 17055
		internal static int __PropertyOffset_RollbackNetStartupActors;

		// Token: 0x040042A0 RID: 17056
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FRollbackNetStartupActorInfo> _RollbackNetStartupActors;

		// Token: 0x040042A1 RID: 17057
		internal static int __PropertyOffset_CheckpointSaveMaxMSPerFrame;

		// Token: 0x040042A2 RID: 17058
		internal static int __PropertyOffset_MulticastRecordOptions;

		// Token: 0x040042A3 RID: 17059
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMulticastRecordOptions> _MulticastRecordOptions;

		// Token: 0x040042A4 RID: 17060
		internal static int __PropertyOffset_bIsLocalReplay;

		// Token: 0x040042A5 RID: 17061
		internal static int __PropertyOffset_SpectatorControllers;

		// Token: 0x040042A6 RID: 17062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerController> _SpectatorControllers;
	}
}
