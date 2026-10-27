using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033A RID: 826
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRandomPlayerSequenceEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002DFD RID: 11773 RVA: 0x0004695C File Offset: 0x00044B5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRandomPlayerSequenceEntry._ScriptStructPtr != 0) ? FRandomPlayerSequenceEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry", ref FRandomPlayerSequenceEntry._ScriptStructPtr);
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x00046980 File Offset: 0x00044B80
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00046994 File Offset: 0x00044B94
		[Nullable(2)]
		public unsafe UAnimSequence Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FRandomPlayerSequenceEntry.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRandomPlayerSequenceEntry.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x000469A9 File Offset: 0x00044BA9
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x000469B9 File Offset: 0x00044BB9
		public unsafe float ChanceToPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_ChanceToPlay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_ChanceToPlay) = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000469CA File Offset: 0x00044BCA
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x000469DA File Offset: 0x00044BDA
		public unsafe int MinLoopCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MinLoopCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MinLoopCount) = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000469EB File Offset: 0x00044BEB
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x000469FB File Offset: 0x00044BFB
		public unsafe int MaxLoopCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MaxLoopCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MaxLoopCount) = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00046A0C File Offset: 0x00044C0C
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00046A1C File Offset: 0x00044C1C
		public unsafe float MinPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MinPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MinPlayRate) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00046A2D File Offset: 0x00044C2D
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00046A3D File Offset: 0x00044C3D
		public unsafe float MaxPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MaxPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_MaxPlayRate) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00046A50 File Offset: 0x00044C50
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x00046A93 File Offset: 0x00044C93
		public FAlphaBlend BlendIn
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._BlendIn) == null)
				{
					result = (this._BlendIn = new FAlphaBlend(base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_BlendIn, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)FRandomPlayerSequenceEntry.__PropertyOffset_BlendIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00046AB4 File Offset: 0x00044CB4
		public FRandomPlayerSequenceEntry()
		{
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00046ABC File Offset: 0x00044CBC
		public FRandomPlayerSequenceEntry(UAnimSequence Sequence, float ChanceToPlay, int MinLoopCount, int MaxLoopCount, float MinPlayRate, float MaxPlayRate, FAlphaBlend BlendIn)
		{
			this.Sequence = Sequence;
			this.ChanceToPlay = ChanceToPlay;
			this.MinLoopCount = MinLoopCount;
			this.MaxLoopCount = MaxLoopCount;
			this.MinPlayRate = MinPlayRate;
			this.MaxPlayRate = MaxPlayRate;
			this.BlendIn = BlendIn;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00046AF9 File Offset: 0x00044CF9
		protected override IntPtr GetUStructPtr()
		{
			return FRandomPlayerSequenceEntry.StaticStruct();
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00046B05 File Offset: 0x00044D05
		[NullableContext(2)]
		public FRandomPlayerSequenceEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00046B0F File Offset: 0x00044D0F
		public FRandomPlayerSequenceEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00046B1A File Offset: 0x00044D1A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRandomPlayerSequenceEntry(Pointer, false, true);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00046B24 File Offset: 0x00044D24
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRandomPlayerSequenceEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040013B4 RID: 5044
		public const string __ObjectPath = "/Script/AnimGraphRuntime.RandomPlayerSequenceEntry";

		// Token: 0x040013B5 RID: 5045
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013B6 RID: 5046
		internal static int __PropertyOffset_Sequence;

		// Token: 0x040013B7 RID: 5047
		internal static int __PropertyOffset_ChanceToPlay;

		// Token: 0x040013B8 RID: 5048
		internal static int __PropertyOffset_MinLoopCount;

		// Token: 0x040013B9 RID: 5049
		internal static int __PropertyOffset_MaxLoopCount;

		// Token: 0x040013BA RID: 5050
		internal static int __PropertyOffset_MinPlayRate;

		// Token: 0x040013BB RID: 5051
		internal static int __PropertyOffset_MaxPlayRate;

		// Token: 0x040013BC RID: 5052
		internal static int __PropertyOffset_BlendIn;

		// Token: 0x040013BD RID: 5053
		[Nullable(2)]
		private FAlphaBlend _BlendIn;
	}
}
