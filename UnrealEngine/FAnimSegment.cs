using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017E RID: 382
	[UnrealObjectPath("/Script/Engine.AnimSegment")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600185D RID: 6237 RVA: 0x00025279 File Offset: 0x00023479
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSegment._ScriptStructPtr != 0) ? FAnimSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSegment", ref FAnimSegment._ScriptStructPtr);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0002529D File Offset: 0x0002349D
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x000252B1 File Offset: 0x000234B1
		[Nullable(2)]
		public unsafe UAnimSequenceBase AnimReference
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimSegment.__PropertyOffset_AnimReference);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimSegment.__PropertyOffset_AnimReference, value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x000252C6 File Offset: 0x000234C6
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x000252D6 File Offset: 0x000234D6
		public unsafe float StartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_StartPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_StartPos) = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x000252E7 File Offset: 0x000234E7
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x000252F7 File Offset: 0x000234F7
		public unsafe float AnimStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimStartTime) = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00025308 File Offset: 0x00023508
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00025318 File Offset: 0x00023518
		public unsafe float AnimEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimEndTime) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00025329 File Offset: 0x00023529
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x00025339 File Offset: 0x00023539
		public unsafe float AnimPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimPlayRate) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0002534A File Offset: 0x0002354A
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0002535A File Offset: 0x0002355A
		public unsafe int LoopingCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_LoopingCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_LoopingCount) = value;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0002536B File Offset: 0x0002356B
		public FAnimSegment()
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00025373 File Offset: 0x00023573
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSegment.StaticStruct();
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0002537F File Offset: 0x0002357F
		[NullableContext(2)]
		public FAnimSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00025389 File Offset: 0x00023589
		public FAnimSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00025394 File Offset: 0x00023594
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSegment(Pointer, false, true);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0002539E File Offset: 0x0002359E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSegment(Pointer, MemoryOwner);
		}

		// Token: 0x040007B7 RID: 1975
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimSegment";

		// Token: 0x040007B8 RID: 1976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007B9 RID: 1977
		internal static int __PropertyOffset_AnimReference;

		// Token: 0x040007BA RID: 1978
		internal static int __PropertyOffset_StartPos;

		// Token: 0x040007BB RID: 1979
		internal static int __PropertyOffset_AnimStartTime;

		// Token: 0x040007BC RID: 1980
		internal static int __PropertyOffset_AnimEndTime;

		// Token: 0x040007BD RID: 1981
		internal static int __PropertyOffset_AnimPlayRate;

		// Token: 0x040007BE RID: 1982
		internal static int __PropertyOffset_LoopingCount;
	}
}
