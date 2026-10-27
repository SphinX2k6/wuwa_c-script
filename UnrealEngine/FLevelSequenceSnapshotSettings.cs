using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FC2 RID: 8130
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceSnapshotSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLevelSequenceSnapshotSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDA6 RID: 126374 RVA: 0x002DDA48 File Offset: 0x002DBC48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceSnapshotSettings._ScriptStructPtr != 0) ? FLevelSequenceSnapshotSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceSnapshotSettings", ref FLevelSequenceSnapshotSettings._ScriptStructPtr);
		}

		// Token: 0x17007AD1 RID: 31441
		// (get) Token: 0x0601EDA7 RID: 126375 RVA: 0x002DDA6C File Offset: 0x002DBC6C
		// (set) Token: 0x0601EDA8 RID: 126376 RVA: 0x002DDA7C File Offset: 0x002DBC7C
		public unsafe byte ZeroPadAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceSnapshotSettings.__PropertyOffset_ZeroPadAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceSnapshotSettings.__PropertyOffset_ZeroPadAmount) = value;
			}
		}

		// Token: 0x17007AD2 RID: 31442
		// (get) Token: 0x0601EDA9 RID: 126377 RVA: 0x002DDA8D File Offset: 0x002DBC8D
		// (set) Token: 0x0601EDAA RID: 126378 RVA: 0x002DDAA1 File Offset: 0x002DBCA1
		public unsafe FFrameRate FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceSnapshotSettings.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceSnapshotSettings.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x0601EDAB RID: 126379 RVA: 0x002DDAB6 File Offset: 0x002DBCB6
		public FLevelSequenceSnapshotSettings()
		{
		}

		// Token: 0x0601EDAC RID: 126380 RVA: 0x002DDABE File Offset: 0x002DBCBE
		public FLevelSequenceSnapshotSettings(byte ZeroPadAmount, FFrameRate FrameRate)
		{
			this.ZeroPadAmount = ZeroPadAmount;
			this.FrameRate = FrameRate;
		}

		// Token: 0x0601EDAD RID: 126381 RVA: 0x002DDAD4 File Offset: 0x002DBCD4
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceSnapshotSettings.StaticStruct();
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x002DDAE0 File Offset: 0x002DBCE0
		[NullableContext(2)]
		public FLevelSequenceSnapshotSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDAF RID: 126383 RVA: 0x002DDAEA File Offset: 0x002DBCEA
		public FLevelSequenceSnapshotSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x002DDAF5 File Offset: 0x002DBCF5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceSnapshotSettings(Pointer, false, true);
		}

		// Token: 0x0601EDB1 RID: 126385 RVA: 0x002DDAFF File Offset: 0x002DBCFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceSnapshotSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010ABE RID: 68286
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceSnapshotSettings";

		// Token: 0x04010ABF RID: 68287
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AC0 RID: 68288
		internal static int __PropertyOffset_ZeroPadAmount;

		// Token: 0x04010AC1 RID: 68289
		internal static int __PropertyOffset_FrameRate;
	}
}
