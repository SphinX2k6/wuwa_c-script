using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002781 RID: 10113
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BoneSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBoneSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025CE0 RID: 154848 RVA: 0x003950D6 File Offset: 0x003932D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneSettings._ScriptStructPtr != 0) ? FBoneSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.BoneSettings", ref FBoneSettings._ScriptStructPtr);
		}

		// Token: 0x17009194 RID: 37268
		// (get) Token: 0x06025CE1 RID: 154849 RVA: 0x003950FA File Offset: 0x003932FA
		// (set) Token: 0x06025CE2 RID: 154850 RVA: 0x00395113 File Offset: 0x00393313
		public unsafe bool UseBoneReducer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_UseBoneReducer) & FBoneSettings.__PropertyMask_UseBoneReducer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_UseBoneReducer) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_UseBoneReducer) & ~FBoneSettings.__PropertyMask_UseBoneReducer) | (value ? FBoneSettings.__PropertyMask_UseBoneReducer : 0));
			}
		}

		// Token: 0x17009195 RID: 37269
		// (get) Token: 0x06025CE3 RID: 154851 RVA: 0x00395143 File Offset: 0x00393343
		// (set) Token: 0x06025CE4 RID: 154852 RVA: 0x0039515C File Offset: 0x0039335C
		public unsafe bool BoneReductionTargetBoneRatioEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneRatioEnabled) & FBoneSettings.__PropertyMask_BoneReductionTargetBoneRatioEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneRatioEnabled) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneRatioEnabled) & ~FBoneSettings.__PropertyMask_BoneReductionTargetBoneRatioEnabled) | (value ? FBoneSettings.__PropertyMask_BoneReductionTargetBoneRatioEnabled : 0));
			}
		}

		// Token: 0x17009196 RID: 37270
		// (get) Token: 0x06025CE5 RID: 154853 RVA: 0x0039518C File Offset: 0x0039338C
		// (set) Token: 0x06025CE6 RID: 154854 RVA: 0x0039519C File Offset: 0x0039339C
		public unsafe float BoneReductionTargetBoneRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneRatio) = value;
			}
		}

		// Token: 0x17009197 RID: 37271
		// (get) Token: 0x06025CE7 RID: 154855 RVA: 0x003951AD File Offset: 0x003933AD
		// (set) Token: 0x06025CE8 RID: 154856 RVA: 0x003951C6 File Offset: 0x003933C6
		public unsafe bool BoneReductionTargetBoneCountEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneCountEnabled) & FBoneSettings.__PropertyMask_BoneReductionTargetBoneCountEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneCountEnabled) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneCountEnabled) & ~FBoneSettings.__PropertyMask_BoneReductionTargetBoneCountEnabled) | (value ? FBoneSettings.__PropertyMask_BoneReductionTargetBoneCountEnabled : 0));
			}
		}

		// Token: 0x17009198 RID: 37272
		// (get) Token: 0x06025CE9 RID: 154857 RVA: 0x003951F6 File Offset: 0x003933F6
		// (set) Token: 0x06025CEA RID: 154858 RVA: 0x00395206 File Offset: 0x00393406
		public unsafe int BoneReductionTargetBoneCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetBoneCount) = value;
			}
		}

		// Token: 0x17009199 RID: 37273
		// (get) Token: 0x06025CEB RID: 154859 RVA: 0x00395217 File Offset: 0x00393417
		// (set) Token: 0x06025CEC RID: 154860 RVA: 0x00395230 File Offset: 0x00393430
		public unsafe bool BoneReductionTargetMaxDeviationEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetMaxDeviationEnabled) & FBoneSettings.__PropertyMask_BoneReductionTargetMaxDeviationEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetMaxDeviationEnabled) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetMaxDeviationEnabled) & ~FBoneSettings.__PropertyMask_BoneReductionTargetMaxDeviationEnabled) | (value ? FBoneSettings.__PropertyMask_BoneReductionTargetMaxDeviationEnabled : 0));
			}
		}

		// Token: 0x1700919A RID: 37274
		// (get) Token: 0x06025CED RID: 154861 RVA: 0x00395260 File Offset: 0x00393460
		// (set) Token: 0x06025CEE RID: 154862 RVA: 0x00395270 File Offset: 0x00393470
		public unsafe float BoneReductionTargetMaxDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetMaxDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetMaxDeviation) = value;
			}
		}

		// Token: 0x1700919B RID: 37275
		// (get) Token: 0x06025CEF RID: 154863 RVA: 0x00395281 File Offset: 0x00393481
		// (set) Token: 0x06025CF0 RID: 154864 RVA: 0x0039529A File Offset: 0x0039349A
		public unsafe bool BoneReductionTargetOnScreenSizeEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetOnScreenSizeEnabled) & FBoneSettings.__PropertyMask_BoneReductionTargetOnScreenSizeEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetOnScreenSizeEnabled) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetOnScreenSizeEnabled) & ~FBoneSettings.__PropertyMask_BoneReductionTargetOnScreenSizeEnabled) | (value ? FBoneSettings.__PropertyMask_BoneReductionTargetOnScreenSizeEnabled : 0));
			}
		}

		// Token: 0x1700919C RID: 37276
		// (get) Token: 0x06025CF1 RID: 154865 RVA: 0x003952CA File Offset: 0x003934CA
		// (set) Token: 0x06025CF2 RID: 154866 RVA: 0x003952DA File Offset: 0x003934DA
		public unsafe int BoneReductionTargetOnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetOnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetOnScreenSize) = value;
			}
		}

		// Token: 0x1700919D RID: 37277
		// (get) Token: 0x06025CF3 RID: 154867 RVA: 0x003952EB File Offset: 0x003934EB
		// (set) Token: 0x06025CF4 RID: 154868 RVA: 0x003952FB File Offset: 0x003934FB
		public unsafe EBoneReductionTargetStopCondition BoneReductionTargetStopCondition
		{
			get
			{
				return (EBoneReductionTargetStopCondition)(*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetStopCondition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BoneReductionTargetStopCondition) = (byte)value;
			}
		}

		// Token: 0x1700919E RID: 37278
		// (get) Token: 0x06025CF5 RID: 154869 RVA: 0x0039530C File Offset: 0x0039350C
		// (set) Token: 0x06025CF6 RID: 154870 RVA: 0x00395325 File Offset: 0x00393525
		public unsafe bool RemoveUnusedBones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_RemoveUnusedBones) & FBoneSettings.__PropertyMask_RemoveUnusedBones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_RemoveUnusedBones) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_RemoveUnusedBones) & ~FBoneSettings.__PropertyMask_RemoveUnusedBones) | (value ? FBoneSettings.__PropertyMask_RemoveUnusedBones : 0));
			}
		}

		// Token: 0x1700919F RID: 37279
		// (get) Token: 0x06025CF7 RID: 154871 RVA: 0x00395355 File Offset: 0x00393555
		// (set) Token: 0x06025CF8 RID: 154872 RVA: 0x00395365 File Offset: 0x00393565
		public unsafe int LockBoneSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_LockBoneSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_LockBoneSelectionSetID) = value;
			}
		}

		// Token: 0x170091A0 RID: 37280
		// (get) Token: 0x06025CF9 RID: 154873 RVA: 0x00395376 File Offset: 0x00393576
		// (set) Token: 0x06025CFA RID: 154874 RVA: 0x0039538A File Offset: 0x0039358A
		public unsafe string LockBoneSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_LockBoneSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_LockBoneSelectionSetName)), value);
			}
		}

		// Token: 0x170091A1 RID: 37281
		// (get) Token: 0x06025CFB RID: 154875 RVA: 0x0039539F File Offset: 0x0039359F
		// (set) Token: 0x06025CFC RID: 154876 RVA: 0x003953AF File Offset: 0x003935AF
		public unsafe int RemoveBoneSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_RemoveBoneSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_RemoveBoneSelectionSetID) = value;
			}
		}

		// Token: 0x170091A2 RID: 37282
		// (get) Token: 0x06025CFD RID: 154877 RVA: 0x003953C0 File Offset: 0x003935C0
		// (set) Token: 0x06025CFE RID: 154878 RVA: 0x003953D4 File Offset: 0x003935D4
		public unsafe string RemoveBoneSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_RemoveBoneSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_RemoveBoneSelectionSetName)), value);
			}
		}

		// Token: 0x170091A3 RID: 37283
		// (get) Token: 0x06025CFF RID: 154879 RVA: 0x003953E9 File Offset: 0x003935E9
		// (set) Token: 0x06025D00 RID: 154880 RVA: 0x003953F9 File Offset: 0x003935F9
		public unsafe int BakePoseAnimationID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BakePoseAnimationID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_BakePoseAnimationID) = value;
			}
		}

		// Token: 0x170091A4 RID: 37284
		// (get) Token: 0x06025D01 RID: 154881 RVA: 0x0039540A File Offset: 0x0039360A
		// (set) Token: 0x06025D02 RID: 154882 RVA: 0x0039541E File Offset: 0x0039361E
		public unsafe string BakePoseAnimationName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_BakePoseAnimationName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBoneSettings.__PropertyOffset_BakePoseAnimationName)), value);
			}
		}

		// Token: 0x170091A5 RID: 37285
		// (get) Token: 0x06025D03 RID: 154883 RVA: 0x00395433 File Offset: 0x00393633
		// (set) Token: 0x06025D04 RID: 154884 RVA: 0x0039544C File Offset: 0x0039364C
		public unsafe bool LimitBonesPerVertex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_LimitBonesPerVertex) & FBoneSettings.__PropertyMask_LimitBonesPerVertex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_LimitBonesPerVertex) = ((*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_LimitBonesPerVertex) & ~FBoneSettings.__PropertyMask_LimitBonesPerVertex) | (value ? FBoneSettings.__PropertyMask_LimitBonesPerVertex : 0));
			}
		}

		// Token: 0x170091A6 RID: 37286
		// (get) Token: 0x06025D05 RID: 154885 RVA: 0x0039547C File Offset: 0x0039367C
		// (set) Token: 0x06025D06 RID: 154886 RVA: 0x0039548C File Offset: 0x0039368C
		public unsafe int MaxBonePerVertex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_MaxBonePerVertex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSettings.__PropertyOffset_MaxBonePerVertex) = value;
			}
		}

		// Token: 0x06025D07 RID: 154887 RVA: 0x0039549D File Offset: 0x0039369D
		public FBoneSettings()
		{
		}

		// Token: 0x06025D08 RID: 154888 RVA: 0x003954A8 File Offset: 0x003936A8
		public FBoneSettings(bool UseBoneReducer, bool BoneReductionTargetBoneRatioEnabled, float BoneReductionTargetBoneRatio, bool BoneReductionTargetBoneCountEnabled, int BoneReductionTargetBoneCount, bool BoneReductionTargetMaxDeviationEnabled, float BoneReductionTargetMaxDeviation, bool BoneReductionTargetOnScreenSizeEnabled, int BoneReductionTargetOnScreenSize, EBoneReductionTargetStopCondition BoneReductionTargetStopCondition, bool RemoveUnusedBones, int LockBoneSelectionSetID, string LockBoneSelectionSetName, int RemoveBoneSelectionSetID, string RemoveBoneSelectionSetName, int BakePoseAnimationID, string BakePoseAnimationName, bool LimitBonesPerVertex, int MaxBonePerVertex)
		{
			this.UseBoneReducer = UseBoneReducer;
			this.BoneReductionTargetBoneRatioEnabled = BoneReductionTargetBoneRatioEnabled;
			this.BoneReductionTargetBoneRatio = BoneReductionTargetBoneRatio;
			this.BoneReductionTargetBoneCountEnabled = BoneReductionTargetBoneCountEnabled;
			this.BoneReductionTargetBoneCount = BoneReductionTargetBoneCount;
			this.BoneReductionTargetMaxDeviationEnabled = BoneReductionTargetMaxDeviationEnabled;
			this.BoneReductionTargetMaxDeviation = BoneReductionTargetMaxDeviation;
			this.BoneReductionTargetOnScreenSizeEnabled = BoneReductionTargetOnScreenSizeEnabled;
			this.BoneReductionTargetOnScreenSize = BoneReductionTargetOnScreenSize;
			this.BoneReductionTargetStopCondition = BoneReductionTargetStopCondition;
			this.RemoveUnusedBones = RemoveUnusedBones;
			this.LockBoneSelectionSetID = LockBoneSelectionSetID;
			this.LockBoneSelectionSetName = LockBoneSelectionSetName;
			this.RemoveBoneSelectionSetID = RemoveBoneSelectionSetID;
			this.RemoveBoneSelectionSetName = RemoveBoneSelectionSetName;
			this.BakePoseAnimationID = BakePoseAnimationID;
			this.BakePoseAnimationName = BakePoseAnimationName;
			this.LimitBonesPerVertex = LimitBonesPerVertex;
			this.MaxBonePerVertex = MaxBonePerVertex;
		}

		// Token: 0x06025D09 RID: 154889 RVA: 0x00395550 File Offset: 0x00393750
		protected override IntPtr GetUStructPtr()
		{
			return FBoneSettings.StaticStruct();
		}

		// Token: 0x06025D0A RID: 154890 RVA: 0x0039555C File Offset: 0x0039375C
		[NullableContext(2)]
		public FBoneSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025D0B RID: 154891 RVA: 0x00395566 File Offset: 0x00393766
		public FBoneSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025D0C RID: 154892 RVA: 0x00395571 File Offset: 0x00393771
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneSettings(Pointer, false, true);
		}

		// Token: 0x06025D0D RID: 154893 RVA: 0x0039557B File Offset: 0x0039377B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401494F RID: 84303
		public const string __ObjectPath = "/Script/SimplygonUObjects.BoneSettings";

		// Token: 0x04014950 RID: 84304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014951 RID: 84305
		internal static int __PropertyOffset_UseBoneReducer;

		// Token: 0x04014952 RID: 84306
		internal static byte __PropertyMask_UseBoneReducer;

		// Token: 0x04014953 RID: 84307
		internal static int __PropertyOffset_BoneReductionTargetBoneRatioEnabled;

		// Token: 0x04014954 RID: 84308
		internal static byte __PropertyMask_BoneReductionTargetBoneRatioEnabled;

		// Token: 0x04014955 RID: 84309
		internal static int __PropertyOffset_BoneReductionTargetBoneRatio;

		// Token: 0x04014956 RID: 84310
		internal static int __PropertyOffset_BoneReductionTargetBoneCountEnabled;

		// Token: 0x04014957 RID: 84311
		internal static byte __PropertyMask_BoneReductionTargetBoneCountEnabled;

		// Token: 0x04014958 RID: 84312
		internal static int __PropertyOffset_BoneReductionTargetBoneCount;

		// Token: 0x04014959 RID: 84313
		internal static int __PropertyOffset_BoneReductionTargetMaxDeviationEnabled;

		// Token: 0x0401495A RID: 84314
		internal static byte __PropertyMask_BoneReductionTargetMaxDeviationEnabled;

		// Token: 0x0401495B RID: 84315
		internal static int __PropertyOffset_BoneReductionTargetMaxDeviation;

		// Token: 0x0401495C RID: 84316
		internal static int __PropertyOffset_BoneReductionTargetOnScreenSizeEnabled;

		// Token: 0x0401495D RID: 84317
		internal static byte __PropertyMask_BoneReductionTargetOnScreenSizeEnabled;

		// Token: 0x0401495E RID: 84318
		internal static int __PropertyOffset_BoneReductionTargetOnScreenSize;

		// Token: 0x0401495F RID: 84319
		internal static int __PropertyOffset_BoneReductionTargetStopCondition;

		// Token: 0x04014960 RID: 84320
		internal static int __PropertyOffset_RemoveUnusedBones;

		// Token: 0x04014961 RID: 84321
		internal static byte __PropertyMask_RemoveUnusedBones;

		// Token: 0x04014962 RID: 84322
		internal static int __PropertyOffset_LockBoneSelectionSetID;

		// Token: 0x04014963 RID: 84323
		internal static int __PropertyOffset_LockBoneSelectionSetName;

		// Token: 0x04014964 RID: 84324
		internal static int __PropertyOffset_RemoveBoneSelectionSetID;

		// Token: 0x04014965 RID: 84325
		internal static int __PropertyOffset_RemoveBoneSelectionSetName;

		// Token: 0x04014966 RID: 84326
		internal static int __PropertyOffset_BakePoseAnimationID;

		// Token: 0x04014967 RID: 84327
		internal static int __PropertyOffset_BakePoseAnimationName;

		// Token: 0x04014968 RID: 84328
		internal static int __PropertyOffset_LimitBonesPerVertex;

		// Token: 0x04014969 RID: 84329
		internal static byte __PropertyMask_LimitBonesPerVertex;

		// Token: 0x0401496A RID: 84330
		internal static int __PropertyOffset_MaxBonePerVertex;
	}
}
