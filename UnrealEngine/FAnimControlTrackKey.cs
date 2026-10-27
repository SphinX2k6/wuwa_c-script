using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FE RID: 2046
	[UnrealObjectPath("/Script/Engine.AnimControlTrackKey")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimControlTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D30 RID: 27952 RVA: 0x0009D2DD File Offset: 0x0009B4DD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimControlTrackKey._ScriptStructPtr != 0) ? FAnimControlTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimControlTrackKey", ref FAnimControlTrackKey._ScriptStructPtr);
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x0009D301 File Offset: 0x0009B501
		// (set) Token: 0x06006D32 RID: 27954 RVA: 0x0009D311 File Offset: 0x0009B511
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x0009D322 File Offset: 0x0009B522
		// (set) Token: 0x06006D34 RID: 27956 RVA: 0x0009D336 File Offset: 0x0009B536
		[Nullable(2)]
		public unsafe UAnimSequence AnimSeq
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimControlTrackKey.__PropertyOffset_AnimSeq);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimControlTrackKey.__PropertyOffset_AnimSeq, value);
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x0009D34B File Offset: 0x0009B54B
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x0009D35B File Offset: 0x0009B55B
		public unsafe float AnimStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimStartOffset) = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x0009D36C File Offset: 0x0009B56C
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x0009D37C File Offset: 0x0009B57C
		public unsafe float AnimEndOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimEndOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimEndOffset) = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x0009D38D File Offset: 0x0009B58D
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x0009D39D File Offset: 0x0009B59D
		public unsafe float AnimPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_AnimPlayRate) = value;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x0009D3AE File Offset: 0x0009B5AE
		// (set) Token: 0x06006D3C RID: 27964 RVA: 0x0009D3C7 File Offset: 0x0009B5C7
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bLooping) & FAnimControlTrackKey.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bLooping) & ~FAnimControlTrackKey.__PropertyMask_bLooping) | (value ? FAnimControlTrackKey.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06006D3D RID: 27965 RVA: 0x0009D3F7 File Offset: 0x0009B5F7
		// (set) Token: 0x06006D3E RID: 27966 RVA: 0x0009D410 File Offset: 0x0009B610
		public unsafe bool bReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bReverse) & FAnimControlTrackKey.__PropertyMask_bReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bReverse) = ((*(base.NativePtr + (IntPtr)FAnimControlTrackKey.__PropertyOffset_bReverse) & ~FAnimControlTrackKey.__PropertyMask_bReverse) | (value ? FAnimControlTrackKey.__PropertyMask_bReverse : 0));
			}
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x0009D440 File Offset: 0x0009B640
		public FAnimControlTrackKey()
		{
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x0009D448 File Offset: 0x0009B648
		[NullableContext(1)]
		public FAnimControlTrackKey(float StartTime, UAnimSequence AnimSeq, float AnimStartOffset, float AnimEndOffset, float AnimPlayRate, bool bLooping, bool bReverse)
		{
			this.StartTime = StartTime;
			this.AnimSeq = AnimSeq;
			this.AnimStartOffset = AnimStartOffset;
			this.AnimEndOffset = AnimEndOffset;
			this.AnimPlayRate = AnimPlayRate;
			this.bLooping = bLooping;
			this.bReverse = bReverse;
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x0009D485 File Offset: 0x0009B685
		protected override IntPtr GetUStructPtr()
		{
			return FAnimControlTrackKey.StaticStruct();
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x0009D491 File Offset: 0x0009B691
		[NullableContext(2)]
		public FAnimControlTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x0009D49B File Offset: 0x0009B69B
		public FAnimControlTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x0009D4A6 File Offset: 0x0009B6A6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimControlTrackKey(Pointer, false, true);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0009D4B0 File Offset: 0x0009B6B0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimControlTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x040034BE RID: 13502
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimControlTrackKey";

		// Token: 0x040034BF RID: 13503
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034C0 RID: 13504
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040034C1 RID: 13505
		internal static int __PropertyOffset_AnimSeq;

		// Token: 0x040034C2 RID: 13506
		internal static int __PropertyOffset_AnimStartOffset;

		// Token: 0x040034C3 RID: 13507
		internal static int __PropertyOffset_AnimEndOffset;

		// Token: 0x040034C4 RID: 13508
		internal static int __PropertyOffset_AnimPlayRate;

		// Token: 0x040034C5 RID: 13509
		internal static int __PropertyOffset_bLooping;

		// Token: 0x040034C6 RID: 13510
		internal static byte __PropertyMask_bLooping;

		// Token: 0x040034C7 RID: 13511
		internal static int __PropertyOffset_bReverse;

		// Token: 0x040034C8 RID: 13512
		internal static byte __PropertyMask_bReverse;
	}
}
