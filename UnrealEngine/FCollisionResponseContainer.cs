using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001A9 RID: 425
	[UnrealObjectPath("/Script/Engine.CollisionResponseContainer")]
	[UnrealStructLayout(32, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCollisionResponseContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F92 RID: 8082 RVA: 0x0002DA8C File Offset: 0x0002BC8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionResponseContainer._ScriptStructPtr != 0) ? FCollisionResponseContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionResponseContainer", ref FCollisionResponseContainer._ScriptStructPtr);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		public unsafe TEnumAsByte<ECollisionResponse> WorldStatic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldStatic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldStatic) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0002DAD9 File Offset: 0x0002BCD9
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0002DAED File Offset: 0x0002BCED
		public unsafe TEnumAsByte<ECollisionResponse> WorldDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldDynamic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldDynamic) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0002DB02 File Offset: 0x0002BD02
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0002DB16 File Offset: 0x0002BD16
		public unsafe TEnumAsByte<ECollisionResponse> Pawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Pawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Pawn) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0002DB2B File Offset: 0x0002BD2B
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0002DB3F File Offset: 0x0002BD3F
		public unsafe TEnumAsByte<ECollisionResponse> Visibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Visibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Visibility) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0002DB54 File Offset: 0x0002BD54
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0002DB68 File Offset: 0x0002BD68
		public unsafe TEnumAsByte<ECollisionResponse> Camera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Camera);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Camera) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0002DB7D File Offset: 0x0002BD7D
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0002DB91 File Offset: 0x0002BD91
		public unsafe TEnumAsByte<ECollisionResponse> PhysicsBody
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_PhysicsBody);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_PhysicsBody) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0002DBA6 File Offset: 0x0002BDA6
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0002DBBA File Offset: 0x0002BDBA
		public unsafe TEnumAsByte<ECollisionResponse> Vehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Vehicle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Vehicle) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0002DBCF File Offset: 0x0002BDCF
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0002DBE3 File Offset: 0x0002BDE3
		public unsafe TEnumAsByte<ECollisionResponse> Destructible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Destructible);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Destructible) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0002DBF8 File Offset: 0x0002BDF8
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0002DC0C File Offset: 0x0002BE0C
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel1) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0002DC21 File Offset: 0x0002BE21
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0002DC35 File Offset: 0x0002BE35
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel2) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0002DC4A File Offset: 0x0002BE4A
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0002DC5E File Offset: 0x0002BE5E
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel3) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0002DC73 File Offset: 0x0002BE73
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0002DC87 File Offset: 0x0002BE87
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel4) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0002DC9C File Offset: 0x0002BE9C
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel5) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0002DCC5 File Offset: 0x0002BEC5
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0002DCD9 File Offset: 0x0002BED9
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel6) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0002DCEE File Offset: 0x0002BEEE
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x0002DD02 File Offset: 0x0002BF02
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel1) = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0002DD17 File Offset: 0x0002BF17
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0002DD2B File Offset: 0x0002BF2B
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel2) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0002DD40 File Offset: 0x0002BF40
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0002DD54 File Offset: 0x0002BF54
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel3) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0002DD69 File Offset: 0x0002BF69
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0002DD7D File Offset: 0x0002BF7D
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel4) = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0002DD92 File Offset: 0x0002BF92
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0002DDA6 File Offset: 0x0002BFA6
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel5) = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0002DDBB File Offset: 0x0002BFBB
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0002DDCF File Offset: 0x0002BFCF
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel6) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel7) = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0002DE0D File Offset: 0x0002C00D
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x0002DE21 File Offset: 0x0002C021
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel8) = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0002DE36 File Offset: 0x0002C036
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0002DE4A File Offset: 0x0002C04A
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel9
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel9) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0002DE5F File Offset: 0x0002C05F
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0002DE73 File Offset: 0x0002C073
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel10
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel10) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0002DE88 File Offset: 0x0002C088
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0002DE9C File Offset: 0x0002C09C
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel11) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0002DEB1 File Offset: 0x0002C0B1
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0002DEC5 File Offset: 0x0002C0C5
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel12) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0002DEDA File Offset: 0x0002C0DA
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0002DEEE File Offset: 0x0002C0EE
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel13
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel13) = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0002DF03 File Offset: 0x0002C103
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0002DF17 File Offset: 0x0002C117
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel14
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel14) = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0002DF2C File Offset: 0x0002C12C
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0002DF40 File Offset: 0x0002C140
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel15
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel15) = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0002DF55 File Offset: 0x0002C155
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0002DF69 File Offset: 0x0002C169
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel16) = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0002DF7E File Offset: 0x0002C17E
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0002DF92 File Offset: 0x0002C192
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel17
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel17) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0002DFA7 File Offset: 0x0002C1A7
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0002DFBB File Offset: 0x0002C1BB
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel18
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel18) = value;
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0002DFD0 File Offset: 0x0002C1D0
		public FCollisionResponseContainer()
		{
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionResponseContainer.StaticStruct();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		[NullableContext(2)]
		public FCollisionResponseContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0002DFEE File Offset: 0x0002C1EE
		public FCollisionResponseContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0002DFF9 File Offset: 0x0002C1F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionResponseContainer(Pointer, false, true);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0002E003 File Offset: 0x0002C203
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionResponseContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04000A75 RID: 2677
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollisionResponseContainer";

		// Token: 0x04000A76 RID: 2678
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A77 RID: 2679
		internal static int __PropertyOffset_WorldStatic;

		// Token: 0x04000A78 RID: 2680
		internal static int __PropertyOffset_WorldDynamic;

		// Token: 0x04000A79 RID: 2681
		internal static int __PropertyOffset_Pawn;

		// Token: 0x04000A7A RID: 2682
		internal static int __PropertyOffset_Visibility;

		// Token: 0x04000A7B RID: 2683
		internal static int __PropertyOffset_Camera;

		// Token: 0x04000A7C RID: 2684
		internal static int __PropertyOffset_PhysicsBody;

		// Token: 0x04000A7D RID: 2685
		internal static int __PropertyOffset_Vehicle;

		// Token: 0x04000A7E RID: 2686
		internal static int __PropertyOffset_Destructible;

		// Token: 0x04000A7F RID: 2687
		internal static int __PropertyOffset_EngineTraceChannel1;

		// Token: 0x04000A80 RID: 2688
		internal static int __PropertyOffset_EngineTraceChannel2;

		// Token: 0x04000A81 RID: 2689
		internal static int __PropertyOffset_EngineTraceChannel3;

		// Token: 0x04000A82 RID: 2690
		internal static int __PropertyOffset_EngineTraceChannel4;

		// Token: 0x04000A83 RID: 2691
		internal static int __PropertyOffset_EngineTraceChannel5;

		// Token: 0x04000A84 RID: 2692
		internal static int __PropertyOffset_EngineTraceChannel6;

		// Token: 0x04000A85 RID: 2693
		internal static int __PropertyOffset_GameTraceChannel1;

		// Token: 0x04000A86 RID: 2694
		internal static int __PropertyOffset_GameTraceChannel2;

		// Token: 0x04000A87 RID: 2695
		internal static int __PropertyOffset_GameTraceChannel3;

		// Token: 0x04000A88 RID: 2696
		internal static int __PropertyOffset_GameTraceChannel4;

		// Token: 0x04000A89 RID: 2697
		internal static int __PropertyOffset_GameTraceChannel5;

		// Token: 0x04000A8A RID: 2698
		internal static int __PropertyOffset_GameTraceChannel6;

		// Token: 0x04000A8B RID: 2699
		internal static int __PropertyOffset_GameTraceChannel7;

		// Token: 0x04000A8C RID: 2700
		internal static int __PropertyOffset_GameTraceChannel8;

		// Token: 0x04000A8D RID: 2701
		internal static int __PropertyOffset_GameTraceChannel9;

		// Token: 0x04000A8E RID: 2702
		internal static int __PropertyOffset_GameTraceChannel10;

		// Token: 0x04000A8F RID: 2703
		internal static int __PropertyOffset_GameTraceChannel11;

		// Token: 0x04000A90 RID: 2704
		internal static int __PropertyOffset_GameTraceChannel12;

		// Token: 0x04000A91 RID: 2705
		internal static int __PropertyOffset_GameTraceChannel13;

		// Token: 0x04000A92 RID: 2706
		internal static int __PropertyOffset_GameTraceChannel14;

		// Token: 0x04000A93 RID: 2707
		internal static int __PropertyOffset_GameTraceChannel15;

		// Token: 0x04000A94 RID: 2708
		internal static int __PropertyOffset_GameTraceChannel16;

		// Token: 0x04000A95 RID: 2709
		internal static int __PropertyOffset_GameTraceChannel17;

		// Token: 0x04000A96 RID: 2710
		internal static int __PropertyOffset_GameTraceChannel18;
	}
}
