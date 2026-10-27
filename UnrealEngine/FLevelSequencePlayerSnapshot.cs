using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC1 RID: 8129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequencePlayerSnapshot")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FLevelSequencePlayerSnapshot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED88 RID: 126344 RVA: 0x002DD637 File Offset: 0x002DB837
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequencePlayerSnapshot._ScriptStructPtr != 0) ? FLevelSequencePlayerSnapshot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequencePlayerSnapshot", ref FLevelSequencePlayerSnapshot._ScriptStructPtr);
		}

		// Token: 0x17007AC6 RID: 31430
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x002DD65B File Offset: 0x002DB85B
		// (set) Token: 0x0601ED8A RID: 126346 RVA: 0x002DD66F File Offset: 0x002DB86F
		public unsafe string MasterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_MasterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_MasterName)), value);
			}
		}

		// Token: 0x17007AC7 RID: 31431
		// (get) Token: 0x0601ED8B RID: 126347 RVA: 0x002DD684 File Offset: 0x002DB884
		// (set) Token: 0x0601ED8C RID: 126348 RVA: 0x002DD6C7 File Offset: 0x002DB8C7
		public FQualifiedFrameTime MasterTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._MasterTime) == null)
				{
					result = (this._MasterTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_MasterTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_MasterTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AC8 RID: 31432
		// (get) Token: 0x0601ED8D RID: 126349 RVA: 0x002DD6E8 File Offset: 0x002DB8E8
		// (set) Token: 0x0601ED8E RID: 126350 RVA: 0x002DD72B File Offset: 0x002DB92B
		public FQualifiedFrameTime SourceTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._SourceTime) == null)
				{
					result = (this._SourceTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_SourceTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_SourceTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AC9 RID: 31433
		// (get) Token: 0x0601ED8F RID: 126351 RVA: 0x002DD74C File Offset: 0x002DB94C
		// (set) Token: 0x0601ED90 RID: 126352 RVA: 0x002DD760 File Offset: 0x002DB960
		public unsafe string CurrentShotName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotName)), value);
			}
		}

		// Token: 0x17007ACA RID: 31434
		// (get) Token: 0x0601ED91 RID: 126353 RVA: 0x002DD778 File Offset: 0x002DB978
		// (set) Token: 0x0601ED92 RID: 126354 RVA: 0x002DD7BB File Offset: 0x002DB9BB
		public FQualifiedFrameTime CurrentShotLocalTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._CurrentShotLocalTime) == null)
				{
					result = (this._CurrentShotLocalTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotLocalTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotLocalTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007ACB RID: 31435
		// (get) Token: 0x0601ED93 RID: 126355 RVA: 0x002DD7DC File Offset: 0x002DB9DC
		// (set) Token: 0x0601ED94 RID: 126356 RVA: 0x002DD81F File Offset: 0x002DBA1F
		public FQualifiedFrameTime CurrentShotSourceTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._CurrentShotSourceTime) == null)
				{
					result = (this._CurrentShotSourceTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotSourceTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CurrentShotSourceTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007ACC RID: 31436
		// (get) Token: 0x0601ED95 RID: 126357 RVA: 0x002DD840 File Offset: 0x002DBA40
		// (set) Token: 0x0601ED96 RID: 126358 RVA: 0x002DD854 File Offset: 0x002DBA54
		public unsafe string SourceTimecode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_SourceTimecode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_SourceTimecode)), value);
			}
		}

		// Token: 0x17007ACD RID: 31437
		// (get) Token: 0x0601ED97 RID: 126359 RVA: 0x002DD869 File Offset: 0x002DBA69
		// (set) Token: 0x0601ED98 RID: 126360 RVA: 0x002DD888 File Offset: 0x002DBA88
		public TSoftObjectPtr<UCameraComponent> CameraComponent
		{
			get
			{
				return new TSoftObjectPtr<UCameraComponent>(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CameraComponent, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_CameraComponent, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17007ACE RID: 31438
		// (get) Token: 0x0601ED99 RID: 126361 RVA: 0x002DD8B0 File Offset: 0x002DBAB0
		// (set) Token: 0x0601ED9A RID: 126362 RVA: 0x002DD8F3 File Offset: 0x002DBAF3
		public FLevelSequenceSnapshotSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FLevelSequenceSnapshotSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FLevelSequenceSnapshotSettings(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLevelSequenceSnapshotSettings.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007ACF RID: 31439
		// (get) Token: 0x0601ED9B RID: 126363 RVA: 0x002DD914 File Offset: 0x002DBB14
		// (set) Token: 0x0601ED9C RID: 126364 RVA: 0x002DD928 File Offset: 0x002DBB28
		[Nullable(2)]
		public unsafe ULevelSequence ActiveShot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelSequencePlayerSnapshot.__PropertyOffset_ActiveShot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelSequencePlayerSnapshot.__PropertyOffset_ActiveShot, value);
			}
		}

		// Token: 0x17007AD0 RID: 31440
		// (get) Token: 0x0601ED9D RID: 126365 RVA: 0x002DD940 File Offset: 0x002DBB40
		// (set) Token: 0x0601ED9E RID: 126366 RVA: 0x002DD983 File Offset: 0x002DBB83
		public FMovieSceneSequenceID ShotID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._ShotID) == null)
				{
					result = (this._ShotID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_ShotID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequencePlayerSnapshot.__PropertyOffset_ShotID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601ED9F RID: 126367 RVA: 0x002DD9A4 File Offset: 0x002DBBA4
		public FLevelSequencePlayerSnapshot()
		{
		}

		// Token: 0x0601EDA0 RID: 126368 RVA: 0x002DD9AC File Offset: 0x002DBBAC
		public FLevelSequencePlayerSnapshot(string MasterName, FQualifiedFrameTime MasterTime, FQualifiedFrameTime SourceTime, string CurrentShotName, FQualifiedFrameTime CurrentShotLocalTime, FQualifiedFrameTime CurrentShotSourceTime, string SourceTimecode, TSoftObjectPtr<UCameraComponent> CameraComponent, FLevelSequenceSnapshotSettings Settings, ULevelSequence ActiveShot, FMovieSceneSequenceID ShotID)
		{
			this.MasterName = MasterName;
			this.MasterTime = MasterTime;
			this.SourceTime = SourceTime;
			this.CurrentShotName = CurrentShotName;
			this.CurrentShotLocalTime = CurrentShotLocalTime;
			this.CurrentShotSourceTime = CurrentShotSourceTime;
			this.SourceTimecode = SourceTimecode;
			this.CameraComponent = CameraComponent;
			this.Settings = Settings;
			this.ActiveShot = ActiveShot;
			this.ShotID = ShotID;
		}

		// Token: 0x0601EDA1 RID: 126369 RVA: 0x002DDA14 File Offset: 0x002DBC14
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequencePlayerSnapshot.StaticStruct();
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x002DDA20 File Offset: 0x002DBC20
		[NullableContext(2)]
		public FLevelSequencePlayerSnapshot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDA3 RID: 126371 RVA: 0x002DDA2A File Offset: 0x002DBC2A
		public FLevelSequencePlayerSnapshot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDA4 RID: 126372 RVA: 0x002DDA35 File Offset: 0x002DBC35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequencePlayerSnapshot(Pointer, false, true);
		}

		// Token: 0x0601EDA5 RID: 126373 RVA: 0x002DDA3F File Offset: 0x002DBC3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequencePlayerSnapshot(Pointer, MemoryOwner);
		}

		// Token: 0x04010AAB RID: 68267
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequencePlayerSnapshot";

		// Token: 0x04010AAC RID: 68268
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AAD RID: 68269
		internal static int __PropertyOffset_MasterName;

		// Token: 0x04010AAE RID: 68270
		internal static int __PropertyOffset_MasterTime;

		// Token: 0x04010AAF RID: 68271
		[Nullable(2)]
		private FQualifiedFrameTime _MasterTime;

		// Token: 0x04010AB0 RID: 68272
		internal static int __PropertyOffset_SourceTime;

		// Token: 0x04010AB1 RID: 68273
		[Nullable(2)]
		private FQualifiedFrameTime _SourceTime;

		// Token: 0x04010AB2 RID: 68274
		internal static int __PropertyOffset_CurrentShotName;

		// Token: 0x04010AB3 RID: 68275
		internal static int __PropertyOffset_CurrentShotLocalTime;

		// Token: 0x04010AB4 RID: 68276
		[Nullable(2)]
		private FQualifiedFrameTime _CurrentShotLocalTime;

		// Token: 0x04010AB5 RID: 68277
		internal static int __PropertyOffset_CurrentShotSourceTime;

		// Token: 0x04010AB6 RID: 68278
		[Nullable(2)]
		private FQualifiedFrameTime _CurrentShotSourceTime;

		// Token: 0x04010AB7 RID: 68279
		internal static int __PropertyOffset_SourceTimecode;

		// Token: 0x04010AB8 RID: 68280
		internal static int __PropertyOffset_CameraComponent;

		// Token: 0x04010AB9 RID: 68281
		internal static int __PropertyOffset_Settings;

		// Token: 0x04010ABA RID: 68282
		[Nullable(2)]
		private FLevelSequenceSnapshotSettings _Settings;

		// Token: 0x04010ABB RID: 68283
		internal static int __PropertyOffset_ActiveShot;

		// Token: 0x04010ABC RID: 68284
		internal static int __PropertyOffset_ShotID;

		// Token: 0x04010ABD RID: 68285
		[Nullable(2)]
		private FMovieSceneSequenceID _ShotID;
	}
}
