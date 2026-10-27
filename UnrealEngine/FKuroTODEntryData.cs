using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BD1 RID: 7121
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroTODEntryData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroTODEntryData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B554 RID: 111956 RVA: 0x0028447F File Offset: 0x0028267F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTODEntryData._ScriptStructPtr != 0) ? FKuroTODEntryData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroTODEntryData", ref FKuroTODEntryData._ScriptStructPtr);
		}

		// Token: 0x17006DD7 RID: 28119
		// (get) Token: 0x0601B555 RID: 111957 RVA: 0x002844A3 File Offset: 0x002826A3
		// (set) Token: 0x0601B556 RID: 111958 RVA: 0x002844B7 File Offset: 0x002826B7
		public unsafe FVector2D StartEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTODEntryData.__PropertyOffset_StartEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTODEntryData.__PropertyOffset_StartEndTime) = value;
			}
		}

		// Token: 0x17006DD8 RID: 28120
		// (get) Token: 0x0601B557 RID: 111959 RVA: 0x002844CC File Offset: 0x002826CC
		// (set) Token: 0x0601B558 RID: 111960 RVA: 0x002844DC File Offset: 0x002826DC
		public unsafe int DataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTODEntryData.__PropertyOffset_DataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTODEntryData.__PropertyOffset_DataIndex) = value;
			}
		}

		// Token: 0x0601B559 RID: 111961 RVA: 0x002844ED File Offset: 0x002826ED
		public FKuroTODEntryData()
		{
		}

		// Token: 0x0601B55A RID: 111962 RVA: 0x002844F5 File Offset: 0x002826F5
		public FKuroTODEntryData(FVector2D StartEndTime, int DataIndex)
		{
			this.StartEndTime = StartEndTime;
			this.DataIndex = DataIndex;
		}

		// Token: 0x0601B55B RID: 111963 RVA: 0x0028450B File Offset: 0x0028270B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTODEntryData.StaticStruct();
		}

		// Token: 0x0601B55C RID: 111964 RVA: 0x00284517 File Offset: 0x00282717
		[NullableContext(2)]
		public FKuroTODEntryData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B55D RID: 111965 RVA: 0x00284521 File Offset: 0x00282721
		public FKuroTODEntryData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B55E RID: 111966 RVA: 0x0028452C File Offset: 0x0028272C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTODEntryData(Pointer, false, true);
		}

		// Token: 0x0601B55F RID: 111967 RVA: 0x00284536 File Offset: 0x00282736
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTODEntryData(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB78 RID: 60280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroTODEntryData";

		// Token: 0x0400EB79 RID: 60281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB7A RID: 60282
		internal static int __PropertyOffset_StartEndTime;

		// Token: 0x0400EB7B RID: 60283
		internal static int __PropertyOffset_DataIndex;
	}
}
