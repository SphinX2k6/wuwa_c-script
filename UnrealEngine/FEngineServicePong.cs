using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000792 RID: 1938
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServicePong")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FEngineServicePong : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064EA RID: 25834 RVA: 0x00090BD9 File Offset: 0x0008EDD9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServicePong._ScriptStructPtr != 0) ? FEngineServicePong._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServicePong", ref FEngineServicePong._ScriptStructPtr);
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x00090BFD File Offset: 0x0008EDFD
		// (set) Token: 0x060064EC RID: 25836 RVA: 0x00090C11 File Offset: 0x0008EE11
		public unsafe string CurrentLevel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServicePong.__PropertyOffset_CurrentLevel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServicePong.__PropertyOffset_CurrentLevel)), value);
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x060064ED RID: 25837 RVA: 0x00090C26 File Offset: 0x0008EE26
		// (set) Token: 0x060064EE RID: 25838 RVA: 0x00090C36 File Offset: 0x0008EE36
		public unsafe int EngineVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_EngineVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_EngineVersion) = value;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x060064EF RID: 25839 RVA: 0x00090C47 File Offset: 0x0008EE47
		// (set) Token: 0x060064F0 RID: 25840 RVA: 0x00090C57 File Offset: 0x0008EE57
		public unsafe bool HasBegunPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_HasBegunPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_HasBegunPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x060064F1 RID: 25841 RVA: 0x00090C68 File Offset: 0x0008EE68
		// (set) Token: 0x060064F2 RID: 25842 RVA: 0x00090C7C File Offset: 0x0008EE7C
		public unsafe FGuid InstanceId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_InstanceId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_InstanceId) = value;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x060064F3 RID: 25843 RVA: 0x00090C91 File Offset: 0x0008EE91
		// (set) Token: 0x060064F4 RID: 25844 RVA: 0x00090CA5 File Offset: 0x0008EEA5
		public unsafe string InstanceType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServicePong.__PropertyOffset_InstanceType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServicePong.__PropertyOffset_InstanceType)), value);
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x060064F5 RID: 25845 RVA: 0x00090CBA File Offset: 0x0008EEBA
		// (set) Token: 0x060064F6 RID: 25846 RVA: 0x00090CCE File Offset: 0x0008EECE
		public unsafe FGuid SessionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_SessionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_SessionId) = value;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x00090CE3 File Offset: 0x0008EEE3
		// (set) Token: 0x060064F8 RID: 25848 RVA: 0x00090CF3 File Offset: 0x0008EEF3
		public unsafe float WorldTimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_WorldTimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServicePong.__PropertyOffset_WorldTimeSeconds) = value;
			}
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00090D04 File Offset: 0x0008EF04
		public FEngineServicePong()
		{
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00090D0C File Offset: 0x0008EF0C
		public FEngineServicePong(string CurrentLevel, int EngineVersion, bool HasBegunPlay, FGuid InstanceId, string InstanceType, FGuid SessionId, float WorldTimeSeconds)
		{
			this.CurrentLevel = CurrentLevel;
			this.EngineVersion = EngineVersion;
			this.HasBegunPlay = HasBegunPlay;
			this.InstanceId = InstanceId;
			this.InstanceType = InstanceType;
			this.SessionId = SessionId;
			this.WorldTimeSeconds = WorldTimeSeconds;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00090D49 File Offset: 0x0008EF49
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServicePong.StaticStruct();
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00090D55 File Offset: 0x0008EF55
		[NullableContext(2)]
		public FEngineServicePong(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00090D5F File Offset: 0x0008EF5F
		public FEngineServicePong(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00090D6A File Offset: 0x0008EF6A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServicePong(Pointer, false, true);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00090D74 File Offset: 0x0008EF74
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServicePong(Pointer, MemoryOwner);
		}

		// Token: 0x040030E5 RID: 12517
		public const string __ObjectPath = "/Script/EngineMessages.EngineServicePong";

		// Token: 0x040030E6 RID: 12518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030E7 RID: 12519
		internal static int __PropertyOffset_CurrentLevel;

		// Token: 0x040030E8 RID: 12520
		internal static int __PropertyOffset_EngineVersion;

		// Token: 0x040030E9 RID: 12521
		internal static int __PropertyOffset_HasBegunPlay;

		// Token: 0x040030EA RID: 12522
		internal static int __PropertyOffset_InstanceId;

		// Token: 0x040030EB RID: 12523
		internal static int __PropertyOffset_InstanceType;

		// Token: 0x040030EC RID: 12524
		internal static int __PropertyOffset_SessionId;

		// Token: 0x040030ED RID: 12525
		internal static int __PropertyOffset_WorldTimeSeconds;
	}
}
