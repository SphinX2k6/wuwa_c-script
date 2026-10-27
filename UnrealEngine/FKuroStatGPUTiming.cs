using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BC8 RID: 7112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroStatGPUTiming")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroStatGPUTiming : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B494 RID: 111764 RVA: 0x00283539 File Offset: 0x00281739
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStatGPUTiming._ScriptStructPtr != 0) ? FKuroStatGPUTiming._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroStatGPUTiming", ref FKuroStatGPUTiming._ScriptStructPtr);
		}

		// Token: 0x17006D9A RID: 28058
		// (get) Token: 0x0601B495 RID: 111765 RVA: 0x0028355D File Offset: 0x0028175D
		// (set) Token: 0x0601B496 RID: 111766 RVA: 0x00283571 File Offset: 0x00281771
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroStatGPUTiming.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroStatGPUTiming.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17006D9B RID: 28059
		// (get) Token: 0x0601B497 RID: 111767 RVA: 0x00283586 File Offset: 0x00281786
		// (set) Token: 0x0601B498 RID: 111768 RVA: 0x0028359A File Offset: 0x0028179A
		public unsafe FName StatName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_StatName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_StatName) = value;
			}
		}

		// Token: 0x17006D9C RID: 28060
		// (get) Token: 0x0601B499 RID: 111769 RVA: 0x002835AF File Offset: 0x002817AF
		// (set) Token: 0x0601B49A RID: 111770 RVA: 0x002835BF File Offset: 0x002817BF
		public unsafe float AverageMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_AverageMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_AverageMs) = value;
			}
		}

		// Token: 0x17006D9D RID: 28061
		// (get) Token: 0x0601B49B RID: 111771 RVA: 0x002835D0 File Offset: 0x002817D0
		// (set) Token: 0x0601B49C RID: 111772 RVA: 0x002835E0 File Offset: 0x002817E0
		public unsafe float MaxMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_MaxMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_MaxMs) = value;
			}
		}

		// Token: 0x17006D9E RID: 28062
		// (get) Token: 0x0601B49D RID: 111773 RVA: 0x002835F1 File Offset: 0x002817F1
		// (set) Token: 0x0601B49E RID: 111774 RVA: 0x00283601 File Offset: 0x00281801
		public unsafe float MinMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_MinMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStatGPUTiming.__PropertyOffset_MinMs) = value;
			}
		}

		// Token: 0x0601B49F RID: 111775 RVA: 0x00283612 File Offset: 0x00281812
		public FKuroStatGPUTiming()
		{
		}

		// Token: 0x0601B4A0 RID: 111776 RVA: 0x0028361A File Offset: 0x0028181A
		public FKuroStatGPUTiming(string Name, FName StatName, float AverageMs, float MaxMs, float MinMs)
		{
			this.Name = Name;
			this.StatName = StatName;
			this.AverageMs = AverageMs;
			this.MaxMs = MaxMs;
			this.MinMs = MinMs;
		}

		// Token: 0x0601B4A1 RID: 111777 RVA: 0x00283647 File Offset: 0x00281847
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStatGPUTiming.StaticStruct();
		}

		// Token: 0x0601B4A2 RID: 111778 RVA: 0x00283653 File Offset: 0x00281853
		[NullableContext(2)]
		public FKuroStatGPUTiming(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B4A3 RID: 111779 RVA: 0x0028365D File Offset: 0x0028185D
		public FKuroStatGPUTiming(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B4A4 RID: 111780 RVA: 0x00283668 File Offset: 0x00281868
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStatGPUTiming(Pointer, false, true);
		}

		// Token: 0x0601B4A5 RID: 111781 RVA: 0x00283672 File Offset: 0x00281872
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStatGPUTiming(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB1F RID: 60191
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroStatGPUTiming";

		// Token: 0x0400EB20 RID: 60192
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB21 RID: 60193
		internal static int __PropertyOffset_Name;

		// Token: 0x0400EB22 RID: 60194
		internal static int __PropertyOffset_StatName;

		// Token: 0x0400EB23 RID: 60195
		internal static int __PropertyOffset_AverageMs;

		// Token: 0x0400EB24 RID: 60196
		internal static int __PropertyOffset_MaxMs;

		// Token: 0x0400EB25 RID: 60197
		internal static int __PropertyOffset_MinMs;
	}
}
