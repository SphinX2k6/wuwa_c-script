using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E8B RID: 7819
	[UnrealObjectPath("/Script/KuroTerrainSurvey.TerrainSurveyCreate")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UTerrainSurveyCreate : UTerrainSurveyCreateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DBFA RID: 121850 RVA: 0x002BF3B0 File Offset: 0x002BD5B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTerrainSurveyCreate._ClassPtr;
		}

		// Token: 0x0601DBFB RID: 121851 RVA: 0x002BF3BC File Offset: 0x002BD5BC
		public UTerrainSurveyCreate() : this(BuiltinUtils.AllocNativeUObject(UTerrainSurveyCreate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DBFC RID: 121852 RVA: 0x002BF3E4 File Offset: 0x002BD5E4
		[NullableContext(1)]
		public UTerrainSurveyCreate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTerrainSurveyCreate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007781 RID: 30593
		// (get) Token: 0x0601DBFD RID: 121853 RVA: 0x002BF417 File Offset: 0x002BD617
		// (set) Token: 0x0601DBFE RID: 121854 RVA: 0x002BF42B File Offset: 0x002BD62B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> PredictionAnimInsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTerrainSurveyCreate.__PropertyOffset_PredictionAnimInsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTerrainSurveyCreate.__PropertyOffset_PredictionAnimInsClass) = value;
			}
		}

		// Token: 0x17007782 RID: 30594
		// (get) Token: 0x0601DBFF RID: 121855 RVA: 0x002BF440 File Offset: 0x002BD640
		// (set) Token: 0x0601DC00 RID: 121856 RVA: 0x002BF454 File Offset: 0x002BD654
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> SyncTargetAnimInsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTerrainSurveyCreate.__PropertyOffset_SyncTargetAnimInsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTerrainSurveyCreate.__PropertyOffset_SyncTargetAnimInsClass) = value;
			}
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x002BF469 File Offset: 0x002BD669
		static UTerrainSurveyCreate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroTerrainSurvey.TerrainSurveyCreate");
		}

		// Token: 0x0601DC02 RID: 121858 RVA: 0x002BF477 File Offset: 0x002BD677
		protected UTerrainSurveyCreate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101B8 RID: 65976
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroTerrainSurvey.TerrainSurveyCreate";

		// Token: 0x040101B9 RID: 65977
		private static IntPtr _ClassPtr;

		// Token: 0x040101BA RID: 65978
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101BB RID: 65979
		internal static int __PropertyOffset_PredictionAnimInsClass;

		// Token: 0x040101BC RID: 65980
		internal static int __PropertyOffset_SyncTargetAnimInsClass;
	}
}
