using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FAC RID: 8108
	[UnrealObjectPath("/Script/LevelSequence.KuroLevelSequenceActorConfig")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroLevelSequenceActorConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC29 RID: 125993 RVA: 0x002DBA45 File Offset: 0x002D9C45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelSequenceActorConfig._ClassPtr;
		}

		// Token: 0x0601EC2A RID: 125994 RVA: 0x002DBA54 File Offset: 0x002D9C54
		public UKuroLevelSequenceActorConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSequenceActorConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC2B RID: 125995 RVA: 0x002DBA7C File Offset: 0x002D9C7C
		[NullableContext(1)]
		public UKuroLevelSequenceActorConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSequenceActorConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A85 RID: 31365
		// (get) Token: 0x0601EC2C RID: 125996 RVA: 0x002DBAAF File Offset: 0x002D9CAF
		// (set) Token: 0x0601EC2D RID: 125997 RVA: 0x002DBABF File Offset: 0x002D9CBF
		public unsafe int RenderCheckFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_RenderCheckFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_RenderCheckFrame) = value;
			}
		}

		// Token: 0x17007A86 RID: 31366
		// (get) Token: 0x0601EC2E RID: 125998 RVA: 0x002DBAD0 File Offset: 0x002D9CD0
		// (set) Token: 0x0601EC2F RID: 125999 RVA: 0x002DBAE0 File Offset: 0x002D9CE0
		public unsafe float MinDistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MinDistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MinDistSquared) = value;
			}
		}

		// Token: 0x17007A87 RID: 31367
		// (get) Token: 0x0601EC30 RID: 126000 RVA: 0x002DBAF1 File Offset: 0x002D9CF1
		// (set) Token: 0x0601EC31 RID: 126001 RVA: 0x002DBB01 File Offset: 0x002D9D01
		public unsafe int MinSkipFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MinSkipFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MinSkipFrame) = value;
			}
		}

		// Token: 0x17007A88 RID: 31368
		// (get) Token: 0x0601EC32 RID: 126002 RVA: 0x002DBB12 File Offset: 0x002D9D12
		// (set) Token: 0x0601EC33 RID: 126003 RVA: 0x002DBB22 File Offset: 0x002D9D22
		public unsafe float MidDistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MidDistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MidDistSquared) = value;
			}
		}

		// Token: 0x17007A89 RID: 31369
		// (get) Token: 0x0601EC34 RID: 126004 RVA: 0x002DBB33 File Offset: 0x002D9D33
		// (set) Token: 0x0601EC35 RID: 126005 RVA: 0x002DBB43 File Offset: 0x002D9D43
		public unsafe int MidSkipFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MidSkipFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MidSkipFrame) = value;
			}
		}

		// Token: 0x17007A8A RID: 31370
		// (get) Token: 0x0601EC36 RID: 126006 RVA: 0x002DBB54 File Offset: 0x002D9D54
		// (set) Token: 0x0601EC37 RID: 126007 RVA: 0x002DBB64 File Offset: 0x002D9D64
		public unsafe float MaxDistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MaxDistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MaxDistSquared) = value;
			}
		}

		// Token: 0x17007A8B RID: 31371
		// (get) Token: 0x0601EC38 RID: 126008 RVA: 0x002DBB75 File Offset: 0x002D9D75
		// (set) Token: 0x0601EC39 RID: 126009 RVA: 0x002DBB85 File Offset: 0x002D9D85
		public unsafe int MaxSkipFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MaxSkipFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSequenceActorConfig.__PropertyOffset_MaxSkipFrame) = value;
			}
		}

		// Token: 0x0601EC3A RID: 126010 RVA: 0x002DBB96 File Offset: 0x002D9D96
		static UKuroLevelSequenceActorConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.KuroLevelSequenceActorConfig");
		}

		// Token: 0x0601EC3B RID: 126011 RVA: 0x002DBBA4 File Offset: 0x002D9DA4
		protected UKuroLevelSequenceActorConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A17 RID: 68119
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.KuroLevelSequenceActorConfig";

		// Token: 0x04010A18 RID: 68120
		private static IntPtr _ClassPtr;

		// Token: 0x04010A19 RID: 68121
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A1A RID: 68122
		internal static int __PropertyOffset_RenderCheckFrame;

		// Token: 0x04010A1B RID: 68123
		internal static int __PropertyOffset_MinDistSquared;

		// Token: 0x04010A1C RID: 68124
		internal static int __PropertyOffset_MinSkipFrame;

		// Token: 0x04010A1D RID: 68125
		internal static int __PropertyOffset_MidDistSquared;

		// Token: 0x04010A1E RID: 68126
		internal static int __PropertyOffset_MidSkipFrame;

		// Token: 0x04010A1F RID: 68127
		internal static int __PropertyOffset_MaxDistSquared;

		// Token: 0x04010A20 RID: 68128
		internal static int __PropertyOffset_MaxSkipFrame;
	}
}
