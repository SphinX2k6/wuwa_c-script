using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000922 RID: 2338
	[UnrealObjectPath("/Script/Engine.ChannelDefinition")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FChannelDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600810B RID: 33035 RVA: 0x000B8F8F File Offset: 0x000B718F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChannelDefinition._ScriptStructPtr != 0) ? FChannelDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ChannelDefinition", ref FChannelDefinition._ScriptStructPtr);
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600810C RID: 33036 RVA: 0x000B8FB3 File Offset: 0x000B71B3
		// (set) Token: 0x0600810D RID: 33037 RVA: 0x000B8FC7 File Offset: 0x000B71C7
		public unsafe FName ChannelName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ChannelName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ChannelName) = value;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600810E RID: 33038 RVA: 0x000B8FDC File Offset: 0x000B71DC
		// (set) Token: 0x0600810F RID: 33039 RVA: 0x000B8FF0 File Offset: 0x000B71F0
		public unsafe FName ClassName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ClassName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ClassName) = value;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06008110 RID: 33040 RVA: 0x000B9005 File Offset: 0x000B7205
		// (set) Token: 0x06008111 RID: 33041 RVA: 0x000B9019 File Offset: 0x000B7219
		public unsafe UClassStackOnlyPtr ChannelClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ChannelClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_ChannelClass) = value;
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06008112 RID: 33042 RVA: 0x000B902E File Offset: 0x000B722E
		// (set) Token: 0x06008113 RID: 33043 RVA: 0x000B903E File Offset: 0x000B723E
		public unsafe int StaticChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_StaticChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_StaticChannelIndex) = value;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06008114 RID: 33044 RVA: 0x000B904F File Offset: 0x000B724F
		// (set) Token: 0x06008115 RID: 33045 RVA: 0x000B905F File Offset: 0x000B725F
		public unsafe bool bTickOnCreate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bTickOnCreate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bTickOnCreate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x000B9070 File Offset: 0x000B7270
		// (set) Token: 0x06008117 RID: 33047 RVA: 0x000B9080 File Offset: 0x000B7280
		public unsafe bool bServerOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bServerOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bServerOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06008118 RID: 33048 RVA: 0x000B9091 File Offset: 0x000B7291
		// (set) Token: 0x06008119 RID: 33049 RVA: 0x000B90A1 File Offset: 0x000B72A1
		public unsafe bool bClientOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bClientOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bClientOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x000B90B2 File Offset: 0x000B72B2
		// (set) Token: 0x0600811B RID: 33051 RVA: 0x000B90C2 File Offset: 0x000B72C2
		public unsafe bool bInitialServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bInitialServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bInitialServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600811C RID: 33052 RVA: 0x000B90D3 File Offset: 0x000B72D3
		// (set) Token: 0x0600811D RID: 33053 RVA: 0x000B90E3 File Offset: 0x000B72E3
		public unsafe bool bInitialClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bInitialClient) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelDefinition.__PropertyOffset_bInitialClient) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x000B90F4 File Offset: 0x000B72F4
		public FChannelDefinition()
		{
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x000B90FC File Offset: 0x000B72FC
		public FChannelDefinition(FName ChannelName, FName ClassName, UClassStackOnlyPtr ChannelClass, int StaticChannelIndex, bool bTickOnCreate, bool bServerOpen, bool bClientOpen, bool bInitialServer, bool bInitialClient)
		{
			this.ChannelName = ChannelName;
			this.ClassName = ClassName;
			this.ChannelClass = ChannelClass;
			this.StaticChannelIndex = StaticChannelIndex;
			this.bTickOnCreate = bTickOnCreate;
			this.bServerOpen = bServerOpen;
			this.bClientOpen = bClientOpen;
			this.bInitialServer = bInitialServer;
			this.bInitialClient = bInitialClient;
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x000B9154 File Offset: 0x000B7354
		protected override IntPtr GetUStructPtr()
		{
			return FChannelDefinition.StaticStruct();
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x000B9160 File Offset: 0x000B7360
		[NullableContext(2)]
		public FChannelDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x000B916A File Offset: 0x000B736A
		public FChannelDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x000B9175 File Offset: 0x000B7375
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChannelDefinition(Pointer, false, true);
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x000B917F File Offset: 0x000B737F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChannelDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04003DC0 RID: 15808
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ChannelDefinition";

		// Token: 0x04003DC1 RID: 15809
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003DC2 RID: 15810
		internal static int __PropertyOffset_ChannelName;

		// Token: 0x04003DC3 RID: 15811
		internal static int __PropertyOffset_ClassName;

		// Token: 0x04003DC4 RID: 15812
		internal static int __PropertyOffset_ChannelClass;

		// Token: 0x04003DC5 RID: 15813
		internal static int __PropertyOffset_StaticChannelIndex;

		// Token: 0x04003DC6 RID: 15814
		internal static int __PropertyOffset_bTickOnCreate;

		// Token: 0x04003DC7 RID: 15815
		internal static int __PropertyOffset_bServerOpen;

		// Token: 0x04003DC8 RID: 15816
		internal static int __PropertyOffset_bClientOpen;

		// Token: 0x04003DC9 RID: 15817
		internal static int __PropertyOffset_bInitialServer;

		// Token: 0x04003DCA RID: 15818
		internal static int __PropertyOffset_bInitialClient;
	}
}
