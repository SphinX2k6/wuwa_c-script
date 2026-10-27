using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB2 RID: 8114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceAnimSequenceLinkItem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLevelSequenceAnimSequenceLinkItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ECD6 RID: 126166 RVA: 0x002DC84E File Offset: 0x002DAA4E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceAnimSequenceLinkItem._ScriptStructPtr != 0) ? FLevelSequenceAnimSequenceLinkItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceAnimSequenceLinkItem", ref FLevelSequenceAnimSequenceLinkItem._ScriptStructPtr);
		}

		// Token: 0x17007AAB RID: 31403
		// (get) Token: 0x0601ECD7 RID: 126167 RVA: 0x002DC872 File Offset: 0x002DAA72
		// (set) Token: 0x0601ECD8 RID: 126168 RVA: 0x002DC886 File Offset: 0x002DAA86
		public unsafe FGuid SkelTrackGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_SkelTrackGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_SkelTrackGuid) = value;
			}
		}

		// Token: 0x17007AAC RID: 31404
		// (get) Token: 0x0601ECD9 RID: 126169 RVA: 0x002DC89C File Offset: 0x002DAA9C
		// (set) Token: 0x0601ECDA RID: 126170 RVA: 0x002DC8DF File Offset: 0x002DAADF
		public FSoftObjectPath PathToAnimSequence
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PathToAnimSequence) == null)
				{
					result = (this._PathToAnimSequence = new FSoftObjectPath(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_PathToAnimSequence, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_PathToAnimSequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AAD RID: 31405
		// (get) Token: 0x0601ECDB RID: 126171 RVA: 0x002DC900 File Offset: 0x002DAB00
		// (set) Token: 0x0601ECDC RID: 126172 RVA: 0x002DC910 File Offset: 0x002DAB10
		public unsafe bool bExportTransforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bExportTransforms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bExportTransforms) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007AAE RID: 31406
		// (get) Token: 0x0601ECDD RID: 126173 RVA: 0x002DC921 File Offset: 0x002DAB21
		// (set) Token: 0x0601ECDE RID: 126174 RVA: 0x002DC931 File Offset: 0x002DAB31
		public unsafe bool bExportCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bExportCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bExportCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007AAF RID: 31407
		// (get) Token: 0x0601ECDF RID: 126175 RVA: 0x002DC942 File Offset: 0x002DAB42
		// (set) Token: 0x0601ECE0 RID: 126176 RVA: 0x002DC952 File Offset: 0x002DAB52
		public unsafe bool bRecordInWorldSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bRecordInWorldSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceAnimSequenceLinkItem.__PropertyOffset_bRecordInWorldSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601ECE1 RID: 126177 RVA: 0x002DC963 File Offset: 0x002DAB63
		public FLevelSequenceAnimSequenceLinkItem()
		{
		}

		// Token: 0x0601ECE2 RID: 126178 RVA: 0x002DC96B File Offset: 0x002DAB6B
		public FLevelSequenceAnimSequenceLinkItem(FGuid SkelTrackGuid, FSoftObjectPath PathToAnimSequence, bool bExportTransforms, bool bExportCurves, bool bRecordInWorldSpace)
		{
			this.SkelTrackGuid = SkelTrackGuid;
			this.PathToAnimSequence = PathToAnimSequence;
			this.bExportTransforms = bExportTransforms;
			this.bExportCurves = bExportCurves;
			this.bRecordInWorldSpace = bRecordInWorldSpace;
		}

		// Token: 0x0601ECE3 RID: 126179 RVA: 0x002DC998 File Offset: 0x002DAB98
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceAnimSequenceLinkItem.StaticStruct();
		}

		// Token: 0x0601ECE4 RID: 126180 RVA: 0x002DC9A4 File Offset: 0x002DABA4
		[NullableContext(2)]
		public FLevelSequenceAnimSequenceLinkItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ECE5 RID: 126181 RVA: 0x002DC9AE File Offset: 0x002DABAE
		public FLevelSequenceAnimSequenceLinkItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ECE6 RID: 126182 RVA: 0x002DC9B9 File Offset: 0x002DABB9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceAnimSequenceLinkItem(Pointer, false, true);
		}

		// Token: 0x0601ECE7 RID: 126183 RVA: 0x002DC9C3 File Offset: 0x002DABC3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceAnimSequenceLinkItem(Pointer, MemoryOwner);
		}

		// Token: 0x04010A63 RID: 68195
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceAnimSequenceLinkItem";

		// Token: 0x04010A64 RID: 68196
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A65 RID: 68197
		internal static int __PropertyOffset_SkelTrackGuid;

		// Token: 0x04010A66 RID: 68198
		internal static int __PropertyOffset_PathToAnimSequence;

		// Token: 0x04010A67 RID: 68199
		[Nullable(2)]
		private FSoftObjectPath _PathToAnimSequence;

		// Token: 0x04010A68 RID: 68200
		internal static int __PropertyOffset_bExportTransforms;

		// Token: 0x04010A69 RID: 68201
		internal static int __PropertyOffset_bExportCurves;

		// Token: 0x04010A6A RID: 68202
		internal static int __PropertyOffset_bRecordInWorldSpace;
	}
}
